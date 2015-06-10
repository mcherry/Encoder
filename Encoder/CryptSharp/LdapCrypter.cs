#region License
/*
CryptSharp
Copyright (c) 2013 James F. Bellinger <http://www.zer7.com/software/cryptsharp>

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
*/
#endregion

using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using CryptSharp.Internal;

namespace CryptSharp
{
    /// <summary>
    /// LDAP schemes such as {SHA}.
    /// </summary>
    public class LdapCrypter : Crypter
    {
        static readonly Regex _crypt = CreateRegex(@"\A(?<prefix>{(?i:CRYPT)\})(?<salt>.*)\z");
        static readonly Regex _ssha = CreateRegex(@"\A(?<prefix>{(?i:SSHA)\})(?<salt>[A-Za-z0-9+/]*={0,3})\z");
        static readonly Regex _smd5 = CreateRegex(@"\A(?<prefix>{(?i:SMD5)\})(?<salt>[A-Za-z0-9+/]*={0,3})\z");
        static readonly Regex _sha = CreateRegex(@"\A(?<prefix>{(?i:SHA)\})[A-Za-z0-9+/]*={0,3}\z");
        static readonly Regex _md5 = CreateRegex(@"\A(?<prefix>{(?i:MD5)\})[A-Za-z0-9+/]*={0,3}\z");
        static readonly Regex _cleartext = CreateRegex(@"\A(?<prefix>{(?i:CLEARTEXT)\})(?<salt>.*)\z");

        CrypterEnvironment _environment;

        /// <summary>
        /// Initializes a new instance of the <see cref="LdapCrypter"/> class.
        /// The specified environment is searched for the {CRYPT} password scheme.
        /// </summary>
        /// <param name="cryptSchemeEnvironment">The environment for the {CRYPT} passwod scheme.</param>
        public LdapCrypter(CrypterEnvironment cryptSchemeEnvironment)
        {
            Check.Null("environment", cryptSchemeEnvironment);

            _environment = cryptSchemeEnvironment;
        }

        /// <inheritdoc />
        public override string GenerateSalt(CrypterOptions options)
        {
            Check.Null("options", options);

            switch (options.GetValue(CrypterOption.Variant, LdapCrypterVariant.SSha))
            {
                case LdapCrypterVariant.Crypt:
                    Crypter crypter = options.GetValue<Crypter>(LdapCrypterOption.Crypter);
                    if (crypter == null)
                    {
                        throw Exceptions.Argument("LdapCrypterOption.Crypter",
                                                  "Crypter not set. Did you intend Crypter.TraditionalDes (the slappasswd default)?");
                    }

                    CrypterOptions crypterOptions = options.GetValue(LdapCrypterOption.CrypterOptions, CrypterOptions.None);
                    return "{CRYPT}" + crypter.GenerateSalt(crypterOptions);

                case LdapCrypterVariant.SSha: return "{SSHA}" + Convert.ToBase64String(Security.GenerateRandomBytes(8));
                case LdapCrypterVariant.SMD5: return "{SMD5}" + Convert.ToBase64String(Security.GenerateRandomBytes(8));
                case LdapCrypterVariant.Sha: return "{SHA}";
                case LdapCrypterVariant.MD5: return "{MD5}";
                case LdapCrypterVariant.Cleartext: return "{CLEARTEXT}";
                default: throw Exceptions.ArgumentOutOfRange("CrypterOption.Variant", "Unknown variant.");
            }
        }

        /// <inheritdoc />
        public override bool CanCrypt(string salt)
        {
            Check.Null("salt", salt);

            Match match; LdapCrypterVariant variant;
            return salt.StartsWith("{") && // Quick out for matching.
                TryMatch(salt, out match, out variant);
        }

        /// <inheritdoc />
        public override string Crypt(byte[] password, string salt)
        {
            Check.Null("password", password);
            Check.Null("salt", salt);

            Match match; LdapCrypterVariant variant;
            if (!TryMatch(salt, out match, out variant)) { throw Exceptions.Argument("salt", "Invalid salt."); }

            string prefixString = match.Groups["prefix"].Value;
            string saltString = match.Groups["salt"].Value;

            byte[] saltBytes = null;
            try
            {
                switch (variant)
                {
                    case LdapCrypterVariant.Crypt:
                        Crypter crypter;
                        if (!_environment.TryGetCrypter(saltString, out crypter)) { goto default; }
                        if (crypter is LdapCrypter) { throw Exceptions.Argument("salt", "LDAP {CRYPT} tried to use an LDAP scheme."); }
                        return prefixString + crypter.Crypt(password, saltString);

                    case LdapCrypterVariant.SSha:
                        if (!TryConvertFromBase64String(saltString, out saltBytes)) { throw Exceptions.Argument("salt", "Bad base-64."); }
                        return prefixString + SaltedCrypt(SHA1.Create(), password, saltBytes);

                    case LdapCrypterVariant.SMD5:
                        if (!TryConvertFromBase64String(saltString, out saltBytes)) { throw Exceptions.Argument("salt", "Bad base-64."); }
                        return prefixString + SaltedCrypt(System.Security.Cryptography.MD5.Create(), password, saltBytes);

                    case LdapCrypterVariant.Sha:
                        return prefixString + UnsaltedCrypt(SHA1.Create(), password);

                    case LdapCrypterVariant.MD5:
                        return prefixString + UnsaltedCrypt(System.Security.Cryptography.MD5.Create(), password);

                    case LdapCrypterVariant.Cleartext:
                        return prefixString + Encoding.UTF8.GetString(password);

                    default:
                        throw Exceptions.ArgumentOutOfRange("CrypterOption.Variant", "Unknown variant.");
                }
            }
            finally
            {
                Security.Clear(saltBytes);
            }
        }

        static bool TryConvertFromBase64String(string s, out byte[] bytes)
        {
            try { bytes = Convert.FromBase64String(s); return true; }
            catch (FormatException) { bytes = null; return false; }
        }

        static string UnsaltedCrypt(HashAlgorithm algorithm, byte[] password)
        {
            try
            {
                algorithm.Initialize();
                algorithm.TransformBlock(password, 0, password.Length, password, 0);
                algorithm.TransformFinalBlock(new byte[0], 0, 0);

                string crypt = Convert.ToBase64String(algorithm.Hash);
                return crypt;
            }
            finally
            {
                algorithm.Clear();
            }
        }

        static string SaltedCrypt(HashAlgorithm algorithm, byte[] password, byte[] salt)
        {
            // If we're under the hash length, assume we only have the salt.
            int hashLength = algorithm.HashSize / 8;
            int saltOffset = salt.Length < hashLength ? 0 : hashLength;
            int saltLength = salt.Length - saltOffset;

            byte[] saltedHash = new byte[hashLength + saltLength];
            try
            {
                algorithm.Initialize();
                algorithm.TransformBlock(password, 0, password.Length, password, 0);
                algorithm.TransformBlock(salt, saltOffset, saltLength, salt, saltOffset);
                algorithm.TransformFinalBlock(new byte[0], 0, 0);

                Array.Copy(algorithm.Hash, saltedHash, hashLength);
                Array.Copy(salt, saltOffset, saltedHash, hashLength, saltLength);
                string crypt = Convert.ToBase64String(saltedHash);
                return crypt;
            }
            finally
            {
                algorithm.Clear();
                Security.Clear(saltedHash);
            }
        }

        static Regex CreateRegex(string pattern)
        {
            return new Regex(pattern, RegexOptions.CultureInvariant | RegexOptions.Singleline);
        }

        static bool TryMatch(string salt, out Match match, out LdapCrypterVariant variant)
        {
            match = _crypt.Match(salt);
            if (match.Success) { variant = LdapCrypterVariant.Crypt; return true; }
    
            match = _ssha.Match(salt);
            if (match.Success) { variant = LdapCrypterVariant.SSha; return true; }

            match = _smd5.Match(salt);
            if (match.Success) { variant = LdapCrypterVariant.SMD5; return true; }

            match = _sha.Match(salt);
            if (match.Success) { variant = LdapCrypterVariant.Sha; return true; }

            match = _md5.Match(salt);
            if (match.Success) { variant = LdapCrypterVariant.MD5; return true; }

            match = _cleartext.Match(salt);
            if (match.Success) { variant = LdapCrypterVariant.Cleartext; return true; }

            variant = 0; match = null; return false;
        }
    }
}

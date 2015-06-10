using CryptSharp;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encoder
{
    public partial class frmMain : Form
    {
        // holds the last text that was input
        private string strOldText;

        // default highlight colors
        private Color clrBackgroundHighlight = Color.FromArgb(255, 255, 160);
        private Color clrBackgroundNormal = Color.FromName("Menu");

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // load setting for ShowText and run EventHandler
            chkShow.Checked = Properties.Settings.Default.ShowText;
            chkShow_CheckedChanged(sender, e);

            // loop through TextBoxes and set EventHandlers
            foreach (Control tbox in this.Controls.OfType<TextBox>())
            {
                if (tbox.Name.ToString() != "txtPassword")
                {
                    tbox.MouseEnter += new EventHandler(Control_MouseEnter);
                    tbox.MouseLeave += new EventHandler(Control_MouseLeave);
                }
            }

            // loop through buttons and set EventHandlers
            foreach (Control btn in this.Controls.OfType<Button>())
            {
                btn.MouseEnter += new EventHandler(Control_MouseEnter);
                btn.MouseLeave += new EventHandler(Control_MouseLeave);
                btn.Click += new EventHandler(Button_Click);
            }
        }

        // handles MouseEnter for all controls
        void Control_MouseEnter(object sender, EventArgs e)
        {
            HighlightTextBox(sender, true);
        }

        // handles MouseLeave for all controls
        void Control_MouseLeave(object sender, EventArgs e)
        {
            HighlightTextBox(sender, false);
        }

        // set the background color for a textbox
        void HighlightTextBox(object sender, bool state)
        {
            if (txtPassword.Text != "")
            {
                TextBox tbox;
                Color bgcolor;

                // if mouse is over a button, grab the text of its Tag property which
                // will be the TextBox its associated with. otherwise just grab the actual
                // TextBox
                if (sender.GetType().Name.ToString() == "Button")
                {
                    tbox = (TextBox)this.Controls.Find(((Button)sender).Tag.ToString(), true)[0];
                }
                else
                {
                    tbox = (TextBox)sender;
                }

                // set background color
                bgcolor = clrBackgroundNormal;

                if (state == true) bgcolor = clrBackgroundHighlight;

                tbox.BackColor = bgcolor;
            }
        }

        // set clipboard text to the TextBox value for which the Button is
        // associated with. Buttons Tag property contains name of TextBox
        private void Button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((TextBox)this.Controls.Find(((Button)sender).Tag.ToString(), true)[0]).Text);
        }

        // reset timer every time a key is pressed, prevents input lag to wait 500ms
        // before encrypting the text and populating TextBoxes
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            tmrUpdate.Enabled = false;
            tmrUpdate.Enabled = true;
        }

        // Enable or Disable password character for input TextBox
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            bool state = true;

            if (chkShow.Checked == true) state = false;
            
            txtPassword.UseSystemPasswordChar = state;

            // save settings every time its clicked
            Properties.Settings.Default.ShowText = state;
            Properties.Settings.Default.Save();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            // quick check to see if input text has even changed since the last
            // round of typing
            if (txtPassword.Text != "")
            {
                if (strOldText != txtPassword.Text)
                {
                    // do the magic
                    txtUNIXCrypt.Text = Crypter.MD5.Crypt(txtPassword.Text);
                    txtBase64.Text = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(txtPassword.Text));
                    txtSHA256.Text = Crypter.Sha256.Crypt(txtPassword.Text);
                    txtSHA512.Text = Crypter.Sha512.Crypt(txtPassword.Text);
                    txtApache.Text = Crypter.MD5.Crypt(txtPassword.Text, new CrypterOptions() { { CrypterOption.Variant, MD5CrypterVariant.Apache } });
                    txtPHP.Text = Crypter.Phpass.Crypt(txtPassword.Text);
                    txtBCrypt.Text = Crypter.Blowfish.Crypt(txtPassword.Text);
                    txtLDAP.Text = Crypter.Ldap.Crypt(txtPassword.Text);
                    txtDES.Text = Crypter.TraditionalDes.Crypt(txtPassword.Text);
                    txtExtDES.Text = Crypter.ExtendedDes.Crypt(txtPassword.Text);

                    ControlsEnabled(true);
                }
            }
            else
            {
                // reset everything
                ControlsEnabled(false);
            }

            strOldText = txtPassword.Text;
            tmrUpdate.Enabled = false;
        }

        // if you cant figure this one out, you should probably stop reading
        // through the source
        private void ControlsEnabled(bool enabled)
        {
            // loop through buttons and set Enabled property
            foreach (Control btn in this.Controls.OfType<Button>())
            {
                btn.Enabled = enabled;
            }

            // loop through TextBoxes and set attributes
            foreach (Control tbox in this.Controls.OfType<TextBox>())
            {
                if (tbox.Name.ToString() != "txtPassword")
                {
                    tbox.BackColor = clrBackgroundNormal;
                    tbox.Enabled = enabled;

                    if (enabled == false) tbox.Text = "";
                }
            }
        }
    }
}

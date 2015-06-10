namespace Encoder
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUNIXCrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBase64 = new System.Windows.Forms.TextBox();
            this.btnMD5Copy = new System.Windows.Forms.Button();
            this.btnBase64Copy = new System.Windows.Forms.Button();
            this.btnSHA512Copy = new System.Windows.Forms.Button();
            this.btnSHA256Copy = new System.Windows.Forms.Button();
            this.txtSHA512 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPHPCopy = new System.Windows.Forms.Button();
            this.btnApacheCopy = new System.Windows.Forms.Button();
            this.txtPHP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApache = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBCryptCopy = new System.Windows.Forms.Button();
            this.txtBCrypt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLDAPCopy = new System.Windows.Forms.Button();
            this.txtLDAP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExtDESCopy = new System.Windows.Forms.Button();
            this.txtExtDES = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDESCopy = new System.Windows.Forms.Button();
            this.txtDES = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(68, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(342, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Checked = true;
            this.chkShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShow.Location = new System.Drawing.Point(416, 14);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(53, 17);
            this.chkShow.TabIndex = 2;
            this.chkShow.Text = "Show";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MD5:";
            // 
            // txtUNIXCrypt
            // 
            this.txtUNIXCrypt.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUNIXCrypt.Enabled = false;
            this.txtUNIXCrypt.Location = new System.Drawing.Point(68, 38);
            this.txtUNIXCrypt.Name = "txtUNIXCrypt";
            this.txtUNIXCrypt.ReadOnly = true;
            this.txtUNIXCrypt.Size = new System.Drawing.Size(342, 20);
            this.txtUNIXCrypt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base64:";
            // 
            // txtBase64
            // 
            this.txtBase64.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBase64.Enabled = false;
            this.txtBase64.Location = new System.Drawing.Point(68, 64);
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.ReadOnly = true;
            this.txtBase64.Size = new System.Drawing.Size(342, 20);
            this.txtBase64.TabIndex = 14;
            // 
            // btnMD5Copy
            // 
            this.btnMD5Copy.Enabled = false;
            this.btnMD5Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMD5Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMD5Copy.Location = new System.Drawing.Point(416, 38);
            this.btnMD5Copy.Name = "btnMD5Copy";
            this.btnMD5Copy.Size = new System.Drawing.Size(53, 20);
            this.btnMD5Copy.TabIndex = 3;
            this.btnMD5Copy.Tag = "txtUNIXCrypt";
            this.btnMD5Copy.Text = "Copy";
            this.btnMD5Copy.UseVisualStyleBackColor = true;
            // 
            // btnBase64Copy
            // 
            this.btnBase64Copy.Enabled = false;
            this.btnBase64Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBase64Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBase64Copy.Location = new System.Drawing.Point(416, 64);
            this.btnBase64Copy.Name = "btnBase64Copy";
            this.btnBase64Copy.Size = new System.Drawing.Size(53, 20);
            this.btnBase64Copy.TabIndex = 4;
            this.btnBase64Copy.Tag = "txtBase64";
            this.btnBase64Copy.Text = "Copy";
            this.btnBase64Copy.UseVisualStyleBackColor = true;
            // 
            // btnSHA512Copy
            // 
            this.btnSHA512Copy.Enabled = false;
            this.btnSHA512Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSHA512Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA512Copy.Location = new System.Drawing.Point(416, 116);
            this.btnSHA512Copy.Name = "btnSHA512Copy";
            this.btnSHA512Copy.Size = new System.Drawing.Size(53, 20);
            this.btnSHA512Copy.TabIndex = 6;
            this.btnSHA512Copy.Tag = "txtSHA512";
            this.btnSHA512Copy.Text = "Copy";
            this.btnSHA512Copy.UseVisualStyleBackColor = true;
            // 
            // btnSHA256Copy
            // 
            this.btnSHA256Copy.Enabled = false;
            this.btnSHA256Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSHA256Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA256Copy.Location = new System.Drawing.Point(416, 90);
            this.btnSHA256Copy.Name = "btnSHA256Copy";
            this.btnSHA256Copy.Size = new System.Drawing.Size(53, 20);
            this.btnSHA256Copy.TabIndex = 5;
            this.btnSHA256Copy.Tag = "txtSHA256";
            this.btnSHA256Copy.Text = "Copy";
            this.btnSHA256Copy.UseVisualStyleBackColor = true;
            // 
            // txtSHA512
            // 
            this.txtSHA512.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSHA512.Enabled = false;
            this.txtSHA512.Location = new System.Drawing.Point(68, 116);
            this.txtSHA512.Name = "txtSHA512";
            this.txtSHA512.ReadOnly = true;
            this.txtSHA512.Size = new System.Drawing.Size(342, 20);
            this.txtSHA512.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SHA512:";
            // 
            // txtSHA256
            // 
            this.txtSHA256.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSHA256.Enabled = false;
            this.txtSHA256.Location = new System.Drawing.Point(68, 90);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.ReadOnly = true;
            this.txtSHA256.Size = new System.Drawing.Size(342, 20);
            this.txtSHA256.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SHA256:";
            // 
            // btnPHPCopy
            // 
            this.btnPHPCopy.Enabled = false;
            this.btnPHPCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPHPCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPHPCopy.Location = new System.Drawing.Point(416, 168);
            this.btnPHPCopy.Name = "btnPHPCopy";
            this.btnPHPCopy.Size = new System.Drawing.Size(53, 20);
            this.btnPHPCopy.TabIndex = 8;
            this.btnPHPCopy.Tag = "txtPHP";
            this.btnPHPCopy.Text = "Copy";
            this.btnPHPCopy.UseVisualStyleBackColor = true;
            // 
            // btnApacheCopy
            // 
            this.btnApacheCopy.Enabled = false;
            this.btnApacheCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApacheCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApacheCopy.Location = new System.Drawing.Point(416, 142);
            this.btnApacheCopy.Name = "btnApacheCopy";
            this.btnApacheCopy.Size = new System.Drawing.Size(53, 20);
            this.btnApacheCopy.TabIndex = 7;
            this.btnApacheCopy.Tag = "txtApache";
            this.btnApacheCopy.Text = "Copy";
            this.btnApacheCopy.UseVisualStyleBackColor = true;
            // 
            // txtPHP
            // 
            this.txtPHP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPHP.Enabled = false;
            this.txtPHP.Location = new System.Drawing.Point(68, 168);
            this.txtPHP.Name = "txtPHP";
            this.txtPHP.ReadOnly = true;
            this.txtPHP.Size = new System.Drawing.Size(342, 20);
            this.txtPHP.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "PHP:";
            // 
            // txtApache
            // 
            this.txtApache.BackColor = System.Drawing.SystemColors.Menu;
            this.txtApache.Enabled = false;
            this.txtApache.Location = new System.Drawing.Point(68, 142);
            this.txtApache.Name = "txtApache";
            this.txtApache.ReadOnly = true;
            this.txtApache.Size = new System.Drawing.Size(342, 20);
            this.txtApache.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apache:";
            // 
            // btnBCryptCopy
            // 
            this.btnBCryptCopy.Enabled = false;
            this.btnBCryptCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBCryptCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCryptCopy.Location = new System.Drawing.Point(416, 194);
            this.btnBCryptCopy.Name = "btnBCryptCopy";
            this.btnBCryptCopy.Size = new System.Drawing.Size(53, 20);
            this.btnBCryptCopy.TabIndex = 9;
            this.btnBCryptCopy.Tag = "txtBCrypt";
            this.btnBCryptCopy.Text = "Copy";
            this.btnBCryptCopy.UseVisualStyleBackColor = true;
            // 
            // txtBCrypt
            // 
            this.txtBCrypt.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBCrypt.Enabled = false;
            this.txtBCrypt.Location = new System.Drawing.Point(68, 194);
            this.txtBCrypt.Name = "txtBCrypt";
            this.txtBCrypt.ReadOnly = true;
            this.txtBCrypt.Size = new System.Drawing.Size(342, 20);
            this.txtBCrypt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "BCrypt:";
            // 
            // btnLDAPCopy
            // 
            this.btnLDAPCopy.Enabled = false;
            this.btnLDAPCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLDAPCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLDAPCopy.Location = new System.Drawing.Point(416, 220);
            this.btnLDAPCopy.Name = "btnLDAPCopy";
            this.btnLDAPCopy.Size = new System.Drawing.Size(53, 20);
            this.btnLDAPCopy.TabIndex = 10;
            this.btnLDAPCopy.Tag = "txtLDAP";
            this.btnLDAPCopy.Text = "Copy";
            this.btnLDAPCopy.UseVisualStyleBackColor = true;
            // 
            // txtLDAP
            // 
            this.txtLDAP.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLDAP.Enabled = false;
            this.txtLDAP.Location = new System.Drawing.Point(68, 220);
            this.txtLDAP.Name = "txtLDAP";
            this.txtLDAP.ReadOnly = true;
            this.txtLDAP.Size = new System.Drawing.Size(342, 20);
            this.txtLDAP.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "LDAP:";
            // 
            // btnExtDESCopy
            // 
            this.btnExtDESCopy.Enabled = false;
            this.btnExtDESCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExtDESCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtDESCopy.Location = new System.Drawing.Point(416, 272);
            this.btnExtDESCopy.Name = "btnExtDESCopy";
            this.btnExtDESCopy.Size = new System.Drawing.Size(53, 20);
            this.btnExtDESCopy.TabIndex = 12;
            this.btnExtDESCopy.Tag = "txtExtDES";
            this.btnExtDESCopy.Text = "Copy";
            this.btnExtDESCopy.UseVisualStyleBackColor = true;
            // 
            // txtExtDES
            // 
            this.txtExtDES.BackColor = System.Drawing.SystemColors.Menu;
            this.txtExtDES.Enabled = false;
            this.txtExtDES.Location = new System.Drawing.Point(68, 272);
            this.txtExtDES.Name = "txtExtDES";
            this.txtExtDES.ReadOnly = true;
            this.txtExtDES.Size = new System.Drawing.Size(342, 20);
            this.txtExtDES.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Ext DES:";
            // 
            // btnDESCopy
            // 
            this.btnDESCopy.Enabled = false;
            this.btnDESCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDESCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDESCopy.Location = new System.Drawing.Point(416, 246);
            this.btnDESCopy.Name = "btnDESCopy";
            this.btnDESCopy.Size = new System.Drawing.Size(53, 20);
            this.btnDESCopy.TabIndex = 11;
            this.btnDESCopy.Tag = "txtDES";
            this.btnDESCopy.Text = "Copy";
            this.btnDESCopy.UseVisualStyleBackColor = true;
            // 
            // txtDES
            // 
            this.txtDES.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDES.Enabled = false;
            this.txtDES.Location = new System.Drawing.Point(68, 246);
            this.txtDES.Name = "txtDES";
            this.txtDES.ReadOnly = true;
            this.txtDES.Size = new System.Drawing.Size(342, 20);
            this.txtDES.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "DES:";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 500;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 304);
            this.Controls.Add(this.btnExtDESCopy);
            this.Controls.Add(this.txtExtDES);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDESCopy);
            this.Controls.Add(this.txtDES);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLDAPCopy);
            this.Controls.Add(this.txtLDAP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBCryptCopy);
            this.Controls.Add(this.txtBCrypt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPHPCopy);
            this.Controls.Add(this.btnApacheCopy);
            this.Controls.Add(this.txtPHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApache);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSHA512Copy);
            this.Controls.Add(this.btnSHA256Copy);
            this.Controls.Add(this.txtSHA512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSHA256);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBase64Copy);
            this.Controls.Add(this.btnMD5Copy);
            this.Controls.Add(this.txtBase64);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUNIXCrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Encoder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUNIXCrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBase64;
        private System.Windows.Forms.Button btnMD5Copy;
        private System.Windows.Forms.Button btnBase64Copy;
        private System.Windows.Forms.Button btnSHA512Copy;
        private System.Windows.Forms.Button btnSHA256Copy;
        private System.Windows.Forms.TextBox txtSHA512;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPHPCopy;
        private System.Windows.Forms.Button btnApacheCopy;
        private System.Windows.Forms.TextBox txtPHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApache;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBCryptCopy;
        private System.Windows.Forms.TextBox txtBCrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLDAPCopy;
        private System.Windows.Forms.TextBox txtLDAP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExtDESCopy;
        private System.Windows.Forms.TextBox txtExtDES;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDESCopy;
        private System.Windows.Forms.TextBox txtDES;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}


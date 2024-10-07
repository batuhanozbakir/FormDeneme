namespace KutuphaneUygulamasi
{
    partial class LoginPage
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
            gBoxLoginPage = new GroupBox();
            btnClose = new Button();
            btnSıgnUp = new Button();
            btnLogin = new Button();
            btnShowHidePassword = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            gBoxLoginPage.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxLoginPage
            // 
            gBoxLoginPage.Controls.Add(btnClose);
            gBoxLoginPage.Controls.Add(btnSıgnUp);
            gBoxLoginPage.Controls.Add(btnLogin);
            gBoxLoginPage.Controls.Add(btnShowHidePassword);
            gBoxLoginPage.Controls.Add(txtPassword);
            gBoxLoginPage.Controls.Add(txtUserName);
            gBoxLoginPage.Location = new Point(12, 12);
            gBoxLoginPage.Name = "gBoxLoginPage";
            gBoxLoginPage.Size = new Size(397, 127);
            gBoxLoginPage.TabIndex = 0;
            gBoxLoginPage.TabStop = false;
            gBoxLoginPage.Text = "Login Page";
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(365, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 24);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSıgnUp
            // 
            btnSıgnUp.BackColor = Color.Brown;
            btnSıgnUp.FlatStyle = FlatStyle.Flat;
            btnSıgnUp.Location = new Point(127, 91);
            btnSıgnUp.Name = "btnSıgnUp";
            btnSıgnUp.Size = new Size(103, 23);
            btnSıgnUp.TabIndex = 4;
            btnSıgnUp.Text = "SIGN UP";
            btnSıgnUp.UseVisualStyleBackColor = false;
            btnSıgnUp.Click += btnSıgnUp_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Brown;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(15, 91);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnShowHidePassword
            // 
            btnShowHidePassword.Image = Properties.Resources.show;
            btnShowHidePassword.Location = new Point(167, 55);
            btnShowHidePassword.Name = "btnShowHidePassword";
            btnShowHidePassword.Size = new Size(32, 23);
            btnShowHidePassword.TabIndex = 2;
            btnShowHidePassword.UseVisualStyleBackColor = true;
            btnShowHidePassword.Click += btnShowHidePassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(13, 57);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(148, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(13, 28);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(148, 23);
            txtUserName.TabIndex = 0;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 151);
            Controls.Add(gBoxLoginPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            gBoxLoginPage.ResumeLayout(false);
            gBoxLoginPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxLoginPage;
        private Button btnShowHidePassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnLogin;
        private Button btnSıgnUp;
        private Button btnClose;
    }
}
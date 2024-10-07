namespace KutuphaneUygulamasi
{
    partial class UserRegisterPage
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
            gBoxSıgnUp = new GroupBox();
            lblName = new Label();
            btnSave = new Button();
            txtPasswordAgain = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            gBoxSıgnUp.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxSıgnUp
            // 
            gBoxSıgnUp.Controls.Add(lblName);
            gBoxSıgnUp.Controls.Add(btnSave);
            gBoxSıgnUp.Controls.Add(txtPasswordAgain);
            gBoxSıgnUp.Controls.Add(txtPassword);
            gBoxSıgnUp.Controls.Add(txtEmail);
            gBoxSıgnUp.Controls.Add(txtSurname);
            gBoxSıgnUp.Controls.Add(txtName);
            gBoxSıgnUp.Location = new Point(-1, 12);
            gBoxSıgnUp.Name = "gBoxSıgnUp";
            gBoxSıgnUp.Size = new Size(303, 227);
            gBoxSıgnUp.TabIndex = 0;
            gBoxSıgnUp.TabStop = false;
            gBoxSıgnUp.Text = "Sign Up";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ActiveCaption;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Location = new Point(136, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(112, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Bu alan zorunludur*";
            lblName.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Tomato;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(0, 172);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(0, 143);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.PlaceholderText = "PasswordAgain";
            txtPasswordAgain.Size = new Size(100, 23);
            txtPasswordAgain.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(0, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(0, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(0, 56);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Surname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(0, 27);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            txtName.Enter += txtName_Enter;
            // 
            // UserRegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 251);
            Controls.Add(gBoxSıgnUp);
            Name = "UserRegisterPage";
            Text = "UserRegister";
            gBoxSıgnUp.ResumeLayout(false);
            gBoxSıgnUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxSıgnUp;
        private Label lblName;
        private Button btnSave;
        private TextBox txtPasswordAgain;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtName;
    }
}
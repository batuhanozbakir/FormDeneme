namespace FormDeneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gBoxKutuBir = new GroupBox();
            btnKutuBir = new Button();
            lblKutuİki = new Label();
            lblKutuBir = new Label();
            txtKutuİki = new TextBox();
            txtKutuBir = new TextBox();
            gBoxKutuIki = new GroupBox();
            btnKutu2 = new Button();
            lblKutu4 = new Label();
            lblKutu3 = new Label();
            txtKutuUc = new TextBox();
            txtKutuDört = new TextBox();
            gBoxKutu3 = new GroupBox();
            btnKutu3 = new Button();
            lblKutu6 = new Label();
            txtKutu5 = new TextBox();
            txtKutu6 = new TextBox();
            lblKutu5 = new Label();
            btnUserRegister = new Button();
            gBoxKutuBir.SuspendLayout();
            gBoxKutuIki.SuspendLayout();
            gBoxKutu3.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxKutuBir
            // 
            gBoxKutuBir.Controls.Add(btnKutuBir);
            gBoxKutuBir.Controls.Add(lblKutuİki);
            gBoxKutuBir.Controls.Add(lblKutuBir);
            gBoxKutuBir.Controls.Add(txtKutuİki);
            gBoxKutuBir.Controls.Add(txtKutuBir);
            gBoxKutuBir.Location = new Point(12, 12);
            gBoxKutuBir.Name = "gBoxKutuBir";
            gBoxKutuBir.Size = new Size(333, 169);
            gBoxKutuBir.TabIndex = 0;
            gBoxKutuBir.TabStop = false;
            gBoxKutuBir.Text = "Kutu 1";
            // 
            // btnKutuBir
            // 
            btnKutuBir.BackColor = SystemColors.Info;
            btnKutuBir.FlatStyle = FlatStyle.Flat;
            btnKutuBir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKutuBir.ForeColor = SystemColors.MenuHighlight;
            btnKutuBir.Location = new Point(6, 116);
            btnKutuBir.Name = "btnKutuBir";
            btnKutuBir.Size = new Size(138, 34);
            btnKutuBir.TabIndex = 4;
            btnKutuBir.Text = "Gönder Kutu 2";
            btnKutuBir.UseVisualStyleBackColor = false;
            btnKutuBir.Click += btnKutuBir_Click;
            // 
            // lblKutuİki
            // 
            lblKutuİki.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKutuİki.ForeColor = Color.IndianRed;
            lblKutuİki.Location = new Point(189, 75);
            lblKutuİki.Name = "lblKutuİki";
            lblKutuİki.Size = new Size(123, 23);
            lblKutuİki.TabIndex = 3;
            lblKutuİki.Text = "label2";
            lblKutuİki.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKutuBir
            // 
            lblKutuBir.BackColor = SystemColors.ActiveCaption;
            lblKutuBir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKutuBir.ForeColor = Color.IndianRed;
            lblKutuBir.Location = new Point(189, 30);
            lblKutuBir.Name = "lblKutuBir";
            lblKutuBir.Size = new Size(123, 23);
            lblKutuBir.TabIndex = 2;
            lblKutuBir.Text = "label1";
            lblKutuBir.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtKutuİki
            // 
            txtKutuİki.Location = new Point(14, 75);
            txtKutuİki.Name = "txtKutuİki";
            txtKutuİki.PlaceholderText = "Text Kutu 2";
            txtKutuİki.Size = new Size(130, 23);
            txtKutuİki.TabIndex = 1;
            // 
            // txtKutuBir
            // 
            txtKutuBir.Location = new Point(14, 30);
            txtKutuBir.Name = "txtKutuBir";
            txtKutuBir.PlaceholderText = "Text Kutu 1";
            txtKutuBir.Size = new Size(130, 23);
            txtKutuBir.TabIndex = 0;
            // 
            // gBoxKutuIki
            // 
            gBoxKutuIki.Controls.Add(btnKutu2);
            gBoxKutuIki.Controls.Add(lblKutu4);
            gBoxKutuIki.Controls.Add(lblKutu3);
            gBoxKutuIki.Controls.Add(txtKutuUc);
            gBoxKutuIki.Controls.Add(txtKutuDört);
            gBoxKutuIki.Location = new Point(12, 187);
            gBoxKutuIki.Name = "gBoxKutuIki";
            gBoxKutuIki.Size = new Size(333, 169);
            gBoxKutuIki.TabIndex = 1;
            gBoxKutuIki.TabStop = false;
            gBoxKutuIki.Text = "Kutu 2";
            gBoxKutuIki.Visible = false;
            // 
            // btnKutu2
            // 
            btnKutu2.BackColor = SystemColors.Info;
            btnKutu2.FlatStyle = FlatStyle.Flat;
            btnKutu2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKutu2.ForeColor = SystemColors.MenuHighlight;
            btnKutu2.Location = new Point(174, 117);
            btnKutu2.Name = "btnKutu2";
            btnKutu2.Size = new Size(138, 34);
            btnKutu2.TabIndex = 4;
            btnKutu2.Text = "Gönder Kutu 3";
            btnKutu2.UseVisualStyleBackColor = false;
            btnKutu2.Click += btnKutu2_Click;
            // 
            // lblKutu4
            // 
            lblKutu4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKutu4.ForeColor = Color.IndianRed;
            lblKutu4.Location = new Point(6, 75);
            lblKutu4.Name = "lblKutu4";
            lblKutu4.Size = new Size(123, 23);
            lblKutu4.TabIndex = 3;
            lblKutu4.Text = "label4";
            lblKutu4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKutu3
            // 
            lblKutu3.BackColor = SystemColors.ActiveCaption;
            lblKutu3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKutu3.ForeColor = Color.IndianRed;
            lblKutu3.Location = new Point(6, 30);
            lblKutu3.Name = "lblKutu3";
            lblKutu3.Size = new Size(123, 23);
            lblKutu3.TabIndex = 2;
            lblKutu3.Text = "label3";
            lblKutu3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtKutuUc
            // 
            txtKutuUc.Location = new Point(174, 31);
            txtKutuUc.Name = "txtKutuUc";
            txtKutuUc.PlaceholderText = "Text Kutu 3";
            txtKutuUc.Size = new Size(138, 23);
            txtKutuUc.TabIndex = 0;
            // 
            // txtKutuDört
            // 
            txtKutuDört.Location = new Point(174, 76);
            txtKutuDört.Name = "txtKutuDört";
            txtKutuDört.PlaceholderText = "Text Kutu 4";
            txtKutuDört.Size = new Size(138, 23);
            txtKutuDört.TabIndex = 1;
            // 
            // gBoxKutu3
            // 
            gBoxKutu3.Controls.Add(btnKutu3);
            gBoxKutu3.Controls.Add(lblKutu6);
            gBoxKutu3.Controls.Add(txtKutu5);
            gBoxKutu3.Controls.Add(txtKutu6);
            gBoxKutu3.Controls.Add(lblKutu5);
            gBoxKutu3.Location = new Point(12, 362);
            gBoxKutu3.Name = "gBoxKutu3";
            gBoxKutu3.Size = new Size(333, 169);
            gBoxKutu3.TabIndex = 2;
            gBoxKutu3.TabStop = false;
            gBoxKutu3.Text = "Kutu 3";
            gBoxKutu3.Visible = false;
            // 
            // btnKutu3
            // 
            btnKutu3.BackColor = SystemColors.Info;
            btnKutu3.FlatStyle = FlatStyle.Flat;
            btnKutu3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKutu3.ForeColor = SystemColors.MenuHighlight;
            btnKutu3.Location = new Point(6, 108);
            btnKutu3.Name = "btnKutu3";
            btnKutu3.Size = new Size(321, 34);
            btnKutu3.TabIndex = 4;
            btnKutu3.Text = "Gönder Kutu 1";
            btnKutu3.UseVisualStyleBackColor = false;
            btnKutu3.Click += btnKutu3_Click;
            // 
            // lblKutu6
            // 
            lblKutu6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKutu6.ForeColor = Color.IndianRed;
            lblKutu6.Location = new Point(168, 59);
            lblKutu6.Name = "lblKutu6";
            lblKutu6.Size = new Size(123, 23);
            lblKutu6.TabIndex = 3;
            lblKutu6.Text = "label6";
            lblKutu6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtKutu5
            // 
            txtKutu5.Location = new Point(6, 24);
            txtKutu5.Name = "txtKutu5";
            txtKutu5.PlaceholderText = "Text Kutu 5";
            txtKutu5.Size = new Size(138, 23);
            txtKutu5.TabIndex = 0;
            // 
            // txtKutu6
            // 
            txtKutu6.Location = new Point(168, 24);
            txtKutu6.Name = "txtKutu6";
            txtKutu6.PlaceholderText = "Text Kutu 6";
            txtKutu6.Size = new Size(138, 23);
            txtKutu6.TabIndex = 1;
            // 
            // lblKutu5
            // 
            lblKutu5.BackColor = SystemColors.ActiveCaption;
            lblKutu5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKutu5.ForeColor = Color.IndianRed;
            lblKutu5.Location = new Point(6, 59);
            lblKutu5.Name = "lblKutu5";
            lblKutu5.Size = new Size(123, 23);
            lblKutu5.TabIndex = 2;
            lblKutu5.Text = "label5";
            lblKutu5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnUserRegister
            // 
            btnUserRegister.Location = new Point(62, 552);
            btnUserRegister.Name = "btnUserRegister";
            btnUserRegister.Size = new Size(193, 23);
            btnUserRegister.TabIndex = 3;
            btnUserRegister.Text = "Kullanıcı Kayıt";
            btnUserRegister.UseVisualStyleBackColor = true;
            btnUserRegister.Click += btnUserRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 648);
            Controls.Add(btnUserRegister);
            Controls.Add(gBoxKutu3);
            Controls.Add(gBoxKutuIki);
            Controls.Add(gBoxKutuBir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kutu Çalışması Versiyon 1.0";
            gBoxKutuBir.ResumeLayout(false);
            gBoxKutuBir.PerformLayout();
            gBoxKutuIki.ResumeLayout(false);
            gBoxKutuIki.PerformLayout();
            gBoxKutu3.ResumeLayout(false);
            gBoxKutu3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxKutuBir;
        private Label lblKutuİki;
        private Label lblKutuBir;
        private TextBox txtKutuİki;
        private TextBox txtKutuBir;
        private Button btnKutuBir;
        private GroupBox gBoxKutuIki;
        private Button btnKutu2;
        private Label lblKutu4;
        private Label lblKutu3;
        private TextBox txtKutuUc;
        private TextBox txtKutuDört;
        private GroupBox gBoxKutu3;
        private Button btnKutu3;
        private Label lblKutu6;
        private Label lblKutu5;
        private TextBox txtKutu5;
        private TextBox txtKutu6;
        private Button btnUserRegister;
    }
}

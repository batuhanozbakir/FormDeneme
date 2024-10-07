using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi
{
    public partial class UserRegisterPage : Form
    {
        public UserRegisterPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string Email = txtEmail.Text;

            string username = Email.Split('@')[0];

            string password = txtPassword.Text;
            string passwordAgain = txtPasswordAgain.Text;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Lütfen zorunlu alanı giriniz!");
                lblName.Visible = true;
                isValid = false;
            }

            if (password != passwordAgain)
            {
                MessageBox.Show("Şifreler farklıdır. Lütfen kontrol ediniz.");
                isValid = false;
            }

            if (isValid)
            {

                User user = new User();
                user.Id = Guid.NewGuid();
                user.Name = name;
                user.Surname = surname;
                user.Email = Email;
                user.Password = password;

                Program.AddUser(username, user);

                MessageBox.Show("Kayıt Yapılmıştır");
                this.Close();

            }
            else
            {
                MessageBox.Show("Hatalar var");
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            lblName.Visible = false;

        }
    }
}

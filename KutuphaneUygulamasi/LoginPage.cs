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
    public partial class LoginPage : Form
    {

        private bool isVisablePassword = false;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (isVisablePassword)
            {
                txtPassword.PasswordChar = '\0';
                isVisablePassword = false;
                btnShowHidePassword.Image = KutuphaneUygulamasi.Properties.Resources.show;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                isVisablePassword = true;
                btnShowHidePassword.Image = KutuphaneUygulamasi.Properties.Resources.hidden;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

           if( Program.userList[userName].Password == password)
            {
                Program.activeUser = Program.userList[userName];

                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlıştır!");
            }


        }

        private void btnSıgnUp_Click(object sender, EventArgs e)
        {
            UserRegisterPage userRegisterPage = new UserRegisterPage();
            userRegisterPage.ShowDialog();
            userRegisterPage.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}

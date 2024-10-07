namespace FormDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKutuBir_Click(object sender, EventArgs e)
        {
            string textKutuBirStr = txtKutuBir.Text;
            string textKutuIkiStr = txtKutuÝki.Text;

            lblKutu3.Text = textKutuBirStr;
            lblKutu4.Text = textKutuIkiStr;

            gBoxKutuBir.Visible = false;
            gBoxKutuIki.Visible = true;
            gBoxKutuIki.Location = gBoxKutuBir.Location;
            // gBoxKutuIki.Location = new Point(gBoxKutuBir.Location.X,gBoxKutuBir.Location.Y);
        }

        private void btnKutu2_Click(object sender, EventArgs e)
        {
            string textKutuUcStr = txtKutuUc.Text;
            string textKutuDörtStr = txtKutuDört.Text;

            lblKutu5.Text = textKutuUcStr;
            lblKutu6.Text = textKutuDörtStr;

            gBoxKutuIki.Visible = false;
            gBoxKutu3.Visible = true;

            gBoxKutu3.Location = gBoxKutuIki.Location;
        }

        private void btnKutu3_Click(object sender, EventArgs e)
        {
            string textKutuBesStr = txtKutu5.Text;
            string textKutuAltiStr = txtKutu6.Text;

            lblKutuBir.Text = textKutuBesStr;
            lblKutuÝki.Text = textKutuAltiStr;

            gBoxKutu3.Visible = false;
            gBoxKutuBir.Visible = true;

            gBoxKutuBir.Location = gBoxKutu3.Location;
        }

        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();

            userRegister.ShowDialog();

        }
    }
}

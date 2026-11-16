namespace WinComunity
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Go to register");
            RegisterForm myForm = new RegisterForm();
            myForm.ShowDialog();
        }
    }
}

namespace MyOpenWin
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            //Спеціальне вікно - де можна обрати файл
            OpenFileDialog myDialog = new OpenFileDialog();
            //Для відображення вікна використовується метод
            //ShowDialog() і умовний оператор if
            //DialogResult.OK - Це якщо користувач обрав файл на ПК
            if(myDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = myDialog.FileName;
                //Шлях до файлу вписуємо у тестове поле
                txtFilePath.Text = filePath;
                //MessageBox.Show("Ви обрали файл: " + filePath);
            }
        }
    }
}

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string filePath = txtMyInput.Text;

            //Читаємо вміст файлу
            string fileContent = File.ReadAllText(filePath);

            txtFileContent.Text = fileContent;
            //MessageBox.Show(filePath, "Повідомлення!");
        }
    }
}

namespace Hafta05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 customDialog = new Form2();
            DialogResult sonuc = customDialog.ShowDialog();
            richTextBox1.Text = sonuc.ToString();
        }
    }
}
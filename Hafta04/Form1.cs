namespace Hafta04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void basitDialogOlay(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj buraya gelecek", "Baþlýk Buraya Yazýlacak");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Mesajýmýzzzzz!", "Baþlýk!", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
                textBox1.Text = "Evet/Hayýr Dialogda Evet'e týklandý";
            else
                textBox1.Text = "Evet/Hayýr Dialogda Hayýr'a týklandý";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesajjjjj...", "Baþlýk...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Bir dosya seçiniz";
            dialog.Filter = "Tüm Dosyalar|*.*|Pdf Dosyalarý|*.pdf";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Dosyanýz kaydediliyor.";
            dialog.Filter = "Metin dosyasý|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.Color.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.Font.ToString();
            }
        }
    }
}
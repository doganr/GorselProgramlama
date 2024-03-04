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
            MessageBox.Show("Merhaba D�nya!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj buraya gelecek", "Ba�l�k Buraya Yaz�lacak");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Mesaj�m�zzzzz!", "Ba�l�k!", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
                textBox1.Text = "Evet/Hay�r Dialogda Evet'e t�kland�";
            else
                textBox1.Text = "Evet/Hay�r Dialogda Hay�r'a t�kland�";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesajjjjj...", "Ba�l�k...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Bir dosya se�iniz";
            dialog.Filter = "T�m Dosyalar|*.*|Pdf Dosyalar�|*.pdf";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Dosyan�z kaydediliyor.";
            dialog.Filter = "Metin dosyas�|*.txt";
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
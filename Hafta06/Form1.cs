using System.Data;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hafta06
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        private List<Ogrenci> ogrenciler;

        public Form1()
        {
            InitializeComponent();
            ogrenciler = new List<Ogrenci>();
            dt = new DataTable();
            dt.Columns.Add("Öðrenci No:");
            dt.Columns.Add("Öðrenci Adý:");
            dt.Columns.Add("Öðrenci Soyadý:");
            dt.Columns.Add("Vize Notu:");
            dt.Columns.Add("Final Notu:");
            dt.Columns.Add("Geçme Notu:");

            ogrencilerDgv.DataSource = dt;
        }

        private void ogrenciEkleBtn_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciNo = ogrenciNoTxt.Text;
            ogrenci.OgrenciAdi = ogrenciAdiTxt.Text;
            ogrenci.OgrenciSoyadi = ogrenciSoyadiTxt.Text;
            ogrenci.OgrenciVize = Convert.ToDouble(ogrenciVizeNud.Value);
            ogrenci.OgrenciFinal = Convert.ToDouble(ogrenciFinalNud.Value);
            ogrenci.TabloyaEkle(dt);
            ogrenciler.Add(ogrenci);

            ogrenciNoTxt.Text = "";
            ogrenciAdiTxt.Text = "";
            ogrenciSoyadiTxt.Text = "";
            ogrenciVizeNud.Value = 0;
            ogrenciFinalNud.Value = 0;
        }

        private void kaydetTsmi_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Ogrenci>>(ogrenciler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dialog.FileName;
                File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
            }
        }

        private void yukleTsmi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                ogrenciler = JsonSerializer.Deserialize<List<Ogrenci>>(data);

                foreach (Ogrenci ogr in ogrenciler)
                {
                    ogr.TabloyaEkle(dt);
                }
            }
        }
    }
}
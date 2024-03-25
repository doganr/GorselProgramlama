using System.Data;
using System.Data.SQLite;

namespace Hafta07
{
    public partial class Form1 : Form
    {
        SQLiteConnection baglanti;

        public Form1()
        {
            InitializeComponent();

            string baglanti_metni = "Data Source=okul.db;Version=3;";

            try
            {
                baglanti = new SQLiteConnection(baglanti_metni);
                baglanti.Open();
                TabloGuncelle();

                //MessageBox.Show("SQLite Baðlantýsý kuruldu",
                //               "Baðlantý saðlandý",
                //               MessageBoxButtons.OK,
                //               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite Baðlantýsý kurulamadý",
                                "Baðlantý hatasý",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (baglanti != null && baglanti.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    baglanti.Close();

                    //MessageBox.Show("SQLite Baðlantýsý baþarýyla kapatýldý.",
                    //               "Baðlantý sonlandýrýldý",
                    //               MessageBoxButtons.OK,
                    //               MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQLite Baðlantýsý sonlandýrýlýrken hata ile karþýlaþýldý",
                                    "Baðlantý sonlandýrma hatasý",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        public void TabloGuncelle()
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM ogrenci";



            DataTable ogrenciler = new DataTable();
            ogrenciler.Columns.Add("ID");
            ogrenciler.Columns.Add("Numara");
            ogrenciler.Columns.Add("Ýsim");
            ogrenciler.Columns.Add("Soyisim");
            ogrenciler.Columns.Add("EMail");

            SQLiteDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                ogrenciler.Rows.Add(new object[] { okuyucu.GetInt32(0),
                                                   okuyucu.GetString(1),
                                                   okuyucu.GetString(2),
                                                   okuyucu.GetString(3),
                                                   okuyucu.IsDBNull(4) ? "" : okuyucu.GetString(4)});
            }

            ogrencilerDgv.DataSource = ogrenciler;
        }

        private void ogrenciEkleBtn_Click(object sender, EventArgs e)
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"INSERT INTO ogrenci (numara,isim,soyisim,email) VALUES(\"{numaraTxt.Text}\", \"{isimTxt.Text}\", \"{soyisimTxt.Text}\", \"{emailTxt.Text}\")";


            int eklenen_sayisi = komut.ExecuteNonQuery();
            if (eklenen_sayisi > 0)
                TabloGuncelle();

            numaraTxt.Text = "";
            isimTxt.Text = "";
            soyisimTxt.Text = "";
            emailTxt.Text = "";
        }

        private void ogrencSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ogrencilerDgv.SelectedRows[0].Cells[0].Value);

                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = $"DELETE FROM ogrenci WHERE ID = {id}";

                int eklenen_sayisi = komut.ExecuteNonQuery();
                if (eklenen_sayisi > 0)
                    TabloGuncelle();
            }
            catch (Exception ex) { }

            numaraTxt.Text = "";
            isimTxt.Text = "";
            soyisimTxt.Text = "";
            emailTxt.Text = "";
        }

        private void ogrencilerDgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                numaraTxt.Text = ogrencilerDgv.SelectedRows[0].Cells[1].Value.ToString();
                isimTxt.Text = ogrencilerDgv.SelectedRows[0].Cells[2].Value.ToString();
                soyisimTxt.Text = ogrencilerDgv.SelectedRows[0].Cells[3].Value.ToString();
                emailTxt.Text = ogrencilerDgv.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void ogrenciGüncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(ogrencilerDgv.SelectedRows[0].Cells[0].Value);

                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = $"UPDATE ogrenci SET numara=\"{numaraTxt.Text}\",isim=\"{isimTxt.Text}\",soyisim=\"{soyisimTxt.Text}\",email=\"{emailTxt.Text}\" WHERE ID={id}";

                int eklenen_sayisi = komut.ExecuteNonQuery();
                if (eklenen_sayisi > 0)
                    TabloGuncelle();
            }
            catch (Exception ex) { }
        }
    }
}
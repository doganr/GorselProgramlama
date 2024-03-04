using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void klasorSecBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                seciliKlasorTxt.Text = dialog.SelectedPath;

                DirectoryInfo klasor = new DirectoryInfo(seciliKlasorTxt.Text);
                FileInfo[] resimler = klasor.GetFiles("*.jpg");

                resimlerLbox.Items.Clear();
                for (int i = 0; i < resimler.Length; i++)
                {
                    resimlerLbox.Items.Add(resimler[i].Name);
                }
            }
        }

        private void resimlerLbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resimlerLbox.Items.Count > 0)
            {
                resimalaniPbox.Image = Image.FromFile(seciliKlasorTxt.Text + "\\" + resimlerLbox.SelectedItem.ToString());
            }
        }
    }
}

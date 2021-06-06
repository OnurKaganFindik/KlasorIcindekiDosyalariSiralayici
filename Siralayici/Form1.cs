using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siralayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            DialogResult dr = fbdDizin.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtDizin.Text = fbdDizin.SelectedPath;
                DosyalarinAdlariniListele();
            }
        }

        private void DosyalarinAdlariniListele()
        {
            DirectoryInfo di = new DirectoryInfo(txtDizin.Text);//Klasör bilgisi
            FileInfo[] files = di.GetFiles(); //Dosya Bilgileri

            lstDosyaAdlari.Items.Clear();
            foreach (FileInfo file in files)
            {
                lstDosyaAdlari.Items.Add(file.Name);
            }
        }

        private void btnDosyaAdlariniSayilastir_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(txtDizin.Text);//Klasör bilgisi
            FileInfo[] files = di.GetFiles(); //Dosya Bilgileri

            lstDosyaAdlari.Items.Clear();
            int i = 1;

            foreach (FileInfo file in files)
            {
                string yeniDosyaAd = i + file.Extension;
                try
                {
                    File.Move(file.FullName, file.Directory.FullName + "\\" + yeniDosyaAd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                lstDosyaAdlari.Items.Add(yeniDosyaAd);
                i++;
            }
        }
    }
}

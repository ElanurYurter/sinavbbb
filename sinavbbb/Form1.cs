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

namespace sinavbbb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Getir()
        {
            string dosyayol = "C://Resimler/";
            DirectoryInfo di = new DirectoryInfo(dosyayol);
            List<FileInfo> klasorler = di.GetFiles().ToList();
            foreach (FileInfo item in klasorler)
            {
                string uzanti = item.Extension;
                if (uzanti == ".jpeg" || uzanti == ".png")
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }
        public void TureGoreGetir(string tur)
        {
            listBox1.Items.Clear();
            string dosyayol = "C://Resimler/";
            DirectoryInfo di = new DirectoryInfo(dosyayol);
            List<FileInfo> klasorler = di.GetFiles().ToList();
            foreach (FileInfo item in klasorler)
            {
                string uzanti = item.Extension;
                if (uzanti == tur)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = comboBox1.SelectedItem.ToString();
            if (secilen == "jpeg")
            {
                TureGoreGetir(".jpeg");
            }
            else if (secilen == "png")
            {
                TureGoreGetir(".png");
            }
            else
            {
                Getir();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string resimyol = "C://Resimler/" + listBox1.SelectedItem.ToString();
                pictureBox1.ImageLocation = resimyol;
            }
            else
            {
                MessageBox.Show("Hata", "hata");
            }
        }
    }
}

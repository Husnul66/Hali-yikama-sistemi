using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hali_yikama_fabrikasi
{
    public partial class Form1 : Form
    {
        private List<Musteri> musteriler = new List<Musteri>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            var musteri = new Musteri
            {
       Ad = textBox1.Text,Soyad=textBox2.Text,Telefon=textBox3.Text,Adres=textBox6.Text

            };
            musteriler.Add(musteri);
   comboBox1.Items.Add(musteri.Ad + " " + musteri.Soyad+" "+musteri.Telefon+" "+musteri.Adres);
            MessageBox.Show("Musteri eklendi !");


    }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("lutfen musteri seciniz !");
                return;

            }
            var hali = new Hali
            {
                Metrekare = double.Parse(textBox4.Text),
                AlimTarihi= dateTimePicker1.Value,TahminiTeslimTarihi= dateTimePicker2.Value

            };
            musteriler[comboBox1.SelectedIndex].Halilar.Add(hali);
            MessageBox.Show("Hali eklendi !");
}

        private void button4_Click(object sender, EventArgs e)
        {
       
            listBox1.Items.Clear();
            foreach (var m in musteriler)
            {
                foreach (var h in m.Halilar.Where(h => h.Durum.Equals("Yıkamada", StringComparison.OrdinalIgnoreCase)))
                {
                    listBox1.Items.Add($"{m.Ad} {m.Soyad} - {h.Metrekare}m² - {h.Ucret}₺ - {h.Durum}");
                }
            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var m in musteriler)
            {
                foreach (var h in m.Halilar.Where(h => h.Durum.Equals("Teslim Edildi", StringComparison.OrdinalIgnoreCase)))
                {
                    listBox2.Items.Add($"{m.Ad} {m.Soyad} - {h.Metrekare}m² - {h.Ucret}₺ - {h.Durum}");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var m in musteriler)
            {
                var hali = m.Halilar.FirstOrDefault(h => h.Durum == "Yıkamada");
                if (hali != null)
                {
                    hali.Durum = "Teslim Edildi";
                    MessageBox.Show("Halı teslim edildi!");
                    return;
                }
            }
            MessageBox.Show("Yıkamada halı bulunamadı.");
        }
    }
}
    


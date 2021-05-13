using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MinikBorsaBilgileriEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_hesapla_Click(object sender, EventArgs e)
        { 

            float toplamAlinacakKomisyon = ((float.Parse(text_yatirilacakpara.Text) * float.Parse(text_aliskomisyonu.Text)) / 100) + (float.Parse(text_yatirilacakpara.Text) * float.Parse(text_satiskomisyonu.Text)) / 100;
            text_kesilecekkomisyon.Text = toplamAlinacakKomisyon.ToString();


            float alinacakKriptoParaMiktari = (float.Parse(text_yatirilacakpara.Text) - toplamAlinacakKomisyon) / float.Parse(text_alimfiyati.Text);
            text_alinankriptomiktari.Text = alinacakKriptoParaMiktari.ToString();

            float karliSatisFiyati = ((((float.Parse(text_yatirilacakpara.Text) * float.Parse(text_karyuzdesi.Text)) / 100) )/ alinacakKriptoParaMiktari) + float.Parse(text_alimfiyati.Text);
            text_karicinsatisfiyati.Text = karliSatisFiyati.ToString();

            float zararliSatisFiyati = +float.Parse(text_alimfiyati.Text) - ((((float.Parse(text_yatirilacakpara.Text) * float.Parse(text_zararyuzdesi.Text)) / 100)) / alinacakKriptoParaMiktari);
            text_zararicinsatisfiyati.Text = zararliSatisFiyati.ToString();

            float netKar =  (alinacakKriptoParaMiktari * karliSatisFiyati) - float.Parse(text_yatirilacakpara.Text);
            text_karfiyati.Text = netKar.ToString();



        }

        private void text_alimfiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
    


            text_alimfiyati.Text = "2,12";
            text_aliskomisyonu.Text = "0,1";
            text_satiskomisyonu.Text = "0,1";
            text_karyuzdesi.Text = "2,5";
            text_kesilecekkomisyon.Text = "0,0";
            text_zararyuzdesi.Text = "1,0";
            text_karfiyati.Text = "0,0";
            text_karicinsatisfiyati.Text = "0,0";
            text_zararicinsatisfiyati.Text = "0,0";
            text_yatirilacakpara.Text = "2000,0";
            text_alinankriptomiktari.Text = "0,0";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

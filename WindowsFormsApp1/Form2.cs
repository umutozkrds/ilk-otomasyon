using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti= new SqlConnection("Data Source=UMUT\\UMUTMSSQL;Initial Catalog=Musteriler;Integrated Security=True");

        int ekmek = 0;
        int su = 0;
        int yumurta = 0;
        int nut = 0;
        int dondurma = 0;
        int çay = 0;

        int ekmekstok;
        int sustok ;
        int yumurstok;
        int nutstok ;
        int donstok ;
        int çaystok;

        int ekmeksatış;
        int susatış ;
        int yumursatış ;
        int nutsatış ;
        int donsatış ;
        int çaysatış ;

        int ekmekgeliş  ;
        int sugeliş ;
        int yumurgeliş ;
        int nutgeliş ;
        int dongeliş ;
        int çaygeliş;

        int hesap = 0;
        int hasılat = 0;
        int kar = 0;

        void temizle()
        {
            hesap = 0;
            ekmek = 0;
            su = 0;
            nut = 0;
            yumurta = 0;
            dondurma = 0;
            çay= 0;
            label1.Text = hesap.ToString();
            listBox1.Items.Clear();
        }
        
        void liste()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(ekmek + " " + "ekmek");
            listBox1.Items.Add(su + " " + "su");
            listBox1.Items.Add(yumurta + " " + "yumurta");
            listBox1.Items.Add(nut + " " + "nutella");
            listBox1.Items.Add(dondurma + " " + "dondurma");
            listBox1.Items.Add(çay + " " + "çay");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ekmek++;
            liste();
            hesap = hesap + ekmeksatış;
            label1.Text = hesap.ToString() + " " + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            su++;
            liste();
            hesap = hesap + susatış;
            label1.Text = hesap.ToString() + " " + "TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yumurta++;
            liste();
            hesap = hesap + yumursatış;
            label1.Text = hesap.ToString() + " " + "TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nut++;
            liste();
            hesap = hesap + nutsatış;
            label1.Text = hesap.ToString() + " " + "TL";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dondurma++;
            liste();
            hesap = hesap + donsatış;
            label1.Text = hesap.ToString() + " " + "TL";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            çay++;
            liste();
            hesap = hesap + çaysatış;
            label1.Text = hesap.ToString() + " " + "TL";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            ekmekstok = 50;
             sustok = 100;
             yumurstok = 200;
             nutstok = 25;
             donstok = 30;
             çaystok = 50;

             ekmeksatış = 5;
             susatış = 3;
             yumursatış = 2;
             nutsatış = 20;
             donsatış = 10;
             çaysatış = 50;

             ekmekgeliş = 3;
            sugeliş = 2;
           yumurgeliş = 1;
            nutgeliş = 10;
             dongeliş = 5;
             çaygeliş = 30;
            liste();

            label3.Text = ekmekstok.ToString();
            label5.Text = sustok.ToString();
            label10.Text = yumurstok.ToString();
            label16.Text = nutstok.ToString();
            label18.Text = donstok.ToString();
            label20.Text = çaystok.ToString();

        }

        int toplamhasılat;
        int toplamkar;

        private void button7_Click(object sender, EventArgs e)
        {
            int ekmekkar = ekmeksatış - ekmekgeliş;
            int sukar = susatış - sugeliş;
            int yumurkar = yumursatış - yumurgeliş;
            int nutkar = nutsatış - nutgeliş;
            int donkar = donsatış - dongeliş;
            int çaykar = çaysatış - çaygeliş;
            hasılat = hasılat + hesap;
            ekmekstok = ekmekstok - ekmek;
            label3.Text = ekmekstok.ToString();
            sustok = sustok - su;
            label5.Text = sustok.ToString();
            yumurstok = yumurstok - yumurta;
            label10.Text = yumurstok.ToString();
            nutstok = nutstok - nut;
            label16.Text = nutstok.ToString();
            donstok= donstok - dondurma;
            label18.Text = donstok.ToString();
            çaystok = çaystok - çay;
            label20.Text = çaystok.ToString();

            kar = kar + (ekmekkar * ekmek) + (sukar * su) + (yumurkar * yumurta)+(nutkar*nut)+(donkar*dondurma)+(çaykar*çay);
            label8.Text = kar.ToString();
            
            temizle();
            label7.Text = hasılat.ToString();
            liste();

            toplamhasılat = toplamhasılat + hasılat;
            toplamkar = toplamkar + kar;
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            temizle();

        }

   

        private void button9_Click_1(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'musterilerDataSet1.Tbl_musteri' table. You can move, or remove it, as needed.
            this.tbl_musteriTableAdapter.Fill(this.musterilerDataSet1.Tbl_musteri);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_musteri(MusNo,MusAd,MusSoyad,MusBakiye) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt işlemi tamamlanmıştır.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from Tbl_musteri where MusNo=@s1", baglanti);
            komutsil.Parameters.AddWithValue("@s1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi tamamlanmıştır.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_musteri set MusAd=@k2,MusSoyad=@k3,MusBakiye=@k4 where MusNo=@k1", baglanti);
            komutgüncelle.Parameters.AddWithValue("@k1", textBox1.Text);
            komutgüncelle.Parameters.AddWithValue("@k2", textBox2.Text);
            komutgüncelle.Parameters.AddWithValue("@k3", textBox3.Text);
            komutgüncelle.Parameters.AddWithValue("@k4", textBox4.Text);
            komutgüncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi tamamlanmıştır.");

        }
        int deger;
        private void button14_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komuturun = new SqlCommand("update Tbl_urun set UrunStok=@x2, UrunSatış=@x3, UrunGeliş=@x4 where UrunNo=@x1", baglanti);
            komuturun.Parameters.AddWithValue("@x1",textBox8.Text);
            komuturun.Parameters.AddWithValue("@x2", textBox7.Text);
            komuturun.Parameters.AddWithValue("@x3", textBox6.Text);
            komuturun.Parameters.AddWithValue("@x4", textBox5.Text);
            komuturun.ExecuteNonQuery();
            baglanti.Close();
            deger = Convert.ToInt32(textBox8.Text);
            if (deger == 1)
            {
                ekmekstok=Convert.ToInt32(textBox7.Text);
                ekmeksatış=Convert.ToInt32(textBox6.Text);
                ekmekgeliş=Convert.ToInt32(textBox5.Text);
            }
            if (deger == 2)
            {
                sustok = Convert.ToInt32(textBox7.Text);
                susatış = Convert.ToInt32(textBox6.Text);
               sugeliş = Convert.ToInt32(textBox5.Text);
            }
            if (deger == 3)
            {
                yumurstok = Convert.ToInt32(textBox7.Text);
                yumursatış = Convert.ToInt32(textBox6.Text);
                yumurgeliş = Convert.ToInt32(textBox5.Text);
            }
            if (deger == 4)
            {
                nutstok = Convert.ToInt32(textBox7.Text);
                nutsatış = Convert.ToInt32(textBox6.Text);
                nutgeliş = Convert.ToInt32(textBox5.Text);
            }
            if (deger == 5)
            {
                donstok = Convert.ToInt32(textBox7.Text);
                donsatış = Convert.ToInt32(textBox6.Text);
                dongeliş = Convert.ToInt32(textBox5.Text);
            }
            if (deger == 6)
            {
               çaystok = Convert.ToInt32(textBox7.Text);
                çaysatış = Convert.ToInt32(textBox6.Text);
                çaygeliş = Convert.ToInt32(textBox5.Text);
            }
          

        }


        private void button15_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musterilerDataSet3.Tbl_Urun' table. You can move, or remove it, as needed.
            this.tbl_UrunTableAdapter1.Fill(this.musterilerDataSet3.Tbl_Urun);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox9.Text = hesap.ToString();
            textBox10.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand onayla = new SqlCommand("update Tbl_musteri set MusBakiye=@z2 where MusAd=@z1",baglanti);
            onayla.Parameters.AddWithValue("@z1",textBox10.Text);
            onayla.Parameters.AddWithValue("@z2", textBox9.Text);
            onayla.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bakiye günvellenmiştir.");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
         
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

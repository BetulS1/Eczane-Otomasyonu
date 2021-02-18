using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EczaneOtomasyonu
{
    public partial class Form12 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");

        public Form12()
        {
            InitializeComponent();
        }
        //update işleminde set değerlerine parametre değişken verildiğinde olarak işlem yapılamıyor. textbox değeri direkt olarak alınmalı. 
        private void ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM ilaclar WHERE barkod=@barkod AND uretici=@uretici AND ilacad=@ilacad", baglanti);
            komut1.Parameters.AddWithValue("@barkod", Convert.ToInt32(barkod.Text));
            komut1.Parameters.AddWithValue("@uretici", uretici.Text);
            komut1.Parameters.AddWithValue("@ilacad", ilacad.Text);
            OleDbDataReader okuyucu;
            okuyucu = komut1.ExecuteReader();// ve reader komutunu kullanarak gelen veriyi  degıskenımıze atıyoruz

            if (okuyucu.Read())
            {
                OleDbCommand komut = new OleDbCommand("UPDATE ilaclar SET adet = adet + '"+Convert.ToInt32(adet.Text)+"'  WHERE barkod=@barkod ", baglanti);
                komut.Parameters.AddWithValue("@barkod", Convert.ToInt32(barkod.Text));
                komut.Parameters.AddWithValue("@uretici", uretici.Text);
                komut.Parameters.AddWithValue("@ilacad", ilacad.Text);
               
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Stok Eklendi!", "Stok Ekleme");

                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        Controls[i].Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("İlaç Kayıtlı Değil!");
            } 

            baglanti.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM ilaclar WHERE barkod=@barkod AND uretici=@uretici AND ilacad=@ilacad", baglanti);
            komut1.Parameters.AddWithValue("@barkod", Convert.ToInt32(barkod.Text));
            komut1.Parameters.AddWithValue("@uretici", uretici.Text);
            komut1.Parameters.AddWithValue("@ilacad", ilacad.Text);

            OleDbDataReader okuyucu;
            okuyucu = komut1.ExecuteReader();// ve reader komutunu kullanarak gelen veriyi  degıskenımıze atıyoruz

            if (okuyucu.Read())
            {   
                OleDbCommand komut = new OleDbCommand("UPDATE ilaclar SET adet=adet - '"+Convert.ToInt32(adet.Text)+"' WHERE barkod=@barkod ", baglanti);
                komut.Parameters.AddWithValue("@barkod", Convert.ToInt32(barkod.Text));
                komut.Parameters.AddWithValue("@uretici", uretici.Text);
                komut.Parameters.AddWithValue("@ilacad", ilacad.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Stok Silindi!", "Stok Silme");
               
                

                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        Controls[i].Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("İlac Kayıtlı Değil!");
            }

            baglanti.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
        //anasayfaya dönerken giriş yapan yönetici yada calisan olmasına göre döneceğimiz anasayfanın seçimi yapıyoruz
        private void button3_Click(object sender, EventArgs e)
        {
            if (Form13.yonetici == true)
            {
                //yönetici için anasayfaya gider
                Form4 yoneticianasayfa = new Form4();
                yoneticianasayfa.Show();
                this.Hide();
            }
            else
            {
                //calışan için anasayfaya gider
                Form3 calisananasayfa = new Form3();
                calisananasayfa.Show();
                this.Hide();
            }
        }
    }
}

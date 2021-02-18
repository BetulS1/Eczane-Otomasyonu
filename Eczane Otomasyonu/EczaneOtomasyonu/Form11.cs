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
    public partial class Form11 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");

        public Form11()
        {
            InitializeComponent();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM ilaclar WHERE barkod=@barkod", baglanti);
            komut1.Parameters.AddWithValue("@barkod", Convert.ToInt32(barkod.Text));
            OleDbDataReader okuyucu;
            okuyucu = komut1.ExecuteReader();// ve reader komutunu kullanarak gelen veriyi  degıskenımıze atıyoruz

            if (okuyucu.Read())
            {
                OleDbCommand komut = new OleDbCommand("UPDATE ilaclar SET uretici='"+ uretici.Text + "', ilacad='" + ilacad.Text + "', fiyat='" + Convert.ToDouble(fiyat.Text) + "', satis_fiyati='" + Convert.ToDouble(satis_fiyati.Text) + "', kullanım_amaci='" + Convert.ToString(kullanım_amaci.Text) + "' WHERE barkod=@barkod", baglanti);
                komut.Parameters.AddWithValue("@barkod", Convert.ToInt32(barkod.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İlac bilgileri Güncellendi!", "Güncelleme");

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
                MessageBox.Show("Ürün Bulunamadı!");
            }

            baglanti.Close();
        }
        //anasayfaya dönerken giriş yapan yönetici yada calisan olmasına göre döneceğimiz anasayfanın seçimi yapıyoruz
        private void button2_Click(object sender, EventArgs e)
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
                //çalışan için anasayfaya gider
                Form3 calisananasayfa = new Form3();
                calisananasayfa.Show();
                this.Hide();
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}

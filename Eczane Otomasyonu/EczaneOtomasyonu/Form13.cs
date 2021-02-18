using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //veritabanı bağlantısı için 

namespace EczaneOtomasyonu
{
   

    public partial class Form13 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");
        //veritabanı ile bağlantı sağladık
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
        public static bool yonetici= false; //diğer formlarda kullanmak için giriş yapan kişinin yetkisnin belirliyoruz.
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM yonetici WHERE eczane_ID=@eczane_ID AND adsoyad=@adsoyad  AND eczane_sifresi=@eczane_sifresi AND yonetici_sifresi=@yonetici_sifresi", baglanti);
            komut.Parameters.AddWithValue("@eczane_ID", Convert.ToInt32(textBox3.Text));
            komut.Parameters.AddWithValue("@adsoyad", textBox1.Text);
            komut.Parameters.AddWithValue("@eczane_sifresi", textBox2.Text);
            komut.Parameters.AddWithValue("@yonetici_sifresi", textBox4.Text);
          
            OleDbDataReader okuyucu;
            okuyucu = komut.ExecuteReader();//  reader komutunu kullanarak gelen veriyi  degıskenımıze atıyoruz

            if (okuyucu.Read())
            {
                MessageBox.Show("Giris Basarılı!", "GIRIS");
                Form4 yoneticianasayfa = new Form4();
                yoneticianasayfa.Show();
                this.Hide();
                yonetici = true; //giriş yapan kişin yönetici olduğunu belirttik
            }
            else
            {
                MessageBox.Show("Hatali Giris Yaptiniz!");
            }

            baglanti.Close();
        }

    }
}


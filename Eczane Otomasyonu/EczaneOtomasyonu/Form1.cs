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
    public partial class Form1 : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");
        //veritabanı ile bağlantı sağladık

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //personel girişi kısmı iki farklı tablodan veriler içeriyor iki sorgu cümlesi oluşturduk.
            OleDbCommand komut = new OleDbCommand("SELECT * FROM yonetici WHERE eczane_ID=@eczane_ID AND eczane_sifresi=@eczane_sifresi", baglanti);
            OleDbCommand komut2 = new OleDbCommand("SELECT * FROM calisan WHERE ad=@ad AND soyad=@soyad AND tcno=@tcno", baglanti);

            komut.Parameters.AddWithValue("@eczane_ID",Convert.ToInt32(textBox3.Text));
            komut2.Parameters.AddWithValue("@ad", textBox2.Text);
            komut2.Parameters.AddWithValue("@soyad", textBox1.Text);
            komut2.Parameters.AddWithValue("@tcno", textBox5.Text);
            komut.Parameters.AddWithValue("@eczane_sifresi", textBox4.Text);
            OleDbDataReader okuyucu;
            OleDbDataReader okuyucu2;

            okuyucu = komut.ExecuteReader();// reader komutunu kullanarak gelen veriyi  degıskenımıze atıyoruz
            okuyucu2 = komut2.ExecuteReader();


            if (okuyucu.Read() && okuyucu2.Read()) // iki tablodaki veriler eşleşirse giriş tamamlanır
            {
                MessageBox.Show("Giris Basarılı!", "ECZANE OTOMASYONU GIRIS");
                Form3 calısananasayfa = new Form3();
                calısananasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Giris Yaptiniz!","ECZANE OTOMASYONU GİRİŞ");
            }

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 yoneticiGiris = new Form13();
            yoneticiGiris.Show();
            this.Hide();
        }
    }
}

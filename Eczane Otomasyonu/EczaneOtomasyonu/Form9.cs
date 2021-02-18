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
    public partial class Form9 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            goster();
        }

        public void goster()
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT ilac_ID, barkod, uretici, ilacad,fiyat,satis_fiyati,kullanım_amaci FROM ilaclar ORDER BY ilac_Id ASC ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT ilac_ID, barkod, uretici, ilacad,fiyat,satis_fiyati,kullanım_amaci FROM ilaclar WHERE ilacad LIKE '%" + textBox1.Text + "%'  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT ilac_ID, barkod, uretici, ilacad,fiyat,satis_fiyati,kullanım_amaci FROM ilaclar WHERE uretici LIKE '%" + textBox2.Text + "%'  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT ilac_ID, barkod, uretici, ilacad,fiyat,satis_fiyati,kullanım_amaci FROM ilaclar WHERE kullanım_amaci LIKE '%" + textBox3.Text + "%'  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
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
                //calişan için anasayfaya gider
                Form3 calisananasayfa = new Form3();
                calisananasayfa.Show();
                this.Hide();
            }
        }
    }
}

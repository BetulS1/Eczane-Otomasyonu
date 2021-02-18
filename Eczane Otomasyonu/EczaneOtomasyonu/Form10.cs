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
    public partial class Form10 : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");


        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            goster();
        }
        public void goster()
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT barkod,uretici,ilacad,adet FROM ilaclar ORDER BY adet ASC ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT barkod,uretici,ilacad,adet FROM ilaclar WHERE adet<=10 ORDER BY adet  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }
        //anasayfaya dönerken giriş yapan yönetici yada calisan olmasına göre döneceğimiz anasayfanın seçimi yapıyoruz
        private void button1_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT barkod,uretici,ilacad,adet FROM ilaclar WHERE ilacad LIKE '%" + textBox1.Text + "%'  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT barkod,uretici,ilacad,adet FROM ilaclar WHERE uretici LIKE '%" + textBox2.Text + "%'  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }
    }
}

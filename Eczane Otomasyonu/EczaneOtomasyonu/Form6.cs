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
    public partial class Form6 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            goster();
        }

        public void goster()
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter ("SELECT * FROM calisan ORDER BY baslangic ASC ", baglanti);
            komut.Fill(ds, "veriler"); 
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT * FROM calisan WHERE ad LIKE '%" + textBox1.Text + "%'  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT * FROM calisan WHERE soyad LIKE '%" + textBox2.Text + "%' ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT * FROM calisan WHERE tcno LIKE '%" + textBox3.Text + "%' ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 yoneticianasayfa = new Form4();
            yoneticianasayfa.Show();
            this.Hide();
        }
    }
}

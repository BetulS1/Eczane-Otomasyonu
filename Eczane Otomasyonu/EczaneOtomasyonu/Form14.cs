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
    public partial class Form14 : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb"); 

        public Form14()
        {
            InitializeComponent();
        }
       
        private void Form14_Load(object sender, EventArgs e)
        {
            goster(); //form açıldığında tüm ilaç verileri datagrid içinde listelenir

            tutar.Text = "0"; //texte ilk değerini verdik 

        }

        public void goster()
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT * FROM ilaclar ORDER BY ilac_Id ASC ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }
       
        DataTable tablo = new DataTable();
        public static double tutartoplam;
        private void satis_islemi_Click(object sender, EventArgs e)
        {
            ilaclar ilacs = new ilaclar(); //ilac nesnesi oluşturduk 
            ilacs.satis(dataGridView1.CurrentRow.Cells["barkod"].Value.ToString(), dataGridView1.CurrentRow.Cells["uretici"].Value.ToString(), dataGridView1.CurrentRow.Cells["ilacad"].Value.ToString());
            //datagrid üzerinde seçilen ürün bilgisini alıp satışı yaptık adet değeri 1 azaldı.
            SatilanIlaclar ilac = new SatilanIlaclar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["barkod"].Value.ToString()), dataGridView1.CurrentRow.Cells["uretici"].Value.ToString(), dataGridView1.CurrentRow.Cells["ilacad"].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells["adet"].Value.ToString()), Convert.ToDouble(dataGridView1.CurrentRow.Cells["fiyat"].Value.ToString()), Convert.ToDouble(dataGridView1.CurrentRow.Cells["satis_fiyati"].Value.ToString()));
            ilac.kayıt();
            //seçilen ilaç satılan ilaçlar listesine eklendi
            double fiyat = ilacs.tutar(dataGridView1.CurrentRow.Cells["barkod"].Value.ToString(), dataGridView1.CurrentRow.Cells["uretici"].Value.ToString(), dataGridView1.CurrentRow.Cells["ilacad"].Value.ToString());
           
            tutartoplam = Convert.ToDouble(tutar.Text) + fiyat;
            tutar.Text = Convert.ToString(tutartoplam);
            //seçilen ilacların fiyatlarını yazdık label içine her ürün satıldığında toplam fiyat artar 


            tablo.Clear(); //veriler değiştikten sonra yeniden listeledik 
            goster();
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }

        }


        private void ilacad_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT * FROM ilaclar WHERE ilacad LIKE '%" + ilacad.Text + "%'  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void uretici_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT * FROM ilaclar WHERE uretici LIKE '%" + uretici.Text + "%'  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void kullanım_amaci_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT * FROM ilaclar WHERE kullanım_amaci LIKE '%" + kullanım_amaci.Text + "%'  ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }

        private void barkod_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT* FROM ilaclar WHERE barkod LIKE '%" + barkod.Text + "%'  ", baglanti);
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
                //calışan için anasayfaya gider
                Form3 calisananasayfa = new Form3();
                calisananasayfa.Show();
                this.Hide();
            }
        }

        private void fatura_Click(object sender, EventArgs e)
        {
            //satış işlemi sonlandıktan sonra satılan ilaçların tamamnın görülebileceği kısım.
            Form15 fatura = new Form15();
            fatura.Show();
            
        }
    }
}

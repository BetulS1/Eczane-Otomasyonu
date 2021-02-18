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
    public partial class Form15 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");
        public Form15()
        {
            InitializeComponent();
        }
        public void goster()
        {
            baglanti.Open();
            DataSet ds = new DataSet(); //sanal tablo ile verileri alıcaz
            OleDbDataAdapter komut = new OleDbDataAdapter("SELECT barkod,uretici,ilacad,satis_fiyati FROM satis ORDER BY ilac_Id ASC ", baglanti);
            komut.Fill(ds, "veriler");
            dataGridView1.DataSource = ds.Tables["veriler"];
            baglanti.Close();
        }
        private void satisadon_Click(object sender, EventArgs e)
        {
            Form14 satissayfasi = new Form14();
            satissayfasi.Show();
            this.Hide();
            
            dataGridView1.Refresh();
        }
       
       
        private void TAMAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satış İşlemi Tamamlandı", "Satış Bildirimi");
            SatilanIlaclar satilanilaclar = new SatilanIlaclar();
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                satilanilaclar.tablosil();
            }
            
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            goster();

            tutarbilgisi.Text = Convert.ToString(Form14.tutartoplam);
            
        }

        DataTable tablo = new DataTable();
        private void ilacisil_Click(object sender, EventArgs e)
        {
            SatilanIlaclar ilacsil = new SatilanIlaclar();
            ilacsil.sil(dataGridView1.CurrentRow.Cells["barkod"].Value.ToString(), dataGridView1.CurrentRow.Cells["uretici"].Value.ToString(), dataGridView1.CurrentRow.Cells["ilacad"].Value.ToString());
            ilacsil.satis(dataGridView1.CurrentRow.Cells["barkod"].Value.ToString(), dataGridView1.CurrentRow.Cells["uretici"].Value.ToString(), dataGridView1.CurrentRow.Cells["ilacad"].Value.ToString());
            ilaclar ilacs = new ilaclar();
            double fiyat = ilacs.tutar(dataGridView1.CurrentRow.Cells["barkod"].Value.ToString(), dataGridView1.CurrentRow.Cells["uretici"].Value.ToString(), dataGridView1.CurrentRow.Cells["ilacad"].Value.ToString());
            double tutartoplam = Convert.ToDouble(tutarbilgisi.Text) - fiyat;
            tutarbilgisi.Text = Convert.ToString(tutartoplam);
            tablo.Clear(); //veriler değiştikten sonra yeniden listeledik 
            goster();
        }
    }
}

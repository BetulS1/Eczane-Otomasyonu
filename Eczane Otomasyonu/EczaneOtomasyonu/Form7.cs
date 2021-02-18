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
    public partial class Form7 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");

        public Form7()
        {
            InitializeComponent();
        }
        
        private void kaydet_Click(object sender, EventArgs e)
        {
           
                //ilac nesnesi oluşturduk 
                //ilac nesnesini alınan form bilgileri ile oluşturuyoruz 
                ilaclar ilac = new ilaclar(Convert.ToInt32(barkod.Text), uretici.Text, ilacad.Text, Convert.ToInt32(adet.Text), Convert.ToDouble(fiyat.Text), Convert.ToDouble(satis_fiyati.Text), kullanım_amaci.Text);

                MessageBox.Show(ilac.kayıt(), "Kayit");

                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        Controls[i].Text = "";
                    }
                }    
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}

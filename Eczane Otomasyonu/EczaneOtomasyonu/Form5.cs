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
    public partial class Form5 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calisan calisan2 = new calisan(); //nesne oluştruduk çalışan işlemi için 
            if (calisan2.sil(textBox3.Text, textBox1.Text, textBox3.Text))  //silme işlemi yapan fonksiyonu çağırdık ve parametre değerlerini verdik 
            {
             MessageBox.Show("Kayıt Silindi!", "Silme İşlemi");

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
                MessageBox.Show("Calışan Kayıtlı Değil!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 yoneticianasayfa = new Form4();
            yoneticianasayfa.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
    
}

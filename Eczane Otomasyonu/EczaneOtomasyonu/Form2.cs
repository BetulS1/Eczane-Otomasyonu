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
    public partial class Form2 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            //calisan nesnesini alınan form bilgileri ile oluşturuyoruz 
            calisan calisan1 = new calisan(textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker2.Value, textBox2.Text, dateTimePicker1.Value);
            //kayıt fonk. çağırdık ve kayıt işleminin sonucunu messagebox içerisinde kullanıcıya gösterdik.
            MessageBox.Show( calisan1.kayıt() ,"Kayit");

            //kayıt işlemindenn sonra textbox hücrelerini temizlemek için for döngüsü kullandık içerisi " " boşluk olur.
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 yoneticianasayfa= new Form4();
            yoneticianasayfa.Show();
            this.Hide();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}

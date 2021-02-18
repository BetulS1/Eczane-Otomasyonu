using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EczaneOtomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 ilackayıt = new Form7();
            ilackayıt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 ilacsil = new Form8();
            ilacsil.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 ilacgüncelle = new Form11();
            ilacgüncelle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 ilaclistesi = new Form9();
            ilaclistesi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 stokdurumu = new Form10();
            stokdurumu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 stokekle_sil = new Form12();
            stokekle_sil.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 satisislemleri = new Form14();
            satisislemleri.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

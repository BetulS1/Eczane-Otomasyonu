using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace EczaneOtomasyonu
{
    class calisan : IEczane //eczane interface sınıfını ilaç sınıfına implemente ettik
    {
        //calisan nesnesinin sahip olması gereken özellikler tanımlandı ve setter-getter metodları yazıldı.
        private string ad;
        private string soyad;
        private string tcno;
        private DateTime dtarihi;
        private string telefon;
        private DateTime baslangic;

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");

        //constructor metodu tanımladık sınıftan nesne oluşurken ilk bu metod çalışacak
        public calisan (string ad, string soyad, string tcno, DateTime dtarihi, string telefon, DateTime baslangic)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.tcno = tcno;
            this.dtarihi = dtarihi;
            this.telefon = telefon;
            this.baslangic= baslangic;
        }
        public calisan()
        {

        }

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Tcno
        {
            get { return tcno; }
            set { tcno = value; }
        }
        public DateTime Dtarihi
        {
            get { return dtarihi; }
            set { dtarihi = value; }
        }
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public DateTime Baslangic 
        { 
            get { return  baslangic;}
            set { baslangic = value; }
        }

        //interface ile gelen metodları bu sınıfa göre override ediyoruz
        public string kayıt()
        {
            string mesaj = "Hata";
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM calisan WHERE tcno=@tcno", baglanti);
            komut1.Parameters.AddWithValue("@tcno", tcno);
            OleDbDataReader okuyucu;
            okuyucu = komut1.ExecuteReader();// ve reader komutunu kullanarak gelen veriyi  degıskenımıze atıyoruz

            if (okuyucu.Read())
            {
                mesaj ="Çalışan Zaten Kayıtlı!";
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("INSERT INTO calisan (tcno, ad, soyad, dtarihi, telefon, baslangic) VALUES (@tcno,@ad, @soyad, @dtarihi, @telefon, @baslangic)", baglanti);
                
                komut.Parameters.AddWithValue("@tcno", tcno);
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@dtarihi", dtarihi);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@baslangic", baslangic);

                komut.ExecuteNonQuery();
                baglanti.Close();
                mesaj = "Kayıt Eklendi!";
            }
            baglanti.Close();
            return mesaj;
        }
       
        public bool sil(string deger1 , string deger2 , string deger3)
        {
            bool mesaj;
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM calisan WHERE tcno=@tcno", baglanti);
            komut1.Parameters.AddWithValue("@tcno", deger1);
            OleDbDataReader okuyucu;
            okuyucu = komut1.ExecuteReader();// ve reader komutunu kullanarak gelen veriyi  degıskenımıze atıyoruz

            if (okuyucu.Read())
            {
                OleDbCommand komut = new OleDbCommand("DELETE * FROM calisan  WHERE ad= @ad AND soyad=@soyad AND tcno=@tcno", baglanti);
                komut.Parameters.AddWithValue("@ad", deger2);
                komut.Parameters.AddWithValue("@soyad",deger3);
                komut.Parameters.AddWithValue("@tcno", deger1);
                komut.ExecuteNonQuery();
                baglanti.Close();
                mesaj=true;

            }
            else
            {
                mesaj= false;
            }
            baglanti.Close();
            return mesaj;
        }
        
    }
}

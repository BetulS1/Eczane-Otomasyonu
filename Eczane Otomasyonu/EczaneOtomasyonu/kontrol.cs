
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; 
namespace EczaneOtomasyonu
{
    class ilaclar : Urunler, IEczane, Iislem //eczane ve Iislem interface sınıfını ilaç sınıfına implemente ettik 
    {
        //ilac nesnesinin sahip olması gereken özellikler tanımlandı ve setter-getter metodları yazıldı.
      
        private string kullanım_amaci;

        //constructor metodu tanımladık sınıftan nesne oluşurken ilk bu metod çalışacak
        public ilaclar (int barkod, string uretici, string ilacad, int adet, double fiyat,double satis_fiyati, string kullanım_amaci):
            base (barkod, uretici, ilacad, adet, fiyat, satis_fiyati)
        {
            this.kullanım_amaci = kullanım_amaci;
        }

        public ilaclar():base()
        {
           
        }
       
        public string Kullanım_amaci
        {
            get
            {
                return kullanım_amaci;
            }
            set
            {
                kullanım_amaci = value;
            }
        }

      

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBaseEczane.mdb");

        //interface ile gelen metodları bu sınıfa göre override ediyoruz
        public string kayıt()
        {
            string mesaj;

            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM ilaclar WHERE barkod=@barkod", baglanti);
            komut1.Parameters.AddWithValue("@barkod", barkod);
            OleDbDataReader okuyucu;
            okuyucu = komut1.ExecuteReader();// ve reader komutunu kullanarak gelen veriyi  degıskenımıze atıyoruz

            if (okuyucu.Read())
            {
                mesaj= "Ürün Zaten Kayıtlı!";
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("INSERT INTO ilaclar (barkod, uretici,ilacad,adet,fiyat,satis_fiyati,kullanım_amaci) " +
                    "VALUES (@barkod, @uretici, @ilacad, @adet, @fiyat,@satis_fiyati, @kullanım_amaci)", baglanti);
                komut.Parameters.AddWithValue("@barkod", barkod);
                komut.Parameters.AddWithValue("@uretici", uretici);
                komut.Parameters.AddWithValue("@ilacad", ilacad);
                komut.Parameters.AddWithValue("@adet", adet);
                komut.Parameters.AddWithValue("@fiyat", fiyat);
                komut.Parameters.AddWithValue("@satis_fiyati", satis_fiyati);
                komut.Parameters.AddWithValue("@kullanım_amaci", kullanım_amaci);
                komut.ExecuteNonQuery();
                baglanti.Close();

                mesaj = "Urun Kaydedildi!";
            }
            return mesaj;
        }

        public bool sil(string deger1, string deger2, string deger3)
        {
            bool mesaj;
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("SELECT * FROM ilaclar WHERE barkod=@barkod", baglanti);
            komut1.Parameters.AddWithValue("@barkod", Convert.ToInt32(deger1));
            OleDbDataReader okuyucu;
            okuyucu = komut1.ExecuteReader();// ve reader komutunu kullanarak gelen veriyi  degıskenımıze atıyoruz

            if (okuyucu.Read())
            {
                OleDbCommand komut = new OleDbCommand("DELETE * FROM ilaclar  WHERE barkod= @barkod" +
                    " AND uretici=@uretici AND ilacad= @ilacad", baglanti);
                komut.Parameters.AddWithValue("@barkod", Convert.ToInt32(deger1));
                komut.Parameters.AddWithValue("@uretici", deger2);
                komut.Parameters.AddWithValue("@ilacad", deger3);
                komut.ExecuteNonQuery();
                baglanti.Close();

                mesaj = true;
            }
            else
            {
                mesaj = false;
            }
            baglanti.Close();
            return mesaj;
        }

        public bool satis(string barkod, string uretici , string ilacad )
        {
            bool mesaj;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE ilaclar SET adet=adet -1  WHERE barkod=@barkod" +
                " AND uretici=@uretici AND ilacad=@ilacad", baglanti);
            komut.Parameters.AddWithValue("@barkod", Convert.ToInt32(barkod));
            komut.Parameters.AddWithValue("@uretici", uretici);
            komut.Parameters.AddWithValue("@ilacad", ilacad);
            komut.ExecuteNonQuery();
            baglanti.Close();
            mesaj = true;
            baglanti.Close();
            return mesaj; 
        }
        public double tutar(string barkod, string uretici, string ilacad)
        {
            
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT satis_fiyati FROM ilaclar WHERE barkod=@barkod " +
                "AND uretici=@uretici AND ilacad=@ilacad", baglanti);
            komut.Parameters.AddWithValue("@barkod", Convert.ToInt32(barkod));
            komut.Parameters.AddWithValue("@uretici", uretici);
            komut.Parameters.AddWithValue("@ilacad", ilacad);
             //(tek bi değer alır) sadece satış fiyatı değerini almak için kullandık
            string tutar = komut.ExecuteScalar().ToString(); //değeri bir değişkeen atadık 
             
            baglanti.Close();
            return Convert.ToDouble(tutar); 

        }
    }
}

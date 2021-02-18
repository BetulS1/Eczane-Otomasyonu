using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneOtomasyonu
{   //bu işlem sınıfını işlemleri yapmak için kullanılacak metodları tanımlamak için kullandık.
    interface Iislem
    {
         bool satis(string barkod, string uretici, string ilacad);  //satış işlemi metodu 
         double tutar(string barkod, string uretici, string ilacad); //tuttar hesaplama işlemi metodu
    }
}

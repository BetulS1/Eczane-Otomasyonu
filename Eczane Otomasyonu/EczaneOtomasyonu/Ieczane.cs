using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneOtomasyonu
{
    interface IEczane // Sınıfların hangi metotları içermesi gerektiğini ınterface kullanarak bildiriyoruz.
    {
        bool sil(string deger1, string deger2 ,string deger3); //silme metodu ve 3 adat parametre değeri alı hangi nesnenin silineceğini bulmak için
        string kayıt(); //kayıt metodu
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention - isimlendirme - normal parentez varsa methods
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi");

        }
        
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi:" + urunAdi);
        }




    }
}

using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemegirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
            if (sistemegirisYapmisMi== true)
            {
            Console.WriteLine("Kullanıcı Ayarlar Buyonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            
            Console.WriteLine("kategoriEtiketi");
            
        }
    }
}
 
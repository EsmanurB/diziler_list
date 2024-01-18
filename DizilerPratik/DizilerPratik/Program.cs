using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DizilerPratik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* // Soru 1: Tanımlanan sayılar dizisi içerisindeki sayıların negafit, pozitif ve işaretsiz olma durumlarını yanına yazdıran c# konsol uygulaması

             int[] sayilar = { 20, -15, 96, 0, -85, -12, 14, -74, -13, 14 };



          foreach (int sayi in sayilar)
             {

                 if (sayi > 0)
                 {
                     Console.WriteLine(sayi + " Pozitif");    
                 }
                 else if (sayi < 0)
                 {
                     Console.WriteLine(sayi + "Negatif");
                 }
                 else 
                   Console.WriteLine(sayi +"İşaretsiz");             

             }
             Console.ReadLine(); */


            /*   // Soru2: 20 kişilik bir sınıftaki öğrenci adlarını tutabilecek bir dizi değişken tanımlayınız., Klavyeden girilen isimleri tanımladığınız bu dizi değişkene atayınız.

               string[] ogrenciAdları = new string[5];

               for (int i = 0; i < ogrenciAdları.Length; i++)
               {
                   string isim;
                   Console.WriteLine("Lütfen isim giriniz:");
                   isim = Console.ReadLine();

                   try
                   {
                       if (i <= ogrenciAdları.Length) ogrenciAdları[i] = isim;
                   }
                   catch 
                   {


                   }

               }


            /*  Dizi içine yazdırma :1
             *  for (int i = 0; i < ogrenciAdları.Length; i++)
               {
                   Console.WriteLine(ogrenciAdları[i]);
               }

               foreach (string item in ogrenciAdları)
               {
                   Console.WriteLine(item);
               }


               Console.ReadLine();


               */


            /*   // Soru3: string[] sehirler={"Kayıt Yok", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara"}

                Yukarıda verilen diziyi tanımlayarak aşağıdaki soruları bu diziye göre çözünüz.

                Klavyeden plaka kodu girilen il adını ekrana yazdırınız. Girilen koda ait il yok ise kayıt bulunamadı olarak mesaj veriniz.
                Klavyeden il adı girilen ile ait plaka kodunu ekrana yazdırınız. Plaka kodu bulunamayan il için kayıt bulunamadı mesajını veriniz.


               string[] sehirler = { "Kayıt Yok", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara" };

               int Plakakodu;
               Console.WriteLine("Lutfen plaka kodunu giriniz :");
               Plakakodu = Convert.ToInt32(Console.ReadLine());


               switch (Plakakodu)
               {
                   case 01:

                       Console.WriteLine("Adana");
                       break;
                   case 02:
                       Console.WriteLine("Adıyaman");
                       break;
                   case 03:
                       Console.WriteLine("Afyonkarahisar");
                       break;
                   case 04:
                       Console.WriteLine("Ağrı");
                       break;
                   case 05:
                       Console.WriteLine("Amasya");
                       break;
                   case 06:
                       Console.WriteLine("Ankara");
                       break;
                   default:
                       Console.WriteLine("Kayıt bulunamadı.");
                       break;
               }


               Console.ReadLine(); */



            /*   // Soru 4:  Eleman sayısını kullanıcının belirlediği bir dizi oluşturarak içine kullanıcının eleman girmesini sağlayan örnek:

               int KisiSayisi;
               Console.WriteLine("Kisi sayisini giriniz:");
               KisiSayisi = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("----------------------");

               string[] ogrenci = new string[KisiSayisi];

               for (int i = 0; i < KisiSayisi; i++)
               {
                   Console.WriteLine("Ogrenci Adını Girimiz :");
                   ogrenci[i] = Console.ReadLine();

               }

               Console.WriteLine();
               Console.ReadLine(); */

            /*   // Soru 5: 10 personele ait numara,isim,telefon ve email bilgileri ayrı ayrı dizilerde tutan ve aranan numaraya göre ilgili kişinin bilgilerini ekranda gösteren dizi örneği (indexOf kullanıldı) :

               string[] ogrno = { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110" };
               string[] isim = { "Ali", "Veli", "Hasan", "Kemal", "Can", "Ahmet", "Mehmet", "Enis", "Bilal", "Burak" };
               string[] telefon = { "111", "222", "333", "444", "555", "666", "777", "888", "999", "1000" };
               string[] mail = { "aaaa@aaa.aa", "bbbbb@bbb.bb", "cccc@ccc.cc", "dddd@ddd.dd", "eeee@eee.ee", "ffff@eee.ee", "gggg@eee.ee", "hhhh@eee.ee", "iiii@eee.ee", "jj@eee.eej" };

               Console.Write("Kişi No'yu girin: ");
               string aranan = Console.ReadLine();
               int no = Array.IndexOf(ogrno, aranan.ToString());
               Console.WriteLine("===========================================================================");
               Console.WriteLine("Aranan Kişi : {0}\tTelefonu: {1}\tE-mail: {2}", isim[no], telefon[no], mail[no]);
               Console.ReadLine(); */

            // Soru 6: 
            /*  //20 elemanlı diziye rasgele -100 ile +100 arası sayılar atan ve daha sonra dizinin elemanlarını, pozitif sayı adetini,negatif sayı adetini ve işaretsiz sayı adetini ekranda gösteren örnek.


              int[] sayilar = new int[20];
              int pozitif = 0;
              int negatif = 0;
              int notr = 0;
              Random rnd = new Random();

              for (int i =0; i < 20; i++)
              {
                  sayilar[i] = rnd.Next(-100,100);
              }

              foreach (int sayi in sayilar) 
              { 
                  Console.WriteLine(sayi);

               if (sayi > 0)
                  {
                      pozitif++;
                  }
              else if(sayi<0) { 

                  negatif++;
                  }
               else { 
                  notr++;
                  }


              }

              Console.WriteLine("Pozitif Sayı Adeti>>> " + pozitif);
              Console.WriteLine("Negatif Sayı Adeti>>> " + negatif);
              Console.WriteLine("İşaretsiz Sayı Adeti>>> " + notr);

              Console.ReadLine(); 
            */

            /*   // Soru 7::Kullanıcının girmiş olduğu sayının dizide olup olmadığını bulan, varsa kaç adet bulunduğunu ekranda gösteren dizi örneği:

               int[] sayilar = { 25, 65, 125, 85, 85, 23, 85, 14 ,100, 250, 450, 32, 450, 1, 8 ,13};

               int sayi;
               int aynıSayi = 0;

               Console.WriteLine("Lütfen sayı giriniz:");
               sayi = Convert.ToInt32(Console.ReadLine());

               bool kontrol = sayilar.Contains(sayi); // girilen sayı dizi içinde mi onu kontrol eder.

               if (kontrol)
               {
                   Console.WriteLine("Sayı dizi içinde mevcuttur");
               }
               else
               { Console.WriteLine("Sayı dizi içinde bulunamadı."); }

               for (int i = 0; i<sayilar.Length; i++)
               {
                   if(sayi == sayilar[i])
                   {
                       aynıSayi++;
                   }

               }

               if(aynıSayi != 0) {

                   Console.WriteLine("Bu sayı dizide {0} adet var", aynıSayi);

               }

               Console.ReadLine();
            */

            /*   // Soru 8:10 elemanlı string dizi içindeki tek sayıları foreach döngüsüyle ekrana yazdıran ve teksayıların adetini ekranda gösteren örnek:

               int sayac = 0;
               int[] sayilar = { 10, 15, 20, 33, 22, 11, 9, 8, 48, 47, 12, 25, 12, 21 };
               int toplam = 0;

               foreach (int sayi in sayilar)
               {

                   if (sayi % 2 == 1)
                   {
                       sayac++;
                       Console.WriteLine(sayi);
                   }

               }
               Console.WriteLine("Tek sayı adeti= " + sayac);



               Console.ReadLine(); */




            /*   // Soru 9: Kullanıcıdan alınan metnin içinde bulunan sesli harf sayısını bulan c# console uygulaması


               char[] harfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
               string metin;
               int sayac = 0;
               Console.WriteLine("Metin giriniz : ");
               metin = Console.ReadLine();

               for (int i = 0; i < harfler.Length; i++)
               {
                   for (int j = 0; j < metin.Length; j++)
                   {
                       if (metin[j] == harfler[i])
                       {
                           sayac++;
                       }
                   }
               }
               Console.WriteLine(sayac);
               Console.ReadLine();

            */

            /*  // soru 10 :: İçerisinde isimler bulunan string bir diziyi en son elemandan itibaren ekrana yazdıran örnek:

               string[] isimler = {"esmanur", "nazli", "sinan","emre"," betul" };

               int son = isimler.Length - 1;

               for (int i = son; i >=0; i--)
               {
                   Console.WriteLine(isimler[i]);
               }
               Console.ReadLine(); */

            // soru 11: 

            //Eleman Girme işlemi
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}. elemanı giriniz : ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("=========================================");
            // Yazdırma işlemi
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = dizi[i] + (dizi[i] * 20 / 100);
                Console.WriteLine("Dizinin {0}. indexi : {1} ", i, dizi[i]);
            }

            Console.ReadLine();





        }
    }
}

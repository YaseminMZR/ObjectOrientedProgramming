/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:Ödev - 1
**				ÖĞRENCİ ADI............:Yasemin MUZIROĞLU
**				ÖĞRENCİ NUMARASI.......:B191210054
**              DERSİN ALINDIĞI GRUP...:1D
****************************************************************************/

using System;

namespace Soru2
{
    class Program
    {
       
        
            static void fonksiyon1(string aranilacakKelime, string karakterDizini, int kelimeYeri = 0)
            {
                //eğer kelime hala bulunuyorsa ife girer, bulunmuyorsa -1 çevirir.
                if (karakterDizini.IndexOf(aranilacakKelime, kelimeYeri) >= 0)
                {
                    kelimeYeri = karakterDizini.IndexOf(aranilacakKelime, kelimeYeri);
                    Console.WriteLine("kelime " + aranilacakKelime + " indis : " + kelimeYeri++);
                    fonksiyon1(aranilacakKelime, karakterDizini, kelimeYeri);
                }
            }
            static void fonksiyon2(string aranilacakKelime, string karakterDizini, int kelimeYeri = 0)
            {
                //eğer kelime hala bulunuyorsa ife girer, bulunmuyorsa -1 çevirir.
                if (karakterDizini.IndexOf(aranilacakKelime, kelimeYeri) >= 0)
                {
                    kelimeYeri = karakterDizini.Substring(0, karakterDizini.IndexOf(aranilacakKelime, kelimeYeri)).Length;
                    Console.WriteLine(aranilacakKelime + " indis : " + kelimeYeri++);
                    fonksiyon2(aranilacakKelime, karakterDizini, kelimeYeri);
                }
            }
            static void fonksiyon3(string karakterDizini)
            {
                string alfabe = "abcçdefgğhıijklmnoöpqrsştuüvwxyz";
                int[] harfSayisi = new int[32];
                //tüm harflerin sayısını sıfır yapar.
                for (int i = 0; i < 32; i++)
                    harfSayisi[i] = 0;
                //karakter dizini uzunluğunca tüm harfler için kontrol eder.
                for (int i = 0; i < karakterDizini.Length; i++)
                {
                    //alfabanin tüm harfleri için kontrol eder.
                    for (int j = 0; j < alfabe.Length; j++)
                    {
                        //alfabenin harfi ile karakter dizisinin harfi eşitse ife girer.
                        if (alfabe[j] == karakterDizini[i])
                            harfSayisi[j]++;
                    }
                }
                alfabe = alfabe.ToUpper();
                //tüm alfabe için döner.
                for (int i = 0; i < alfabe.Length; i++)
                {
                    Console.Write(alfabe[i] + ", sayısı: " + harfSayisi[i] + "\t");
                    //harften kaç tane varsa o kadar yıldız basar.
                    for (int j = 0; j < harfSayisi[i]; j++)
                        Console.Write(" *");
                    Console.WriteLine();
                }
            }

            public static void Main(string[] args)
            {
                Console.WriteLine(" 1. String bir değişkende string değeri substring kullanmadan ara.");
                Console.WriteLine(" 2. String bir değişkende string değeri substring kullanarak ara.");
                Console.WriteLine(" 3.Alfabenin karakterlerini bir stringte ara , kaç adet geçiyor bul ve Çiz.");
                Console.Write(" Lütfen yukarıdaki seçeneklerden birini seçiniz (1,2 ya da 3) : ");
                int secilenSecenek;
                string aranilacakKelime = "";
                secilenSecenek = int.Parse(Console.ReadLine());
                while (!(secilenSecenek == 1 || secilenSecenek == 2 || secilenSecenek == 3))
                {
                    Console.Write("Lütfen doğru bir seçenek seçiniz (1,2 veya 3) : ");
                    secilenSecenek = int.Parse(Console.ReadLine());
                }
                Console.Write("karakter dizini :");
                string karakterDizini = Console.ReadLine();
                if (secilenSecenek == 1 || secilenSecenek == 2)
                {
                    Console.Write("Aranılacak kelime :");
                    aranilacakKelime = Console.ReadLine();
                    Console.WriteLine();
                }



                //seçilen seçeneğin değerine göre uygun case'e girer.
                switch (secilenSecenek)
                {
                    case 1:

                        fonksiyon1(aranilacakKelime.ToLower(), karakterDizini.ToLower());
                        break;

                    case 2:

                        fonksiyon2(aranilacakKelime.ToLower(), karakterDizini.ToLower());
                        break;

                    case 3:
                        Console.WriteLine("Karakter sayısı \t grafik gösterimi\n-------------------------------------------------");
                        Console.WriteLine(karakterDizini + "\n");
                        fonksiyon3(karakterDizini.ToLower());
                        break;

                    default:
                        break;

                }
            }
        }
    }

    


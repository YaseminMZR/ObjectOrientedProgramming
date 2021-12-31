/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:Ödev - 2
**				ÖĞRENCİ ADI............:Yasemin MUZIROĞLU
**				ÖĞRENCİ NUMARASI.......:B191210054
**              DERSİN ALINDIĞI GRUP...:1D
****************************************************************************/








using System;
using System.Collections;

namespace Soru1
{
    class BenimString
    {
        public int elemanSayısı(string metin)
        {
            int elemanSayısı = 0;

            //parametre olarak alınan stringin tüm elemanları için döner.
            foreach (var eleman in metin)
                elemanSayısı++;

            return elemanSayısı;


        }
        public string birleştir()
        {
            Console.WriteLine("Lütfen birleştirmek istediğiniz string dizilerinden ilkini giriniz : ");
            string ilk = Console.ReadLine();
            Console.WriteLine("Lütfen birleştirmek istediğiniz string dizilerinden ikincisini giriniz : ");
            string ikinci = Console.ReadLine();

            string sonString = ilk + ikinci;

            return sonString;
        }
        public string arayaGir(int p, string değer)
        {
            Console.WriteLine("Lütfen kaynak nesneyi giriniz : ");
            string kaynak = Console.ReadLine();

            //Kullanıcı parametreye uygun bir kaynak nesne girene kadar döner.
            while (elemanSayısı(kaynak) < p)
            {
                Console.WriteLine("Lütfen parametreye uygun bir kaynak nesne giriniz : ");
                kaynak = Console.ReadLine();
            }


            string sonString = " ";

            // İstenilen indisten itibaren değeri araya eklemek için kaynak nesnenin eleman sayısı kadar döner.
            for (int i = 0; i < elemanSayısı(kaynak); i++)
            {
                //Döngü içerisinde o anki i değerinin alınan parametreye eşit olup olmadığını kontrol eder.
                if (i == p)
                { 
                    //Eğer eşitse , araya belirtilen değeri ekler.
                    sonString += kaynak[i];
                    sonString += değer;
                }

                // Eğer eşit değilse, o anki kaynak nesnenin elemanını ekler.
                else
                    sonString += kaynak[i];

            }

            return sonString;


        }

        public string değerAl(int a, int b)
        {
            Console.WriteLine("Lütfen kaynak nesneyi giriniz : ");  
            string kaynak = Console.ReadLine();

            // Kaynak nesnenin eleman sayısı verilen parametrelere uygun olana kadar döner.
            while(elemanSayısı(kaynak)< a+b)
            {
                Console.WriteLine("Lütfen parametrelere uygun bir kaynak nesne giriniz : ");
                kaynak = Console.ReadLine();
            }

            string sonString = " ";

            // Belirtilen indisten başlayarak belirtilen karakter kadar kısmı sonString değişkenine ekler.
            for (int i = 0; i< elemanSayısı(kaynak); i++)
            {
                //Döngünün içerisinde o anki i değerinin istenilen indis olup olmadığını belirler.
                if( a<=i && i<a+b)
                {
                    // Eğer o indisse, sonString değişkeninin içerisine yazar.
                    sonString += kaynak[i];
                }
            }

            return sonString;

        }

        public ArrayList diziyeAyır()
        {
            Console.WriteLine("Lütfen kaynak nesneyi giriniz : ");
            string kaynak = Console.ReadLine();
            Console.Write("Lütfen aranılacak karakteri giriniz : ");
            char karakter = Char.Parse(Console.ReadLine());
            
            ArrayList dizi = new ArrayList();  
            string kelime = "";

            // Kaynak nesnesinin sonuna aranlacak karakteri ekler.
            kaynak += karakter;

            //Kaynak boyutunda dönecek.
            foreach(char harf in kaynak)
            {
                //Döngü içerisinde o anki harfin aranılan karaktere eşit olup olmadığını kontrol eder.
                if (harf != karakter)
                {
                    // Eğer eşit değilse, harfi kelimeye ekler.
                    kelime += harf;
                }

                //Eğer eşitse , kelimeyi diziye ekler ve içerisini sıfırlar.
                else
                {
                    dizi.Add(kelime);
                    kelime = "";
                }

            }
            return dizi;
        }

        public char[] charDiziyeDönüştür(string değer)
        {

            char[] karakterDizisi = new char[elemanSayısı(değer)];

            //Kaynak nesnesinin boyutu kadar döner.
            for (int i = 0; i < elemanSayısı(değer); i++)
                karakterDizisi[i] = değer[i];

            return karakterDizisi;
        }

        public void değerİndis()
        {
            Console.WriteLine("Karakter dizinini giriniz : ");
            string kaynak = Console.ReadLine();
            Console.Write("Aranılacak karakteri giriniz : ");
            char karakter = Char.Parse(Console.ReadLine());
            bool Thereis = false;

            //Kaynak nesnenin eleman sayısı kadar döner.
            for(int i=0; i<elemanSayısı(kaynak); i++)
            {
                // O anki i değeri için kaynağın elemanının aranılacak karaktere eşit olup olmadığını kontrol eder.
                if(kaynak[i]==karakter)
                {
                    //Eşitse ekrana yazdırır.
                    Console.WriteLine("Aranılacak kelime :{0} - indis :{1}", karakter, i);
                    Thereis = true;

                }
                
            }
             
            // Eğer aranılacak kelime karakter dizininde yoksa ekrana bunu yazdırır.
            if(!Thereis)
            {
                Console.WriteLine("Aranılan karakter kaynak dizin arasında bulunamadı.");
            }
        }

        public char[] tersÇevir(string kaynak)
        {

            char[] ters = new char[elemanSayısı(kaynak)];

            //Kaynak nesnenin eleman sayısı kadar döner.
            for(int i=0;i<elemanSayısı(kaynak);i++)
            {
                ters[i] = kaynak[elemanSayısı(kaynak) - i-1];
            }

            return ters;
        }

        public char[] sıralaAZ(string kaynak)
        {

            char[] sıralı = new char[elemanSayısı(kaynak)];
            sıralı = charDiziyeDönüştür(kaynak);

            
            char temp;
            //kaynağın uzunluğu kadar dönüyor
            for (int i=1;i<elemanSayısı(kaynak);i++)
            {
                temp = sıralı[i];
                int j = i - 1;

                //sıralı char dizisinin j.indisi geçiçi olarak tuttuğumuz temp değerinden küçük oluncaya kadar ve j indisi sıfır olana kadar döner.
                while(j>=0&&sıralı[j]>temp)
                {
                    sıralı[j + 1] = sıralı[j];
                    j--;
                }
                sıralı[j + 1] = temp;
            }
            return sıralı;
        }
        public char[] sıralaZA(string kaynak)
        {
            char[] sıralı = new char[elemanSayısı(kaynak)];
            sıralı = charDiziyeDönüştür(kaynak);


            char temp;
            //kaynağın uzunluğu kadar dönüyor
            for (int i = 1; i < elemanSayısı(kaynak); i++)
            {
                temp = sıralı[i];
                int j = i - 1;
                //sıralı char dizisinin j.indisi geçiçi olarak tuttuğumuz temp değerinden büyük oluncaya kadar ve j indisi sıfır olana kadar döner.
                while (j >= 0 && sıralı[j] < temp)
                {
                    sıralı[j + 1] = sıralı[j];
                    j--;
                }
                sıralı[j + 1] = temp;
            }
            return sıralı;
        }
    }    

    class Program
    {
        static void Main(string[] args)
        {
            BenimString örnekSınıf = new BenimString();
            Console.WriteLine("---------------elemanSayısı----------------");
            Console.WriteLine("Lütfen string bir değer giriniz : ");
            string _metin = Console.ReadLine();
            Console.WriteLine("Eleman sayısı :" + örnekSınıf.elemanSayısı(_metin));

            Console.WriteLine("\n---------------birleştir----------------");
            Console.WriteLine("Oluşan String : " + örnekSınıf.birleştir());

            Console.WriteLine("\n---------------arayaGir----------------");
            Console.WriteLine("Lütfen başlangıç indisini giriniz : ");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen araya girecek string değeri giriniz : ");
            string değer = Console.ReadLine();
            Console.WriteLine("Oluşan String : " + örnekSınıf.arayaGir(p1, değer));

            Console.WriteLine("\n---------------değerAl----------------");
            Console.WriteLine("Başlangıç indisini giriniz : ");
            int _a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci parametreyi giriniz : ");
            int _b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Oluşan String : " + örnekSınıf.değerAl(_a, _b));

            Console.WriteLine("\n---------------diziyeAyır----------------");
            ArrayList al = örnekSınıf.diziyeAyır();
            foreach (object item in al)
                Console.WriteLine(item);

            Console.WriteLine("\n---------------charDiziyeDönüştür----------------");
            Console.WriteLine("Kaynak nesneyi giriniz : ");
            string kaynak = Console.ReadLine();
            char[] charDizisi = örnekSınıf.charDiziyeDönüştür(kaynak);
            foreach (char item in charDizisi)
                Console.Write(item + " ");

            Console.WriteLine("\n---------------değerİndis----------------");
            örnekSınıf.değerİndis();

            Console.WriteLine("\n---------------tersÇevir----------------");
            Console.WriteLine("Lütfen ters çevrilecek kaynak nesneyi giriniz : ");
            string kaynakNesne = Console.ReadLine();
            Console.WriteLine(örnekSınıf.tersÇevir(kaynakNesne));


            Console.WriteLine("\n---------------sıralaAZ----------------");
            Console.WriteLine("Sıralanacak kaynak nesneyi yazın : ");
            string siraliAZ = Console.ReadLine();
            Console.WriteLine(örnekSınıf.sıralaAZ(siraliAZ));


            Console.WriteLine("\n---------------sıralaZA----------------");
            Console.WriteLine("Sıralanacak kaynak nesneyi yazın : ");
            string siraliZA = Console.ReadLine();
            Console.WriteLine(örnekSınıf.sıralaZA(siraliZA));


        }
    }
}

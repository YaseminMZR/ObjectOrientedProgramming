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

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matris = new int[8, 8];
            bool isDone = false;
            //tüm işlem bitene kadar döner
            do
            {
                bool isX = false;
                int satir = random.Next(0, 8);
                int sutun = random.Next(0, 8);
                matris[satir, sutun]++; 
                //matrisi ekrana bastırır (satır)
                for (int i = 0; i < 8; i++)
                {
                    //matrisi ekrana bastırır (sütun)
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(matris[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------");
                //kale koyulan satırda çakışan varsa isX true olur (çakışma olduğunu belirtir)
                for (int i = 0; i < 8; i++)
                {
                    //çakışma varsa diğer döngü kırılır
                    if (isX)
                        break;
                    //eğer satir sayısı i ile eşitse matrisin elemanı kontrol edilir.
                    if (i == satir)
                    {
                        //1'den büyükse çakışma vardır, değilse döngünün bu parçası atlanır
                        if (matris[satir,i] > 1)
                            isX = true;
                        else
                            continue;
                    }
                    //diğer sütunlarda çakışma varsa belirlenir
                    if (matris[satir, i] > 0)
                        isX = true;
                }
                //kale koyulan sütunda çakışan varsa isX true olur (çakışma olduğunu belirtir)
                for (int i = 0; i < 8; i++)
                {
                    //çakışma varsa diğer döngü kırılır
                    if (isX)
                        break;
                    //eğer sütun sayısı i ile eşitse matrisin elemanı kontrol edilir.
                    if (i == sutun)
                    {
                        //1'den büyükse çakışma vardır, değilse döngünün bu parçası atlanır
                        if (matris[i,sutun] > 1)
                            isX = true;
                        else
                            continue;
                    }
                    //diğer satırlarda çakışma varsa belirlenir
                    if (matris[i, sutun] > 0)
                        isX = true;
                }
                //eğer çakışma varsa koyulan kale kaldırılır
                if (isX)
                {
                    matris[satir, sutun]--;
                }
                int matrisToplami = 0;
                //matrisin tüm elemanları matrisToplamı değişkeninde toplanır
                for(int i=0;i<8;i++)
                {
                    for (int j = 0; j < 8; j++)
                        matrisToplami += matris[i, j];
                }
                //eğer toplam 8 olmuşsa (tüm kaleler yerleştirilmişse) işlem bitirilir
                if (matrisToplami == 8)
                    isDone = true;
            } while (!isDone);
        }
    }
}
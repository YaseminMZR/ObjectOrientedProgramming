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
using System.IO;
using System.Windows.Forms;

namespace Soru2
{
    public partial class Form1 : Form
    {
        TextBox[,] matris1Kutu = new TextBox[1,1];
        TextBox[,] matris2Kutu = new TextBox[1,1];
        TextBox[,] matrisSonuçKutu = new TextBox[1, 1];


        private void KutuOlustur(int matrisBoyutu)
        {
            //Matris elemanlarının yazılı olduğu textboxların groupboxlardan kaldırma işlemini yapıyor.
            foreach(TextBox item in matris1Kutu)
                this.matris1.Controls.Remove(item);
            foreach (TextBox item in matris2Kutu)
                this.matris2.Controls.Remove(item);
            foreach (TextBox item in matrisSonuçKutu)
                this.sonuçGroupBox.Controls.Remove(item);

            int boyut = matrisBoyutu+1;
            matris1Kutu = new TextBox[boyut, boyut];
            matris2Kutu = new TextBox[boyut, boyut];
            matrisSonuçKutu = new TextBox[boyut, boyut];
            int left = 20;
            int top = 75;

            // Seçilen matris boyutuna göre NxN'lik matrislerin elemanlarının yazılacağı textboxları oluşturur ve groupboxlara ekler.

            for (int i = 0; i < boyut; i++)
            {
                for (int k = 0; k < boyut; k++)
                {
                    matris1Kutu[i, k] = new TextBox();
                    matris1Kutu[i, k].Left = left;
                    matris1Kutu[i, k].Top = top;
                    matris1Kutu[i, k].Width = 35;
                    matris1Kutu[i, k].Text = "";
                    this.matris1.Controls.Add(matris1Kutu[i, k]);
                    left += 55;
                }
                top += 35;
                left = 20;
            }
            left = 20;
            top = 75;
            // Seçilen matris boyutuna göre NxN'lik matrislerin elemanlarının yazılacağı textboxları oluşturur ve groupboxlara ekler.

            for (int i = 0; i < boyut; i++)
            {
                for (int k = 0; k < boyut; k++)
                {
                    matris2Kutu[i, k] = new TextBox();
                    matris2Kutu[i, k].Left = left;
                    matris2Kutu[i, k].Top = top;
                    matris2Kutu[i, k].Width = 35;
                    matris2Kutu[i, k].Text = "";
                    this.matris2.Controls.Add(matris2Kutu[i, k]);
                    left += 55;
                }
                top += 35;
                left = 20;
            }
            left = 20;
            top = 75;

            // Seçilen matris boyutuna göre NxN'lik matrislerin elemanlarının yazılacağı textboxları oluşturur ve groupboxlara ekler.

            for (int i = 0; i < boyut; i++)
            {
                for (int k = 0; k < boyut; k++)
                {
                    matrisSonuçKutu[i, k] = new TextBox();
                    matrisSonuçKutu[i, k].Left = left;
                    matrisSonuçKutu[i, k].Top = top;
                    matrisSonuçKutu[i, k].Width = 35;
                    matrisSonuçKutu[i, k].Text = "";
                    this.sonuçGroupBox.Controls.Add(matrisSonuçKutu[i, k]);
                    left += 55;
                }
                top += 35;
                left = 20;
            }
        }

        public class matrisDeğerTut
        {
            
            public int boyut;
            public double[,] mtrs;

            public matrisDeğerTut(int _boyut)
            {
                boyut = _boyut;
                mtrs = new double[boyut,boyut];
            }

        };

        static class Matris
        {
            public static void Yaz(SaveFileDialog saveFileDialog, string text = "", bool elleSeç = false)
            {
                string path;

                //Dosya yolu elle seçmek istenilirse saveFileDialog ile seçim yaptırılır.

                if (elleSeç)
                {
                    saveFileDialog.Filter = "Text Dosyası |*.txt";
                    saveFileDialog.Title = "Dosya Dizini Seçin";
                    saveFileDialog.ShowDialog();
                    path = saveFileDialog.FileName;
                }

                //Varsayılan dosya yolu seçilir.

                else
                    path = "TextDosyası.txt";
                StreamWriter sw = new StreamWriter(path, append: true);
                sw.WriteLine(text);
                sw.Close();

                //Duruma göre ekrana mesaj bastırılır.

                if (elleSeç)
                    MessageBox.Show("Yazma İşlemi Başarılı");
                else
                    MessageBox.Show("Otomatik Kayıt Yapıldı");
            }

            public static void matrisYazdır(SaveFileDialog saveFileDialog, string text)
            {
                text += "Yazma İşlemi\n--------------------";
                Matris.Yaz(saveFileDialog, text, true);
            }

            public static void matrisOku(SaveFileDialog saveFileDialog,RichTextBox richTextBox,Label label)
            {
                saveFileDialog.Filter = "Text Dosyası |*.txt";
                saveFileDialog.Title = "Dosya Dizini Seçin";
                saveFileDialog.ShowDialog();
                StreamReader sr = new StreamReader(saveFileDialog.FileName);
                richTextBox.Text = sr.ReadToEnd();
                label.Text += saveFileDialog.FileName;
                sr.Close();
                MessageBox.Show("Okuma İşlemi Başarılı");
            }
            
            public static matrisDeğerTut matrisTopla(matrisDeğerTut matris1,matrisDeğerTut matris2,string text,SaveFileDialog saveFileDialog)
            {
                text += "Toplama İşlemi\n";
                matrisDeğerTut matris3 = new matrisDeğerTut(matris1.boyut);

                //Matris1 ve Matris2 nin toplamlarını Matris3'e yazar, aynı zamanda otomatik kayıt için matris3'ün içeriğini text'e yazar.

                for (int i = 0; i < matris1.boyut; i++)
                {
                    for (int j = 0; j < matris1.boyut; j++)
                    {
                        matris3.mtrs[i, j] = matris1.mtrs[i, j] + matris2.mtrs[i, j];
                        text += matris3.mtrs[i, j].ToString() + " ";
                    }
                    text += "\n";
                }
                text += "--------------------";
                Yaz(saveFileDialog, text);
                return matris3;
            }

            public static matrisDeğerTut matrisÇarp(matrisDeğerTut matris1, matrisDeğerTut matris2, string text, SaveFileDialog saveFileDialog)
            {
                text += "Çarpma İşlemi\n";
                matrisDeğerTut matris3 = new matrisDeğerTut(matris1.boyut);

                //Matris1 ve Matris2 nin çarpımlarını Matris3'e yazar.

                for (int i = 0; i < matris1.boyut; i++)
                {
                    for (int j = 0; j < matris1.boyut; j++)
                    {
                        for (int k = 0; k < matris1.boyut; k++)
                        {
                            matris3.mtrs[i,j] += matris1.mtrs[i,k] * matris2.mtrs[k,j];
                            
                        }
                    }
                }

               // Otomatik kayıt için matris3'ün içeriğini text'e yazar.
                for (int i = 0; i < matris3.boyut; i++)
                {
                    for (int j = 0; j < matris3.boyut; j++)
                    {
                        text += matris3.mtrs[i, j].ToString() + " ";
                    }
                    text += "\n";
                }
                text += "--------------------";
                Yaz(saveFileDialog, text);
                return matris3;
            }


            public static matrisDeğerTut matrisTersiAl(matrisDeğerTut matris,string text,SaveFileDialog saveFileDialog)
            {
                text += "Matrisin Tersini Al\n";

                matrisDeğerTut birimMatris = new matrisDeğerTut(matris.boyut);

                //Birim matrisi oluşturur.

                for (int i = 0; i < matris.boyut; i++)
                {
                    for (int j = 0; j < matris.boyut; j++)
                    {
                        if (i == j)
                            birimMatris.mtrs[i, j] = 1;
                        else
                            birimMatris.mtrs[i, j] = 0;
                    }
                }

                double değerTut, çarpımDeğeri;

                //Matris ve birim matris matrislerini birbirine çevirerek ters matrisi bulur.

                for (int i = 0; i < matris.boyut; i++)
                {
                    değerTut = matris.mtrs[i, i];

                    //Matrisin diogonal elemanlarını 1 olacak şekilde işleme sokar.

                    for (int j = 0; j < matris.boyut; j++)
                    {
                        matris.mtrs[i, j] = matris.mtrs[i, j] / değerTut;
                        birimMatris.mtrs[i, j] = birimMatris.mtrs[i, j] / değerTut;
                    }
                    //Diogonal olmayacak elemanları 0 olacak şekilde işleme sokar.

                    for (int y = 0; y < matris.boyut; y++)
                    {
                        if(y!=i)
                        {
                            çarpımDeğeri = matris.mtrs[y, i];
                            for (int z = 0; z < matris.boyut; z++)
                            {
                                matris.mtrs[y, z] = matris.mtrs[y, z] - (matris.mtrs[i, z] * çarpımDeğeri);
                                birimMatris.mtrs[y, z] = birimMatris.mtrs[y, z] - (birimMatris.mtrs[i, z] * çarpımDeğeri);
                            }
                        }
                    }
                }

                // Otomatik kayıt için birim matrisin içeriğini text'e yazar.

                for (int i = 0; i < birimMatris.boyut; i++)
                {
                    for (int j = 0; j < birimMatris.boyut; j++)
                    {
                        text += birimMatris.mtrs[i, j].ToString() + " ";
                    }
                    text += "\n";
                }
                text += "--------------------";
                Yaz(saveFileDialog, text);
                return birimMatris;
            }

            public static double matrisİzBul(matrisDeğerTut matris,string text, SaveFileDialog saveFileDialog)
            {
                text += "Matrisin İzini Bul\n";
                double iz = 0;

                //Matrisin köşegen elemanlarını toplar.

                for (int i = 0; i < matris.boyut; i++)
                {
                    for (int j = 0; j < matris.boyut; j++)
                    {
                        if (i == j)
                            iz += matris.mtrs[i, j];
                    }
                }
                text += iz.ToString()+"\n--------------------";
                Yaz(saveFileDialog, text);
                return iz;
            }
            public static matrisDeğerTut matrisTranspozBul(matrisDeğerTut matris, string text, SaveFileDialog saveFileDialog)
            {
                text += "Matrisin Transpozunu Bul\n";
                matrisDeğerTut sonuçMatris = new matrisDeğerTut(matris.boyut);

                //Matrisin transpozunu bulur ve otomatik kayıt için text'in içine yazar.
                for (int i = 0; i < matris.boyut; i++)
                {
                    for (int j = 0; j < matris.boyut; j++)
                    {
                        sonuçMatris.mtrs[i, j] = matris.mtrs[j, i];
                        text += sonuçMatris.mtrs[i, j].ToString() + " ";
                    }
                    text += "\n";
                }
                text +="--------------------";
                Yaz(saveFileDialog, text);
                return sonuçMatris;
            }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void matrisBoyut_SelectedIndexChanged(object sender, EventArgs e)
        {
            KutuOlustur(matrisBoyut.SelectedIndex);
        }

        private void devamEtButton_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();

            //Matrisi yazdır seçeneği seçildiğinde butonun ismi "Matrisi Yaz" olarak değişir ve 2. matris görünmez olur.
            if (matrisYazdir.Checked)
            {
                hesaplaButton.Text = "Matrisi Yaz";
                matris2.Visible = false;
            }

            //Matrisleri çarp seçeneği seçildiğinde butonun ismi "Matrisleri Çarp" olarak değişir.
            else if (matrisÇarp.Checked)
            {
                hesaplaButton.Text = "Matrisleri Çarp";
            }

            //Matrisleri topla seçeneği seçildiğinde butonun ismi "Matrisleri Topla" olarak değişir.
            else if (matrisTopla.Checked)
            {
                hesaplaButton.Text = "Matrisleri Topla";
            }

            //Matrisin Tersini Al seçeneği seçildiğinde butonun ismi "Matrisin Tersini Al" olarak değişir ve 2. matris görünmez olur.
            else if (matrisTersAl.Checked)
            {
                hesaplaButton.Text = "Matrisin Tersini Al";
                matris2.Visible = false;
            }

            //Matrisin izini bul seçeneği seçildiğinde butonun ismi "Matrisin İzini Bul" olarak değişir ve 2. matris görünmez olur.
            else if (matrisİzBul.Checked)
            {
                hesaplaButton.Text = "Matrisin İzini Bul";
                matris2.Visible = false;
            }

            //Matrisin transpozunu bul seçeneği seçildiğinde butonun ismi "Matrisin Transpozunu Bul" olarak değişir ve 2. matris görünmez olur.
            else if (matrisTranspoz.Checked)
            {
                hesaplaButton.Text = "Matrisin Transpozunu Bul";
                matris2.Visible = false;
            }

            // Matrisi Oku seçeneği seçildiğinde 3. panel ön plana gelir ve matrisOku fonksiyonu çağırılır.
            else if(matrisOkuma.Checked)
            {
                panel3.BringToFront();
                Matris.matrisOku(saveFileDialog1,richTextBox1,dosyaYolu);
            }
        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            int boyut = matrisBoyut.SelectedIndex + 1;
            string text = "";

            matrisDeğerTut matris1 = new matrisDeğerTut(boyut);

            //Matris1 elemanları TextBox'tan alınır ve otomotik kayıt için Text'e yazılır.
            for (int i = 0; i < matris1.boyut; i++)
            {
                for (int j = 0; j < matris1.boyut; j++)
                {
                    matris1.mtrs[i, j] = Double.Parse(matris1Kutu[i, j].Text);
                    text += matris1.mtrs[i, j].ToString() + " ";
                }
                text += "\n";
            }

            //Matris yazdır seçildiğinde matrisYazdır fonksiyonu çağırılır.
            if (matrisYazdir.Checked)
            {
                Matris.matrisYazdır(saveFileDialog1, text);
            }

            //Matris topla seçildiğinde matris toplama işlemleri yapılır.

            else if(matrisTopla.Checked)
            {
                text += "+\n";
                matrisDeğerTut matris2 = new matrisDeğerTut(boyut);

                //Matris2 elemanları TextBox'tan alınır ve otomotik kayıt için Text'e yazılır.
                for (int i = 0; i < matris2.boyut; i++)
                {
                    for (int j = 0; j < matris2.boyut; j++)
                    {
                        matris2.mtrs[i, j] = Double.Parse(matris2Kutu[i, j].Text);
                        text += matris2.mtrs[i, j].ToString() + " ";
                    }
                    text += "\n";
                }
                matrisDeğerTut matris3 = Matris.matrisTopla(matris1, matris2, text, saveFileDialog1);
                panelSonuç.BringToFront();

                //Matris3'ün elemanları sonuç textBoxlarına yazılır.
                for (int i = 0; i < matris3.boyut; i++)
                    for (int j = 0; j < matris3.boyut; j++)
                        matrisSonuçKutu[i, j].Text = matris3.mtrs[i, j].ToString();
            }

            //Matris Çarpma işlemleri seçildiğinde matris çarpma işlemleri yapılır.
            else if(matrisÇarp.Checked)
            {
                text += "*\n";
                matrisDeğerTut matris2 = new matrisDeğerTut(boyut);

                //Matris2 elemanları TextBox'tan alınır ve otomotik kayıt için Text'e yazılır.

                for (int i = 0; i < matris2.boyut; i++)
                {
                    for (int j = 0; j < matris2.boyut; j++)
                    {
                        matris2.mtrs[i, j] = Int32.Parse(matris2Kutu[i, j].Text);
                        text += matris2.mtrs[i, j].ToString() + " ";
                    }
                    text += "\n";
                }
                matrisDeğerTut matris3 = Matris.matrisÇarp(matris1, matris2, text, saveFileDialog1);
                panelSonuç.BringToFront();

                //Matris3'ün elemanları sonuç textBoxlarına yazılır.
                for (int i = 0; i < matris3.boyut; i++)
                    for (int j = 0; j < matris3.boyut; j++)
                        matrisSonuçKutu[i, j].Text = matris3.mtrs[i, j].ToString();
            }

            //Ters al işlemi gerçekleştirilir.

            else if (matrisTersAl.Checked)
            {
                matrisDeğerTut matris3 = Matris.matrisTersiAl(matris1, text, saveFileDialog1);
                panelSonuç.BringToFront();

                //Matris3'ün elemanları sonuç textBoxlarına yazılır.
                for (int i = 0; i < matris3.boyut; i++)
                    for (int j = 0; j < matris3.boyut; j++)
                        matrisSonuçKutu[i, j].Text = matris3.mtrs[i, j].ToString();
            }

            //Matrisin izi bulunur.
            else if(matrisİzBul.Checked)
            {
                SonuçLabel.Visible = true;
                SonuçLabel.Text+=Matris.matrisİzBul(matris1,text,saveFileDialog1);
            }
            //Matrisin transpozu bulunur.
            else if(matrisTranspoz.Checked)
            {
                matrisDeğerTut matris3 = Matris.matrisTranspozBul(matris1, text, saveFileDialog1);
                panelSonuç.BringToFront();

                //Matris3'ün elemanları sonuç textBoxlarına yazılır.
                for (int i = 0; i < matris3.boyut; i++)
                    for (int j = 0; j < matris3.boyut; j++)
                        matrisSonuçKutu[i, j].Text = matris3.mtrs[i, j].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tüm textBoxların içi boşaltılır.

            foreach (TextBox item in matris1Kutu)
                item.Text = "";
            foreach (TextBox item in matris2Kutu)
                item.Text = "";
            foreach (TextBox item in matrisSonuçKutu)
                item.Text = "";
            matrisBoyut.SelectedItem=null;
            dosyaYolu.Text = "Dosya Yolu :";
            richTextBox1.Text = "";
            SonuçLabel.Text = "Sonuç : ";
            panel1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

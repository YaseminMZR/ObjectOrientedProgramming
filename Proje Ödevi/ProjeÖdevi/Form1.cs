/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:Proje Ödevi
**				ÖĞRENCİ ADI............:Yasemin MUZIROĞLU
**				ÖĞRENCİ NUMARASI.......:B191210054
**              DERSİN ALINDIĞI GRUP...:1D
****************************************************************************/





using System;
using System.Windows.Forms;

namespace ProjeÖdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Random random = new Random();
        public static Meyve meyve;
        public static MeyveSıkacağı katıMeyveSıkacağı = new KatıMeyveSıkacağı();
        public static MeyveSıkacağı narenciyeSıkacağı = new NarenciyeMeyveSıkacağı();

        public static int sayac = 0;
        public static double gramaj = 0, vitaminA = 0, vitaminC = 0;

        public Meyve meyveSec()
        {
            int deger = random.Next(0, 6);
            Meyve meyve = null;
            // oluşturulan rastgele sayı ile (1-5 arası) rastgele bir meyve oluşturur
            switch(deger)
            {
                case 0:
                    meyve = new Portakal();
                    break;
                case 1:
                    meyve = new Mandalina();
                    break;
                case 2:
                    meyve = new Greyfurt();
                    break;
                case 3:
                    meyve = new Elma();
                    break;
                case 4:
                    meyve = new Armut();
                    break;
                case 5:
                    meyve = new Çilek();
                    break;
            }
            return meyve;
        }

        public void Devam()
        {
            meyve = meyveSec();
            meyvePictureBox.Image = meyve.resim;
            varsayılanDeger.Text = meyve.İlkDeğerAl();
            meyveDeğerleri.Text = meyve.DeğerAl();
            sure.Text = sayac.ToString();
            toplamGR.Text = gramaj.ToString();
            toplamVA.Text = vitaminA.ToString();
            toplamVC.Text = vitaminC.ToString();
            //meyvenin base sınıfının durumuna göre seçme butonlarının tıklanabilirliğini değiştirir
            if (meyve is SıkılabilirMeyve)
            {
                NarenciyeSeç.Enabled = true;
                KatıMeyveSeç.Enabled = false;
            }
            else
            {
                NarenciyeSeç.Enabled = false;
                KatıMeyveSeç.Enabled = true;
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            sure.Text = sayac.ToString();
            toplamGR.Text = gramaj.ToString();
            toplamVA.Text = vitaminA.ToString();
            toplamVC.Text = vitaminC.ToString();
        }

        private void NarenciyeSeç_Click(object sender, EventArgs e)
        {
            //eğer meyve sıkılabilir meyve ise meyveyi sıkıp dönen stringi bilgi kısmına yazar ve toplam değerleri güncelleyip Devam fonksiyonunu çağırır
            if(meyve is SıkılabilirMeyve)
            {
                narenciyeBilgi.Text = narenciyeSıkacağı.meyveSık(meyve);
                gramaj = narenciyeSıkacağı.meyveAğırlığı + katıMeyveSıkacağı.meyveAğırlığı;
                vitaminA = narenciyeSıkacağı.vitaminA + katıMeyveSıkacağı.vitaminA;
                vitaminC = narenciyeSıkacağı.vitaminC + katıMeyveSıkacağı.vitaminC;
                Devam();
            }
        }

        private void KatıMeyveSeç_Click(object sender, EventArgs e)
        {
            //eğer meyve katı meyve ise meyveyi sıkıp dönen stringi bilgi kısmına yazar ve toplam değerleri güncelleyip Devam fonksiyonunu çağırır
            if (meyve is KatıMeyve)
            {
                katımeyveBilgi.Text = katıMeyveSıkacağı.meyveSık(meyve);
                gramaj = narenciyeSıkacağı.meyveAğırlığı + katıMeyveSıkacağı.meyveAğırlığı;
                vitaminA = narenciyeSıkacağı.vitaminA + katıMeyveSıkacağı.vitaminA;
                vitaminC = narenciyeSıkacağı.vitaminC + katıMeyveSıkacağı.vitaminC;
                Devam();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sayac==60)
            {
                timer1.Stop();
                MessageBox.Show("OYUN BİTTİ !"); 
                KatıMeyveSeç.Enabled = false;
                NarenciyeSeç.Enabled = false;
                sayac = 0;
                başla.Text = "BAŞLA";
            }
            else
                sure.Text = (++sayac).ToString();
        }

        private void başla_Click(object sender, EventArgs e)
        {
            //eğer başla butonunun texti BAŞLA ise timer1'i başlatır, Devam fonksiyonunu çağırır ve butonun textini DUR olarak değiştirir
            if(başla.Text=="BAŞLA")
            {
                timer1.Start();
                Devam();
                başla.Text = "DUR";
            }
            //eğer başla butonunun texti DUR ise timer1'i durdurur, süreyi ve toplam değerleri sıfırlar, label ve image içlerini boşaltır, 
            //son olarak başla butonunun textini BAŞLA olarak değiştirir
            else if(başla.Text=="DUR")
            {
                timer1.Stop();
                sayac = 0;
                gramaj = 0;
                vitaminA = 0;
                vitaminC = 0;
                sure.Text = sayac.ToString();
                toplamGR.Text = gramaj.ToString();
                toplamVA.Text = vitaminA.ToString();
                toplamVC.Text = vitaminC.ToString();
                katımeyveBilgi.Text = "";
                narenciyeBilgi.Text = "";
                varsayılanDeger.Text = "";
                meyveDeğerleri.Text = "";
                meyvePictureBox.Image = null;
                başla.Text = "BAŞLA";
            }
        }
    }
}

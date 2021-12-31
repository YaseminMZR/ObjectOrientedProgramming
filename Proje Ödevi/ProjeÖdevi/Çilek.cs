using System.Drawing;

namespace ProjeÖdevi
{
    public class Çilek : KatıMeyve
    {
        public Çilek()
        {
            resim = Image.FromFile("Images/çilek.jpg");
            vitaminA = 12;
            vitaminC = 60;
            DeğerAta();
        }
        public override string İlkDeğerAl()
        {
            return "Gramaj(gr) : " + 100 + " Vitamin A(iu) : " + 12 + " Vitamin C(mg) : " + 60;
        }
    }
}

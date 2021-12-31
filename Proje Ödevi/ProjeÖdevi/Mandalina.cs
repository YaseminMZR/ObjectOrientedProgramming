using System.Drawing;

namespace ProjeÖdevi
{
    public class Mandalina : SıkılabilirMeyve
    {
        public Mandalina()
        {
            resim = Image.FromFile("Images/mandalina.png");
            vitaminA = 681;
            vitaminC = 26;
            DeğerAta();
        }
        public override string İlkDeğerAl()
        {
            return "Gramaj(gr) : " + 100 + " Vitamin A(iu) : " + 681 + " Vitamin C(mg) : " + 26;
        }
    }
}

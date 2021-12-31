using System.Drawing;

namespace ProjeÖdevi
{
    public class Greyfurt : SıkılabilirMeyve
    {
        public Greyfurt()
        {
            resim = Image.FromFile("Images/greyfurt.jpg");
            vitaminA = 3;
            vitaminC = 44;
            DeğerAta();
        }
        public override string İlkDeğerAl()
        {
            return "Gramaj(gr) : " + 100 + " Vitamin A(iu) : " + 3 + " Vitamin C(mg) : " + 44;
        }
    }
}

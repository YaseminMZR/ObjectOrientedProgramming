using System.Drawing;

namespace ProjeÖdevi
{
    public class Elma : KatıMeyve
    {
        public Elma() 
        {
            resim = Image.FromFile("Images/elma.jpg");
            vitaminA = 54;
            vitaminC = 5;
            DeğerAta();
        }
        public override string İlkDeğerAl()
        {
            return "Gramaj(gr) : " + 100 + " Vitamin A(iu) : " + 54 + " Vitamin C(mg) : " + 5;
        }
    }
}

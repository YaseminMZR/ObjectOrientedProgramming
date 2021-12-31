using System.Drawing;

namespace ProjeÖdevi
{
    public class Portakal : SıkılabilirMeyve
    {
        public Portakal()
        {
            resim = Image.FromFile("Images/portakal.jpg");
            vitaminA = 225;
            vitaminC = 45;
            DeğerAta();
        }
        public override string İlkDeğerAl()
        {
            return "Gramaj(gr) : " + 100 + " Vitamin A(iu) : " + 225 + " Vitamin C(mg) : " + 45;
        }
    }
}

using System.Drawing;

namespace ProjeÖdevi
{
    public class Armut : KatıMeyve
    {
        public Armut()
        {
            resim = Image.FromFile("Images/armut.jpg");
            vitaminA = 25;
            vitaminC = 5;
            DeğerAta();
        }

        public override string İlkDeğerAl()
        {
            return "Gramaj(gr) : " + 100 + " Vitamin A(iu) : " + 25 + " Vitamin C(mg) : " + 5;
        }
    }
}

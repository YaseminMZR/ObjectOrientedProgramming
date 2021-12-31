using System;
using System.Drawing;

namespace ProjeÖdevi
{
    public abstract class Meyve
    {
        public Image resim { get; set; }
        public double meyveAğırlığı { get; set; }
        public double vitaminA { get; set; }
        public double vitaminC { get; set; }
        public void DeğerAta()
        {
            meyveAğırlığı = Form1.random.Next(70, 120);
            vitaminA = (double)Math.Round(meyveAğırlığı * vitaminA / 100, 3);
            vitaminC = (double)Math.Round(meyveAğırlığı * vitaminC / 100, 3);
        }

        public string DeğerAl()
        {
            return "Gramaj(gr) : "+meyveAğırlığı+" Vitamin A(iu) : "+vitaminA + " Vitamin C(mg) : " + vitaminC;
        }

        public virtual string İlkDeğerAl() { return ""; }
    }
}

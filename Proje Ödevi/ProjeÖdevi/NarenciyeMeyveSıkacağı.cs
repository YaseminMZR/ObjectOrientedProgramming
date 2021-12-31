using System;

namespace ProjeÖdevi
{
    public class NarenciyeMeyveSıkacağı : MeyveSıkacağı
    {
        public override string meyveSık(Meyve meyve)
        {
            double vA = (double)Math.Round(meyve.vitaminA * Form1.random.Next(30, 70) / 100, 3);
            double vC = (double)Math.Round(meyve.vitaminC * Form1.random.Next(30, 70) / 100, 3);
            meyveAğırlığı += meyve.meyveAğırlığı;
            vitaminA += vA;
            vitaminC += vC;
            return "SON İŞLEM --> Gramaj : " + meyve.meyveAğırlığı + " Vitamin A : " + vA + " Vitamin C : " + vC;
        }
    }
}

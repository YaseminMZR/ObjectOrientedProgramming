namespace ProjeÖdevi
{
    public abstract class MeyveSıkacağı : ISıkacak
    {
        public double meyveAğırlığı { get; set; }
        public double vitaminA { get; set; }
        public double vitaminC { get; set; }

        public MeyveSıkacağı()
        {
            meyveAğırlığı = 0;
            vitaminA = 0;
            vitaminC = 0;
        }

        public virtual string meyveSık(Meyve meyve) { return ""; }

    }
}

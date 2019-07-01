namespace Hey.Math
{
    public class Vektor
    {
        public float x, y, z;

        public Vektor(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static float Vektor1_DogrusalInterpolasyon(float norm, float min, float max)
        {
            if (norm != 0)
            {
                norm = (max - min) * norm + min; // Yeni X
            }
            return norm; // Yeni Gecis Degeri
        }
        public static Vektor Vektor3_DogrusalInterpolasyon(float norm, Vektor min, Vektor max)
        {
            // Yeni Gecis Degeri
            return new Vektor((max.x - min.x) * norm + min.x, (max.y - min.y) * norm + min.y, (max.z - min.z) * norm + min.z);
        }
        private void PayDonusturucu(ref float ilkPay, string ilkPaydaMax, string ilkPaydaMin, float yeniPayda)
        {
            if (ilkPaydaMin.Length == 0 || ilkPaydaMin == "-") ilkPaydaMin = 0 + "";
            if (ilkPaydaMax.Length == 0 || ilkPaydaMax == "-") ilkPaydaMax = 1 + "";
            int max = int.Parse(ilkPaydaMax);
            int min = int.Parse(ilkPaydaMin);
            if (ilkPay < min) ilkPay = min;
            if (ilkPay > max) ilkPay = max;

            ilkPay += min * -1;
            max += min * -1;
            ilkPay = yeniPayda * ilkPay / max;
        }
    }
    public class HeyVektor { }
}
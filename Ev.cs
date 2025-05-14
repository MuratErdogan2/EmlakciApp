using System;

namespace Sube1.EmlakciLib
{
    public abstract class Ev
    {
        public static int Sayac { get; private set; }

        private string semt;
        private int odasayisi;
        private double alan;

        public string Buyukluk { get; private set; }

        public int Katno { get; set; }

        public string Semt
        {
            get => semt;
            set => semt = value.ToUpper();
        }

        public int Odasayisi
        {
            get => odasayisi;
            set => odasayisi = Math.Abs(value);
        }

        public double Alan
        {
            get { return alan; }
            set
            {
                if (value < 50)
                    throw new Exception("Min alan değeri 50 olmalıdır");
                alan = value;

                if (alan >= 50 && alan < 75)
                    Buyukluk = "Küçük Ev";
                else if (alan >= 75 && alan < 120)
                    Buyukluk = "Orta büyüklükte ev";
                else
                    Buyukluk = "Büyük ev";
            }
        }

        public Ev()
        {
            Sayac++;
        }

        public Ev(int odasayisi, int katno, double alan, string semt = "Kızılay") : this()
        {
            Odasayisi = odasayisi;
            Katno = katno;
            Semt = semt;
            Alan = alan;
        }

        protected string TemelEvBilgileri()
        {
            return $"Semt: {Semt}\nOda Sayısı: {Odasayisi}\nAlan: {Alan}\nBüyüklük: {Buyukluk}\nKat No: {Katno}";
        }

        // Abstract metod: override edilmek zorunda, gövdesiz
        public abstract string EvBilgileri();
    }
}
using Sube1.EmlakciLib;
namespace Sube1.EmlakciLib
{
    public class SatilikEv : Ev
    {
        public double Satisfiyat { get; set; }

        // Parametreli constructor
        public SatilikEv(double satisfiyat, int odasayisi, string semt, int katno, double alan)
            : base(odasayisi, katno, alan, semt)  // Base sınıf constructor çağrısı
        {
            Satisfiyat = satisfiyat;
        }

        // Parametresiz constructor (isteğe bağlı)
        public SatilikEv() : base() { }

        public override string EvBilgileri()
        {
            return $"{TemelEvBilgileri()}\nSatış Fiyatı: {Satisfiyat}";
        }
    }
}
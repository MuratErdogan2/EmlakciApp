using System;

namespace Sube1.EmlakciLib
{
    public class KiralikEv : Ev
    {
        public double Kira { get; set; }
        public double Depozito { get; set; }

        public KiralikEv(double kira, double depozito, int odasayisi, string semt, int katno, double alan)
            : base(odasayisi, katno, alan, semt)
        {
            Kira = kira;
            Depozito = depozito;
        }
        public override string EvBilgileri()
            {
                // base.EvBilgileri() yerine TemelEvBilgileri() kullanıyoruz
                return $"{TemelEvBilgileri()}\nKira: {Kira}\nDepozito: {Depozito}";
            }
        }
    }
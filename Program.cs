using Sube1.EmlakciLib;
using System;

namespace Sube1.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KiralikEv ke = new KiralikEv(500, 600, 3, "Kızılay", 100, 80);
            KiralikEv ke1 = new KiralikEv(800, 900, 2, "Çankaya", 120, 90);
            KiralikEv ke2 = new KiralikEv(10000, 10000, 4, "Yenimahalle", 200, 100);

            SatilikEv se = new SatilikEv(400, 3, "Mamak", 110, 60);
            SatilikEv se1 = new SatilikEv(700, 2, "Etimesgut", 120, 70);
            SatilikEv se2 = new SatilikEv(900, 4, "Sincan", 140, 80);

            Ev[] evler = { ke, ke1, ke2, se, se1, se2 };

            foreach (var ev in evler)
            {
                Console.WriteLine(ev.EvBilgileri());
                Console.WriteLine("------------------");
            }
        }
    }
}
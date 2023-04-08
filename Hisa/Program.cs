using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hisa
{

    class Hisa
    {
        private double povrsina;
        private string tip;
        private string lokacija;

        // za vse tri tipe, naredimo lastnosti

        public double Povrsina
        {
            get { return povrsina; } // get vrne trenutno vrednost podatka
            set { if (value > 0) povrsina = value; } // set pa nastavi vrednost
        }

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        public string Lokacija
        {
            get { return lokacija; }
            set { lokacija = value; }
        }

        // če mora izpisat stanje objekta, mora bit objektna metoda
        public void ToString()
        {
            Console.WriteLine("Lokacija: {0} Tip: {1} Površina: {2}", this.lokacija, this.tip, this.povrsina);
        }

        // zdaj pa treba naredit vse tri vrste KONSTRUKTORJE (vedno so public in vedno se imenuje kot razred)

        public Hisa()
        {
            Lokacija = "N/A";
            Tip = "N/A";
            Povrsina = 1;
        }

        // parametrični konstruktor
        public Hisa(string _l, string _t, double _p)
        {
            Lokacija = _l; // z veliko začetno črko se bo poklicala set metoda te lasnosti
            Tip = _t;
            Povrsina = _p;
        }

        //kopirni konstruktor
        public Hisa(Hisa _h)
        {
            Lokacija = _h.Lokacija;
            Tip = _h.Tip;
            Povrsina = _h.Povrsina;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Hisa h1 = new Hisa();
            h1.ToString();
            // klicemo konstruktor s parametri
            Hisa h2 = new Hisa("Ljubljana", "atrijska", 200);
            h2.ToString();
            // klicemo koprinega konstruktorja
            Hisa h3 = new Hisa(h2);
            h3.ToString();

            // polje/tabela/array
            Hisa[] hise = new Hisa[5]; // kreiranje table 5 objektov iz razreda Hisa
            for (int i = 0; i < hise.Length; i++)
            {
                Console.Write("Lokacija: ");
                string lokacija = Console.ReadLine();
                Console.Write("Tip: ");
                string tip = Console.ReadLine();
                Console.Write("Površina: ");
                double povrsina = double.Parse(Console.ReadLine());
                hise[i] = new Hisa(lokacija, tip, povrsina); // kreiranje posamičnih objektov (tipična izpitna naloga)

                
            }

            // ustvarimo dve sprejemljivke
            double najmanjsaPovrsina;
            Hisa najmanjsaHisa;
            // 
            najmanjsaPovrsina = hise[0].Povrsina; // najmanjša površine prve hiše
            najmanjsaHisa = hise[0]; // najmanjše hiše
            // (h) je lokalna sprejemljivka ki bo delovala samo v zanki (in gre po vrsti (1. hiša, 2.hiša itd.))
            // Hisa je narejena od objekta "Hiša[]"
            foreach (Hisa h in hise)
            {
                if (h.Povrsina < najmanjsaPovrsina) // primerjam ta elementa če je h - manjše od dosedanjega najmanjšega
                    //če je res:
                {
                    najmanjsaPovrsina = h.Povrsina; //tukaj se shrani povrsina hiše
                    najmanjsaHisa = h; // se shrani celotna hiša
                }
            }
            najmanjsaHisa.ToString();//  vse podatka o najmanšji hiši
        }
    }
}

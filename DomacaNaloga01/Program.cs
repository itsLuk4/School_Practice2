using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomacaNaloga01
{

    class Izdelek
    {

        //objekti
        public string naziv;
        public int cena;
        public int zaloga;

        //lasnosti
        public string Naziv
        {
            get { return naziv; }
            set { if (value.Length <= 100) naziv = value; }
        }

        public int Cena
        {
            get { return cena; }
            set { if (value > 0) cena = value; }
        }

        public int Zaloga
        {
            get { return zaloga; }
            set { if (value >= 0) zaloga = value; }
        }

        //konstruktorji
        public Izdelek()
        {
            Naziv = "N/A";
            Cena = 1;
            Zaloga = 1;
        }

        //parametrični konstruktor
        public Izdelek(string _n, int _c, int _z)
        {
            Naziv = _n;
            Cena = _c;
            Zaloga = _z;
        }

        // kopirni konstrutkor
        public Izdelek(Izdelek _i)
        {
            Naziv = _i.Naziv;
            Cena = _i.Cena;
            Zaloga = _i.Zaloga;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Izdelek[] izdelki = new Izdelek[10];

            izdelki[0] = new Izdelek("Izdelek 1", 10, 3);
            izdelki[1] = new Izdelek("Izdelek 2", 20, 6);
            izdelki[2] = new Izdelek("Izdelek 3", 30, 0);
            izdelki[3] = new Izdelek("Izdelek 4", 40, 8);
            izdelki[4] = new Izdelek("Izdelek 5", 50, 2);
            izdelki[5] = new Izdelek("Izdelek 6", 60, 9);
            izdelki[6] = new Izdelek("Izdelek 7", 70, 1);
            izdelki[7] = new Izdelek("Izdelek 8", 80, 7);
            izdelki[8] = new Izdelek("Izdelek 9", 90, 4);
            izdelki[9] = new Izdelek("Izdelek    10", 100, 5);

           

            foreach (Izdelek i in izdelki)
            {
                
               if ( i.Zaloga > 5)
                {
                    Console.WriteLine("{0} je na zalogi več kot 5", i.Naziv);
                }
                
            }
            
        }
    }
}

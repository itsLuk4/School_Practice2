using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulomek
{
    class Ulomek
    {
        private int st; //stevec
        private int im; //imenovalec
        //lastnosti St in Im
        public int St
        {
            get { return st; }
            set { st = value; }
        }
        
        public int Im
        {
            get { return im; }
            set { if (value != 0) im = value; }
        }

        public Ulomek() //privzeti konstruktor (izrazi bodo tudi na izpitu)
        {
            st = 1;
            im = 1;
        }

        public Ulomek(int _st, int _im) //pretvorbeni/parametrični konstruktor 20:00 video
        {
            st = _st;
            if (_im == 0)
                im = 1;
            else
                im = _im;
        }
        public Ulomek(Ulomek _u1) // konstruktor
        {
            st = _u1.st;
            im = _u1.im;
        }
        public void Izpisi() //objektna
        {
            if (this.im != 1)
                Console.WriteLine("{0}/{1}", this.st, this.im);
            else
                Console.WriteLine("{0}", this.st);
        }
        public static void Izpisi(Ulomek _ul) //statična metoda
        {
            if (_ul.im != 1)
                Console.WriteLine("{0}/{1}", _ul.st, _ul.im);
            else
                Console.WriteLine("{0}", _ul.st);
        }
        public static int najvecjiDelitelj(int a, int b)
        {
            while (true) //z "(true) naredimo neskončno zanko 1:05:00 video
            {
                if (b == 0) return a;
                int temp = a % b;
                a = b;
                b = temp;
            }
        }
        public void Okrajsaj()
        {
            //NSD = najvecji skupni delitelj
            int NSD = najvecjiDelitelj(this.st, this.im);
            this.st /= NSD;
            this.im /= NSD;
        }
        public static void Okrajsaj(Ulomek _ul)
        {
            int NSD = najvecjiDelitelj(_ul.st, _ul.im);
            _ul.st /= NSD;
            _ul.im /= NSD;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Ulomek ul1 = new Ulomek(); // privzeti konstruktor
            Console.WriteLine(ul1.ToString());
            ul1.Izpisi();       // klic objektne metode
            Ulomek ul2 = new Ulomek(5, 3); // parametrični konstruktor
            ul2.Izpisi();
            Ulomek ul3 = new Ulomek(6, 0);
            ul3.Izpisi();
            Ulomek ul4 = new Ulomek(ul2);  //kopirni konstruktor
            ul4.Izpisi();
            //klic statične metode: 40:00 video
            Ulomek.Izpisi(ul3);
            ul1.St = 19;
            ul1.Im = 0;
            ul1.Izpisi();
            Console.WriteLine(ul4.St); // avt.klic get metode lastnosti St 1:00:00 video
            // najvecji skupni delitelj
            Console.WriteLine(Ulomek.najvecjiDelitelj(12, 18));
            Ulomek ul5 = new Ulomek(12, 18);
            // klic objektne metode Okrajsaj
            ul5.Okrajsaj(); //objekt.Okrajsaj
            ul5.Izpisi();
            // klic statične metode Okrajsaj 1:28:00 video
            ul2.St = 30;
            ul2.Im = 45;
            Ulomek.Okrajsaj(ul2); //Ulomek.Okrajsaj(parameter)
            Ulomek.Izpisi(ul2);
        }
    }
}

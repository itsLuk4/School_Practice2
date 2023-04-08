using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DN02_Knjiga
{

    class Knjiga
    {

        public string naslov, avtor, letoIzdaje;

        //lastnosti
        public string Naslov
        {
            get { return naslov; }
            set { naslov = value; }

        }

        public string Avtor
        {
            get { return avtor; }
            set { avtor = value; }
        }

        public string LetoIzdaje
        {
            get { return letoIzdaje; }
            set { letoIzdaje = value; }
        }


        //konstruktorji
        //privzeti konstruktor
        public Knjiga()
        {
            Naslov = "N/A";
            Avtor = "N/A";
            LetoIzdaje = "N/A";
        }

        //parametrični
        public Knjiga(string _n, string _a, string _l)
        {
            Naslov = _n;
            Avtor = _a;
            LetoIzdaje = _l;
        }

        //kopirni konstrutor
        public Knjiga(Knjiga _k)
        {
            Naslov = _k.Naslov;
            Avtor = _k.Avtor;
            LetoIzdaje = _k.LetoIzdaje;
        }

        public void ToString()
        {
            Console.WriteLine("Podatki knjig:\nNaslov: {0} Avtor: {1} Leto Izdaje: {2}", this.Naslov, this.Avtor, this.LetoIzdaje);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Knjiga[] knjiga = new Knjiga[10];

            for (int i = 0; i < knjiga.Length; i++)
            {
                Console.Write("Vpisi naslov: ");
                string naslov = Console.ReadLine();
                Console.Write("Vpisi avtorja: ");
                string avtor = Console.ReadLine();
                Console.Write("Vpisi leto izdaje: ");
                string letoIzdaje = Console.ReadLine();
                knjiga[i] = new Knjiga(naslov, avtor, letoIzdaje);

            }

           Knjiga najstarejšaKnjiga = knjiga[0];

            foreach (Knjiga k in knjiga) 
            { 
                if (int.Parse(k.LetoIzdaje) > int.Parse(najstarejšaKnjiga.LetoIzdaje))        
                {
                    najstarejšaKnjiga = k;
                }
 
            }
            najstarejšaKnjiga.ToString();


        }
    }
}

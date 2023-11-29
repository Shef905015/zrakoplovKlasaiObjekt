using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaObjektZrakoplov
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Zrakoplov zrakoplov = new Zrakoplov();

            zrakoplov.ToString();

            zrakoplov.setNaziv("Airbus");
            zrakoplov.setSnagaMotora(2000);
            zrakoplov.setDosegleta(6000);

            Console.WriteLine(zrakoplov.ToString());

            Zrakoplov zrakoplov1 = new Zrakoplov("Cessna Skycatcher", 75, 870 );
            Zrakoplov zrakoplov2 = new Zrakoplov("Cessna Skycatcher", 75, 870);

            Console.ReadLine();
        }
    }
}

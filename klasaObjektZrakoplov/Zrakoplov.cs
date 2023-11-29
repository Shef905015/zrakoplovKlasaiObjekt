using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaObjektZrakoplov
{
    internal class Zrakoplov
    {
        string naziv;
        double snagaMotora;
        int dosegLeta;

        public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public void setSnagaMotora(double snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }
        public void setDosegleta(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }
        //------------------------------------------
        public string getNaziv()
        {
            return this.naziv;
        }
        public double getSnagaMotora()
        {
            return this.snagaMotora;
        }
        public int getDosegLeta()
        {
            return this.dosegLeta;
        }
        public override string ToString()
        {
            string ispis = "Naziv zrakoplova: " + this.getNaziv() + "\n"
            + "Snaga motora: " + this.getSnagaMotora() + "kW\n"
            + "Doseg leta: " + this.getDosegLeta() + "kM\n";
            return ispis;
        }

        public Zrakoplov() { }

    }
}

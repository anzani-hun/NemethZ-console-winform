using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CSV_adatbazissal
{
    class Dolgozo
    {
        // adatbázis fejléce: "nev","neme","reszleg","belepesev","ber"

        public string nev;
        public string neme;
        public string reszleg;
        public int belepesev;
        public int ber;


        //konstruktor generálása:
        public Dolgozo(string nev, string neme, string reszleg, int belepesev, int ber)
        {
            this.nev = nev;
            this.neme = neme;
            this.reszleg = reszleg;
            this.belepesev = belepesev;
            this.ber = ber;
        }
    }
}

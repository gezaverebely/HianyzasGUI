using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_10_S
{
    internal class Hianyzas
    {

        string nev;
        string osztaly;
        int hanyadika;
        int igazolt;
        int nemigazolt;
       

        public string Nev { get => nev; set => nev = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }
        public int Hanyadika { get => hanyadika; set => hanyadika = value; }
        public int Igazolt { get => igazolt; set => igazolt = value; }
        public int Nemigazolt { get => nemigazolt; set => nemigazolt = value; }
       

        public Hianyzas(string sor)
        {
            string[] darab = sor.Split(";");
            nev = darab[0];
            osztaly = darab[1];
            hanyadika = int.Parse(darab[2]);
            igazolt = int.Parse(darab[3]);
            nemigazolt = int.Parse(darab[4]);
            
        }

        public int NapiHianyzasSzamolas()
        {
            return igazolt + nemigazolt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvidencijaUcenika
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Razred { get; set; }

        public Ucenik(string line)
        {
            string[] podaci = line.Split('|');
            Ime = podaci[0];
            Prezime = podaci[1];
            Razred = podaci[2];
        }

        public Ucenik() { }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace EvidencijaUcenika
{
    public class Ucenici
    {
        private List<Ucenik> ucenici = new List<Ucenik>();

        public List<string> razredi = new List<string>();

        public Ucenici()
        {
            this.PreuzmiUcenike();
        }

        public void PreuzmiUcenike()
        {
            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath("~/ucenici.txt")))
            {
                try
                {
                    string line = sr.ReadLine();

                    while (!string.IsNullOrEmpty(line))
                    {
                        Ucenik ucenik = new Ucenik(line);
                        ucenici.Add(ucenik);
                        if (!razredi.Contains(ucenik.Razred))
                            razredi.Add(ucenik.Razred);
                        line = sr.ReadLine();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public List<Ucenik> Pretraga(Parametri parametri)
        {
            List<Ucenik> PronadjeniUcenici = new List<Ucenik>();
            foreach (Ucenik u in ucenici)
            {
                if ((parametri.Ime == "" || u.Ime.ToLower().Contains(parametri.Ime.ToLower())) &&
                    (parametri.Prezime == "" || u.Prezime.ToLower().Contains(parametri.Prezime.ToLower())) &&
                    (parametri.Razred == "" || u.Razred.ToLower().Contains(parametri.Razred.ToLower()))
                    )
                {
                    PronadjeniUcenici.Add(u);                
                }

            }

            return PronadjeniUcenici;

        }

       


    }
}
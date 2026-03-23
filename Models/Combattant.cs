using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiadoumsWeb.Models
{
    public class Combattant
    {
        public string Nom;
        public int PV;
        public int Degats;

        public Combattant(string nom, int pv, int degats)
        {
            Nom = nom;
            PV = pv;
            Degats = degats;
        }

        public bool EstVivant()
        {
            return PV > 0;
        }
    }
}
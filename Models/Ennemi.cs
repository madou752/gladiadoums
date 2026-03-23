using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiadoumsWeb.Models
{
    public class Ennemi : Combattant
    {
        public Ennemi(string nom, int pv, int degats) : base(nom, pv, degats)
        {
        }
    }
}
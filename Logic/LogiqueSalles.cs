using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GladiadoumsWeb.Models;

namespace GladiadoumsWeb.Logic
{
    public class LogiqueSalles
    {
        private Random random = new Random();

        public void AppliquerInfirmerie(Joueur joueur)
        {
            joueur.PV = 100;
        }

        public void AppliquerSalleMystere(Joueur joueur)
        {
            int sort = random.Next(0, 2);
            if (sort == 0)
            {
                joueur.Degats += 5;
            }
            else
            {
                joueur.PV -= 10;
            }
        }

        public void AppliquerBoutique(Joueur joueur)
        {
            if (joueur.Or >= 20)
            {
                joueur.Or -= 20;
                joueur.Degats += 2;
            }
        }
    }
}

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
            joueur.PV = joueur.PvMax;
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

        public void AcheterPotion(Joueur joueur)
        {
            if (joueur.Or >= 5)
            {
                joueur.Or -= 5;
                joueur.PV = Math.Min(joueur.PV + 50, joueur.PvMax); 
            }
        }

        public void AcheterAiguisage(Joueur joueur)
        {
            if (joueur.Or >= 10)
            {
                joueur.Or -= 10;
                joueur.Degats += 2;
            }
        }

        public void AcheterEntrainement(Joueur joueur)
        {
            if (joueur.Or >= 20)
            {
                joueur.Or -= 20;
                joueur.PvMax += 10;
                joueur.PV += 10;
            }
        }
    }
}

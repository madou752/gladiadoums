using GladiadoumsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiadoumsWeb.Logic
{
    public class MoteurCombat
    {
        private Random random = new Random();

        public string CalculerIssue(ActionCombat joueur, ActionCombat ennemi)
        {
            if (joueur == ennemi)
            {
                int tirage=random.Next(0, 2);
                if (tirage == 0)
                {
                    return "Egalite_Joueur";
                }
                else
                {
                    return "Egalite_Ennemi";
                }
            }
            if ((joueur == ActionCombat.Rapide && ennemi == ActionCombat.Puissante) ||
                (joueur == ActionCombat.Puissante && ennemi == ActionCombat.Garde) ||
                (joueur == ActionCombat.Garde && ennemi == ActionCombat.Rapide))
            {
                return "Gagné";
            }

            return "Perdu";
        }

        public bool TentativeMissEnnemi()
        {
            return random.Next(1, 101) <= 10;
        }

        public int CalculerDegats(int degatsDeBase)
        {
            double multiplicateur = random.Next(80, 121) / 100.0;
            return (int)Math.Round(degatsDeBase * multiplicateur);
        }

        public bool TentativeEsquiveJoueur(double chanceEsquive)
        {
            double jet = random.NextDouble() * 100.0;
            return jet <= chanceEsquive;
        }
    }
}

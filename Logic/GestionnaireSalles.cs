using GladiadoumsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiadoumsWeb.Logic
{
    public class GestionnaireSalles
    {
        private Random random = new Random();
        private int prochainSeuilSpecial;

        public GestionnaireSalles()
        {
            prochainSeuilSpecial = random.Next(4, 7);
        }

        public TypeSalle DeterminerTypeSalle(int scoreJoueur)
        {
            if (scoreJoueur > 0 && scoreJoueur % 10 == 0)
            {
                return TypeSalle.Boss;
            }

            if ((scoreJoueur + 1) % 10 == 0)
            {
                if (random.Next(0, 2) == 0)
                {
                    return TypeSalle.ReposBoss;
                }
            }

            if (scoreJoueur >= prochainSeuilSpecial)
            {
                prochainSeuilSpecial = scoreJoueur + random.Next(4, 7);
                return TirerTypeSalleSpeciale();
            }
            return TypeSalle.Combat;
        }

        private TypeSalle TirerTypeSalleSpeciale()
        {
            int tirage = random.Next(1, 4);

            if (tirage == 1)
            {
                return TypeSalle.Infirmerie;
            }
            else if (tirage == 2)
            {
                return TypeSalle.Shop;
            }
            else
            {
                return TypeSalle.Mystere;
            }
        }
    }
}

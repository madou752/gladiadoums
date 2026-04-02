using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiadoumsWeb.Models
{
    public class Joueur : Combattant
    {
        public int Or;
        public int Score;
        public int Combo;
        public double ChanceEsquive;
        public double BaseEsquive;
        
        public Joueur(string nom, int hp, int dmg) : base(nom, hp, dmg)
        {
            Or = 0;
            Score = 0;
            Combo = 0;
            ChanceEsquive = 5.0;
            BaseEsquive = 5.0;
            PvMax = hp;
        }
    }
}
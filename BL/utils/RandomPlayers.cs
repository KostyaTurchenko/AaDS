using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.utils
{
    public class RandomPlayers
    {
        public static Team Get_Team (string name, int k)
        {
            var ListPl = new List<Player>();

            var rand = new Random();
            for (int i = 0; i < k; i++)
            {
                var pl = new Player(rand.Next(25, 75));
                ListPl.Add(pl);
            }

            return new Team(name, ListPl);
        }


    }
}

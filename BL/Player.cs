using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Player : IComparable
    {

        public int Rating { get; set; }

        public Player (int r)
        {
            this.Rating = r;
        }

        public int CompareTo (object obj)
        {
            Player other_player = obj as Player;

            if (this.Rating == other_player.Rating)
                return 0;
            else if (this.Rating < other_player.Rating)
                return 1;
            else
                return -1;
        }
    }
}

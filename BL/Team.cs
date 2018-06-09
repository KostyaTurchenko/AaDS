using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class Team  
    {
        
        public string Name { get; set; }


        public int TeamReat
        {
            get
            {
                return get_team_reat();
            }
        }
                
        public List<Player> Players { get; set; }



        public Team(string name, List<Player> players)
        {
            
            this.Name = name;
            this.Players = players;
        }



        private int get_team_reat()
        {
            Players.Sort();
            return Players.Take(11).Sum(x => x.Rating);

            
        }

        public string show_information()
        {
            string output_str = Name + ": " + get_team_reat();
            return output_str;
        }




    }


}


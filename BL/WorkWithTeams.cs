using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WorkWithTeams
    {
        public Team[] Teams { get; set; }
        public WorkWithTeams(Team[] teams)
        {
            this.Teams = teams;
        }
        


        public Team[] SortOfTeams ()
        {
            
            int L = Teams.Length;
            for (int i = 1; i <= L - 1; i++)
                for (int j = L - 1; j >= i; j--)
                    if (Teams[j - 1].TeamReat < Teams[j].TeamReat)
                    {
                        Team t = Teams[j - 1];
                        Teams[j - 1] = Teams[j];
                        Teams[j] = t;
                    }
            return Teams;
        }



        public string ShowInformation (Team[] teams)
        {
            string[] str = new string[16];
            string output;
            for (int i = 0; i < 16; i++)
            {
                str[i] = teams[i].show_information();
            }
            output = String.Join("\n", str);
            return output;
        }
    }
}

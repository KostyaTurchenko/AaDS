using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.utils
{
    public class RandomTeamList
    {
        public static Team[] Get_Teams ()
        {
            List<string> names = new List<string>(16) { "Локомотив Москва", "ЦСКА Москва", "Спартак Москва", "Краснодар", "Зенит", "Уфа", "Арсенал Тула", "Динамо Москва", "Ахмат", "Рубин", "Ростов", "Урал", "Амкар", "Анжи", "Тосно", "СКА-Хабаровск" };

            Team[] TeamList = new Team[16];
            int n = 0;
            foreach (string name in names)
            {
                TeamList[n] = RandomPlayers.Get_Team(name, 25);
                System.Threading.Thread.Sleep(50);
                n++;
            }
            return TeamList;
        }
    }
}

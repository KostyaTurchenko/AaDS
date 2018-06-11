using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.recursion_2._27_
{
    public class Backpack
    {
        private List<Item> best_items = null;
        private double max_weight;
        private double best_price;

        public Backpack (double maxW)
        {
            this.max_weight = maxW;
        }

        private double CalcWeight (List<Item> items)
        {
            double sumW = 0;
            foreach (Item i in items)
            {
                sumW += i.Weigth;
            }
            return sumW;
        }

        private double CalcPrice (List<Item> items)
        {
            double sumP = 0;
            foreach (Item i in items)
            {
                sumP += i.Price;
            }
            return sumP;
        }

        private void CheckSet(List<Item> new_items)
        {
            if (best_items == null)
            {
                if (CalcWeight(new_items) <= max_weight)
                {
                    best_items = new_items;
                    best_price = CalcPrice(new_items);
                }
            }
            else
            {
                if (CalcWeight(new_items) <= max_weight && CalcPrice(new_items) >= best_price)
                {
                    best_items = new_items;
                    best_price = CalcPrice(new_items);
                }
            }

        }

        public void MakeAllSets(List<Item> items)
        {
            if (items.Count > 0)
                CheckSet(items);

            for (int i = 0; i < items.Count; i++)
            {
                List<Item> newSet = new List<Item>(items);

                newSet.RemoveAt(i);

                MakeAllSets(newSet);
            }

        }
        public List<Item> GetBestSet ()
        {
            return best_items;
        }

        public static List<Item> GetStartList ()
        {
            var items = new List<Item>();
            items.Add(new Item("Книга", 1, 600));
            items.Add(new Item("Бинокль", 2, 5000));
            items.Add(new Item("Аптечка", 4, 1500));
            items.Add(new Item("Ноутбук", 2, 40000));
            items.Add(new Item("Котелок", 1, 600));
            items.Add(new Item("Шашлык", 1, 2000));

            return items;
        }
    }
}

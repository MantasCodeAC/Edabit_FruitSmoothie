using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit_FruitSmoothie
{
    internal class Smoothie
    {
        public List<string> Ingredients;

        public Smoothie(List<string> ingredients)
        {
            Ingredients = ingredients;
        }

        public double GetCost()
        {
            double getcost = 0;
            foreach (var i in Ingredients)
            {
                switch (i)
                {
                    case "Strawberries":
                        getcost = getcost + 1.5;
                        break;
                    case "Banana":
                        getcost = getcost + 0.5;
                        break;
                    case "Mango":
                        getcost = getcost + 2.5;
                        break;
                    case "Blueberries":
                        getcost = getcost + 1.0;
                        break;
                    case "Raspberries":
                        getcost = getcost + 1.0;
                        break;
                    case "Apple":
                        getcost = getcost + 1.75;
                        break;
                    case "Pineapple":
                        getcost = getcost + 3.50;
                        break;    
                }
            }
            return getcost;
        }

        public decimal GetPrice(double getcost)
        {
            decimal getPrice= Convert.ToDecimal(getcost + (getcost * 1.5));
            getPrice = Math.Round(getPrice, 2);
            return getPrice;
        }

        public void GetName(List<string> Ingredients)
        {
            Ingredients.Sort();
            if (Ingredients.Count != Ingredients.Distinct().Count())
            {
                Ingredients.Add("Fusion");
            }
            else
            {
                Ingredients.Add("Smoothie");
            }
            Console.WriteLine("Kokteilio pavadinimas: ");
            foreach (var j in Ingredients)
            {
                Console.Write(j + " ");
            }
        }
    }
}

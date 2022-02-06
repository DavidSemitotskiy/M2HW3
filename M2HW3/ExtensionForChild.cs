using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public static class ExtensionForChild
    {
        public static Candy[] SearchDessertPorousCandy(this Child child)
        {
            Candy[] tempCandies = new Candy[0];
            for (int i = 0; i < child.Gift.Candies.Length; i++)
            {
                if (child.Gift.Candies[i] is PorousCandy)
                {
                    if (((PorousCandy)child.Gift.Candies[i]).IsDessert && ((PorousCandy)child.Gift.Candies[i]).IsPorous)
                    {
                        tempCandies = tempCandies.Add(child.Gift.Candies[i]);
                    }
                }
            }

            return tempCandies;
        }
    }
}

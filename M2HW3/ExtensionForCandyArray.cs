using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public static class ExtensionForCandyArray
    {
        public static Candy[] Add(this Candy[] arr, Candy candy)
        {
            if (arr == null)
            {
                return null;
            }

            if (candy == null)
            {
                return arr;
            }

            Candy[] newArrCandies = new Candy[arr.Length + 1];
            Array.Copy(arr, newArrCandies, arr.Length);
            newArrCandies[arr.Length] = candy;
            return newArrCandies;
        }

        public static Candy[] Delete(this Candy[] arr, string name)
        {
            if (arr == null)
            {
                return null;
            }

            if (name == null)
            {
                return arr;
            }

            int count = 0;
            Candy[] newArrCandies = new Candy[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i].Name == name)
                {
                    if (count == 0)
                    {
                        count++;
                        continue;
                    }
                }

                newArrCandies[j] = arr[i];
                j++;
            }

            return newArrCandies;
        }
    }
}

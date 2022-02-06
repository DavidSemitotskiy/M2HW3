using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public class Child
    {
        public Child(string name, IGift gift)
        {
            Name = name;
            Gift = gift;
        }

        public string Name { get; }
        public IGift Gift { get; }
        public void LookAtGift()
        {
            Gift.GetDescriptionGift();
        }

        public void EatCandy()
        {
            Random rand = new Random();
            Gift.DeleteCandy(Gift.Candies[rand.Next(Gift.Candies.Length)].Name);
        }

        public void PickUpGift()
        {
            Console.WriteLine($"По ощущениям вес подарка - {Gift.GetTotalWeight()}");
        }
    }
}

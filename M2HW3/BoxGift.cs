using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public class BoxGift : IGift
    {
        private Candy[] _candies;
        public BoxGift(Candy[] candies)
        {
            _candies = new Candy[candies.Length];
            Array.Copy(candies, _candies, candies.Length);
            TotalWeight = GetTotalWeight();
        }

        public Candy[] Candies
        {
            get => _candies;
        }

        public decimal TotalWeight { get; private set; }
        public void AddCandy(Candy candy)
        {
            _candies = _candies.Add(candy);
            TotalWeight = GetTotalWeight();
        }

        public void DeleteCandy(string name)
        {
            _candies = _candies.Delete(name);
            TotalWeight = GetTotalWeight();
        }

        public void GetDescriptionGift()
        {
            Console.WriteLine("Подарок в виде коробки");
            foreach (var candy in _candies)
            {
                Console.WriteLine(candy.GetDescription());
            }
        }

        public decimal GetTotalWeight()
        {
            return _candies.Sum(i => i.GetWeight());
        }
    }
}

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
            if (candies == null)
            {
                _candies = Array.Empty<Candy>();
                return;
            }

            _candies = new Candy[candies.Length];
            Array.Copy(candies, _candies, candies.Length);
        }

        public Candy[] Candies
        {
            get => _candies;
        }

        public decimal TotalWeight
        {
            get => _candies.Sum(i => i.GetWeight());
        }

        public void AddCandy(Candy candy)
        {
            _candies = _candies.Add(candy);
        }

        public void DeleteCandy(string name)
        {
            _candies = _candies.Delete(name);
        }

        public void GetDescriptionGift()
        {
            Console.WriteLine("Подарок в виде коробки");
            foreach (var candy in _candies)
            {
                Console.WriteLine(candy.GetDescription());
            }
        }
    }
}

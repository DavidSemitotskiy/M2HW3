using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public abstract class Candy : IComparable<Candy>
    {
        private decimal _weight;

        public Candy(string name, decimal price, decimal weight)
        {
            Name = name;
            Price = price;
            _weight = weight;
        }

        public string Name { get; }
        public decimal Price { get; }

        public decimal GetWeight()
        {
            return _weight;
        }

        public int CompareTo(Candy candy)
        {
            return Price.CompareTo(candy.Price);
        }

        public virtual string GetDescription()
        {
            return $"Название - {Name} : Цена - {Price} : Вес -  {_weight}";
        }
    }
}

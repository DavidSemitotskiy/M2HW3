using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public class DessertCandy : CandyWithAdditive
    {
        public DessertCandy(string name, decimal price, decimal weight, string stuffing, string additive, bool isDessert)
            : base(name, price, weight, stuffing, additive)
        {
            IsDessert = isDessert;
        }

        public bool IsDessert { get; }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} : Дессерт - {IsDessert}";
        }
    }
}

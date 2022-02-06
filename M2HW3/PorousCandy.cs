using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public class PorousCandy : DessertCandy
    {
        public PorousCandy(string name, decimal price, decimal weight, string stuffing, string additive, bool isDessert, bool isPorous)
            : base(name, price, weight, stuffing, additive, isDessert)
        {
            IsPorous = isPorous;
        }

        public bool IsPorous { get; }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} : Пористый - {IsPorous}";
        }
    }
}

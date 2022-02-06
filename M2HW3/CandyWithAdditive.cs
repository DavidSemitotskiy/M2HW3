using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public class CandyWithAdditive : СandyWithStuffing
    {
        public CandyWithAdditive(string name, decimal price, decimal weight, string stuffing, string additive)
            : base(name, price, weight, stuffing)
        {
            Additive = additive;
        }

        public string Additive { get; }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} : Добавка - {Additive}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public class СandyWithStuffing : Candy
    {
        public СandyWithStuffing(string name, decimal price, decimal weight, string stuffing)
            : base(name, price, weight)
        {
            Stuffing = stuffing;
        }

        public string Stuffing { get; }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} : Начинка - {Stuffing}";
        }
    }
}

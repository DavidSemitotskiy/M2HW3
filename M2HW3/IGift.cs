using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW3
{
    public interface IGift
    {
        Candy[] Candies { get; }
        decimal TotalWeight { get; }
        void AddCandy(Candy candy);
        void DeleteCandy(string name);
        void GetDescriptionGift();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone
{
    internal class Car
    {
        public Car Clone() 
        {
            return (Car)this.MemberwiseClone();
        }
    }
}

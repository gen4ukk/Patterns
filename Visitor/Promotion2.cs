using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Promotion2 : Visitor2
    {
        public override void VisitLaptop(Laptop2 laptop2)
        {
            laptop2.Cost = 1199;
            laptop2.Description = $"PROMOTIOM! {laptop2.Description}. BIG SALE. It cost only {laptop2.Cost}";
        }

        public override void VisitPhone(Phone2 phone2)
        {
            phone2.Cost = (int)(phone2.Cost * 0.4);
            phone2.Description = $"PROMOTIOM! {phone2.Description}. 40% DISCOUNT. It cost only {phone2.Cost}";
        }
    }
}

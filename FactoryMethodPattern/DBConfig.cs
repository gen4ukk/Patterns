using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class DBConfig
    {
        public string DBType { get; set; }
        public string DBConnection { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class UnpivotReport : AbstractReport
    {
        public UnpivotReport(IPrinter printer) : base(printer)
        {
           
        }

        public override void MakeReport(string text)
        {
            _body = $"Unpivot Report {text}";
        }
    }
}

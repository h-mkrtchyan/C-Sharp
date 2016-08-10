using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice ins = new Invoice(5423284, "Hakob", "Led.am")
            {
                Article = "laptop",
                Countity = 1
            };

            ins.CostCalculation(true);
        }
    }
}

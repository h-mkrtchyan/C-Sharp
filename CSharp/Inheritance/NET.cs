using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class NET
    {
        const string ADDRESS = "http:\\microsoft.com";
        public string level, inLevel;
        public int numberSt;
        //private string inf;

        public void InfoPW()
        {
            Console.WriteLine("Site: {0}\nPartition: {1}\nSub-Partition: {2}\nPost Qountity: {3}"
                , ADDRESS, level, inLevel, numberSt);
        }
    }
}

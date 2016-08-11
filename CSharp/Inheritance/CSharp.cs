using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class CSharp : NET
    {
        public string st;

        public CSharp(string level, string inLevel, int numberSt, string st)
        {
            this.level = level;
            this.inLevel = inLevel;
            this.numberSt = numberSt;
            this.st = st;
        }

        public void StWrite()
        {
            Console.WriteLine("Post: " + st);
        }
    }
}

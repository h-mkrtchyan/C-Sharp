using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharp obj = new CSharp(level: ".NET", inLevel: "OOP",
                numberSt: 3,
                st: "inheritance");
            obj.InfoPW();
            obj.StWrite();
        }
    }
}

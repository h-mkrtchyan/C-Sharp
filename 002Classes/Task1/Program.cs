using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter convertAmd = new Converter(475, 528, 7.3);
            convertAmd.ToUsd(54000);
            convertAmd.ToEur(54000);
        }
    }
}

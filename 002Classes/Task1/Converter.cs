using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void ToUsd(double amdSum)
        {
            Console.WriteLine(amdSum / usd);
        }

        public void FromUsd(double usdSum)
        {
            Console.WriteLine(usdSum * usd);
        }

        public void ToEur(double amdSum)
        {
            Console.WriteLine(amdSum / eur);
        }

        public void FromEur(double eurSum)
        {
            Console.WriteLine(eurSum * usd);
        }

        public void ToRub(double amdSum)
        {
            Console.WriteLine(amdSum / rub);
        }

        public void FromRub(double rubSum)
        {
            Console.WriteLine(rubSum * usd);
        }
    }
}

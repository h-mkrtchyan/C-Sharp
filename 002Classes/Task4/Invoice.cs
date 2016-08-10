using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Invoice
    {
        public readonly int account = 0;
        public readonly string customer = null;
        public readonly string provider = null;

        public string Article { get; set; }
        public int Countity { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CostCalculation(bool needNds)
        {
            double cost;
            switch(Article)
            {
                case "laptop": cost = 720;
                    break;
                case "SD-card": cost = 490;
                    break;
                case "USB-hub": cost = 12;
                    break;
                default: Console.WriteLine("Not Found");
                    return;
            }
            if (needNds)
            {
                cost = cost * 7 / 6;
            }
            Console.WriteLine("Sum payment: {0}$", cost * Countity);
        }
    }
}

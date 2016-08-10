using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Mkrtchyan", "Hakob");
            emp.Experience = 2;
            emp.Post = "Manager";
            emp.ShowSalary();
            emp.CountSalary();
        }
    }
}

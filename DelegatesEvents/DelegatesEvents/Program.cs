using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();   
        }

        private static void Start()
        {
            var canon = new Printer();
            canon.PrintStarted += Canon_PrintStarted;
            canon.Printing += Canon_Printing;
            canon.PrintFinished += Canon_PrintFinished;
            canon.PrintFailed += Canon_PrintFailed;

            var hp = new Printer();
            hp.PrintStarted += Canon_PrintStarted;
            hp.Printing += Canon_Printing;
            hp.PrintFinished += Canon_PrintFinished;
            hp.PrintFailed += Canon_PrintFailed;

            try
            {
                canon.AddPapers(4);
                canon.Print(2);
                canon.Print(3);
                Console.WriteLine("-------------------");
                hp.AddPapers(20);
                hp.Print(15);
                hp.Print(20);
            }
            catch(ArgumentOutOfRangeException exception)
            {
                Console.WriteLine($"OOPS! Wrong argument {exception.ParamName}.{Environment.NewLine} Message: {exception.Message}");
                throw new Exception("", exception);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }


        private static void Canon_PrintStarted(object sender, EventArgs e)
        {
            var printer = sender as Printer;
            Console.WriteLine($"{printer?.Name} print started...!");
        }
        private static void Canon_Printing(object sender, PrintingEventArgs e)
        {
            var printer = sender as Printer;
            Console.WriteLine($"{printer?.Name} printing page N{e.CurrentPage}");
        }
        private static void Canon_PrintFinished(object sender, EventArgs e)
        {
            var printer = sender as Printer;
            Console.WriteLine($"{ printer?.Name} successfully finished" );
        }
        
        private static void Canon_PrintFailed(object sender, PrintFailedEventArgs e)
        {
            var printer = sender as Printer;
            Console.WriteLine($"{printer?.Name} print failed and {e.RemainingPages} are remaining");
        }
    }
}

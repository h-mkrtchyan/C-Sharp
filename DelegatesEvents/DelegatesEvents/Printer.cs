using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    public class PrintingEventArgs : EventArgs
    {
        public int CurrentPage { get; set; }
    }

    public class PrintFailedEventArgs : EventArgs
    {
        public int RemainingPages { get; set; }
    }
    public class Printer
    {
        public string Name { get; private set; }

        public Printer()
        {
            Name = Guid.NewGuid().ToString();
        }

        public Printer(string name)
        {
            Name = name;
        }

        public event EventHandler PrintStarted;
        public event EventHandler PrintFinished;
        public event EventHandler<PrintingEventArgs> Printing;
        public event EventHandler<PrintFailedEventArgs> PrintFailed;

        private void OnPrintStarted()
        {
            PrintStarted?.Invoke(this, EventArgs.Empty);
        }

        private void OnPrintFinished()
        {
            PrintFinished?.Invoke(this, EventArgs.Empty);
        }

        private void OnPrinting(int current)
        {
            var args = new PrintingEventArgs { CurrentPage = current };
            Printing.Invoke(this, args);
        }

        private void OnPrintingFailed(int remaining)
        {
            var args = new PrintFailedEventArgs { RemainingPages = remaining };
            PrintFailed?.Invoke(this, args);
        }

        public int PapersQountity { get; private set; }

        public void AddPapers(int papersCount)
        {
            if(papersCount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(papersCount),
                    $"The argument of {nameof(papersCount)} can't be negative");
            }
            PapersQountity += papersCount;
        }

        public void Print(int pagesCount)
        {
            if(pagesCount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pagesCount),
                    $"The argument of {nameof(pagesCount)} should be greather than 0");
            }

            OnPrintStarted();

            for (int i = 1; i <= pagesCount; i++)
            {
                if (PapersQountity != 0)
                {
                    OnPrinting(i);
                    PapersQountity--;
                }
                else
                {
                    OnPrintingFailed(pagesCount - i + 1);
                    break;
                }
            }

            OnPrintFinished();
        }
    }
}

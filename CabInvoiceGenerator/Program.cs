using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double Fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Total Fare is : " +Fare);
            Console.ReadLine();
        }
    }
}

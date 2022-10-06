using System.IO;

namespace Genrator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine("Total fare for normal ride is " + fare);

            InvoiceGenerator invoiceGenerator1 = new InvoiceGenerator(RideType.PREMIUM);
            double fare1 = invoiceGenerator1.CalculateFare(2.0, 5);
            Console.WriteLine("Total fare for premium ride is " + fare1);
        }
    }
}
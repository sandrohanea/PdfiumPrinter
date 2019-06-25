using System;
using System.Drawing.Printing;

namespace PdfiumPrinter.Demo
{
    class Program
    {
        private const string printFile = "C:\\Users\\Sandro\\Documents\\test.pdf";

        static void Main(string[] args)
        {
            var printer = new PdfPrinter("Microsoft Print to PDF");
            printer.Print(printFile);
            Console.ReadKey();
            
        }
    }
}

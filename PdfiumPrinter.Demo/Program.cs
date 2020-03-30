using System;

namespace PdfiumPrinter.Demo
{
    class Program
    {
        private const string printFile = "sha1good.pdf";

        static void Main(string[] args)
        {
            var printer = new PdfPrinter("Microsoft Print to PDF");
            printer.Print(printFile);
            Console.WriteLine("The file was succesfully printed.");
            Console.ReadKey();
        }
    }
}

using System;

namespace PdfiumPrinter.Demo
{
    class Program
    {
        private const string printFile = "sha1good.pdf";

        static void Main(string[] args)
        {
            PrintToPrinter(printFile);
            Console.ReadKey();
        }

        public static void PrintToImage(string fileName)
        {
            using var pdfDocument = PdfDocument.Load(fileName);
            using var image = pdfDocument.Render(0, 200, 200, false);
            // Use the image based on your needs
            Console.WriteLine("The image was successfully created.");
        }

        public static void PrintToPrinter(string fileName, string documentName = null)
        {
            var printer = new PdfPrinter("Microsoft Print To PDF");
            printer.Print(fileName, documentName: documentName);
            Console.WriteLine("The files were succesfully printed.");
        }
    }
}

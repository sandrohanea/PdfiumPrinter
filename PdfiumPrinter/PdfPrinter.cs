using System.Drawing.Printing;
using System.IO;

namespace PdfiumPrinter
{
    public class PdfPrinter
    {
        public PdfPrinter(string printerName = null)
        {
            Settings = new PrinterSettings()
            {
                PrinterName = printerName
            };
            PageSettings = new PageSettings()
            {
                Margins = new Margins(0, 0, 0, 0)
            };
        }

        public void Print(PdfDocument pdfDocument, short copies = 1)
        {

            this.Settings.Copies = copies;
            using (var printDocument = pdfDocument.CreatePrintDocument())
            {
                printDocument.PrinterSettings = Settings;
                printDocument.DefaultPageSettings = PageSettings;
                printDocument.PrintController = new StandardPrintController();
                printDocument.Print();
            }
        }

        public void Print(Stream fileStream, short copies = 1)
        {
            this.Settings.Copies = copies;
            using (var document = PdfDocument.Load(fileStream))
            {
                using (var printDocument = document.CreatePrintDocument())
                {
                    printDocument.PrinterSettings = Settings;
                    printDocument.DefaultPageSettings = PageSettings;
                    printDocument.PrintController = new StandardPrintController();
                    printDocument.Print();
                }
            }
        }

        public void Print(string fileName, short copies = 1)
        {
            this.Settings.Copies = copies;
            // Now print the PDF document
            using (var document = PdfDocument.Load(fileName))
            {
                using (var printDocument = document.CreatePrintDocument())
                {
                    printDocument.PrinterSettings = Settings;
                    printDocument.DefaultPageSettings = PageSettings;
                    printDocument.PrintController = new StandardPrintController();
                    printDocument.Print();
                }
            }
        }

        public PageSettings PageSettings { get; }
        public PrinterSettings Settings { get; }

    }
}

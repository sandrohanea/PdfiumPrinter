using System.Drawing.Printing;
using System.IO;

namespace PdfiumPrinter
{
    public class PdfPrinter
    {
        /// <summary>
        /// Initializes a new instance of the <seealso cref="PdfPrinter"/>, which can be used to print pdf files to the specified printer.
        /// </summary>
        /// <param name="printerName">The name of the printer which will be used.</param>
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

        /// <summary>
        /// Will print a file read from the stream using the specified printer previously defined.
        /// </summary>
        /// <param name="fileStream">The file stream to be printed.</param>
        /// <param name="copies">The number of copies to be printed, default 1.</param>
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

        /// <summary>
        /// Will print the file specified by a path using the printer priviously defined.
        /// </summary>
        /// <param name="fileName">The PDF file path to be printed.</param>
        /// <param name="copies">The number of copies to be printed, default 1.</param>
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

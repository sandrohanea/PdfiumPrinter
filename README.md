# PdfiumPrinter
Open-Source PdfiumPrinter

For this to work will be needed one of the following libraries NuGet packages:
PdfiumViewer.Native.x86_64.v8-xfa
PdfiumViewer.Native.x86.v8-xfa
PdfiumViewer.Native.x86.no_v8-no_xfa
PdfiumViewer.Native.x86_64.no_v8-no_xfa

Usage:
    var printer = new PdfPrinter("Microsoft Print to PDF");
    printer.Print(printFile);
	
# PdfiumPrinter
A small library for printing pdf files.
This was adapted to netstandard from [PdfiumViewer](https://github.com/pvginkel/PdfiumViewer) using Pdfium by google

## Getting started
To install PdfiumPrinter, run the following command in the [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console):

    PM> Install-Package PdfiumPrinter
	
Additionally, you'll have to install ONE of the following NuGet Packages(based on your needs):
[PdfiumViewer.Native.x86_64.v8-xfa](https://www.nuget.org/packages/PdfiumViewer.Native.x86_64.v8-xfa/)
[PdfiumViewer.Native.x86.v8-xfa](https://www.nuget.org/packages/PdfiumViewer.Native.x86.v8-xfa/)
[PdfiumViewer.Native.x86.no_v8-no_xfa](https://www.nuget.org/packages/PdfiumViewer.Native.x86.no_v8-no_xfa/)
[PdfiumViewer.Native.x86_64.no_v8-no_xfa](https://www.nuget.org/packages/PdfiumViewer.Native.x86_64.no_v8-no_xfa/)

# Usage
	var printerName = "Microsoft Print to PDF"; //You can use your own printer;
	var printer = new PdfPrinter(printerName);
	var printFile = "somePdf.pdf"; //The path to the pdf which needs to be printed;
    printer.Print(printFile);

	Additionally, you can specify the number of copies, or a stream for a pdf file.
	

## Documentation
You can find the documentation and code samples here: [https://github.com/sandrohanea/PdfiumPrinter/](https://github.com/sandrohanea/PdfiumPrinter/)

## License
Apache-2.0
[https://licenses.nuget.org/Apache-2.0](https://licenses.nuget.org/Apache-2.0)
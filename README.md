# PdfiumPrinter
Open-Source PdfiumPrinter
This was adapted to netstandard from https://github.com/pvginkel/PdfiumViewer using Pdfium by google
For this to work will be needed one of the following libraries NuGet packages:
PdfiumViewer.Native.x86_64.v8-xfa
PdfiumViewer.Native.x86.v8-xfa
PdfiumViewer.Native.x86.no_v8-no_xfa
PdfiumViewer.Native.x86_64.no_v8-no_xfa

Usage:
    var printer = new PdfPrinter("Microsoft Print to PDF");
    printer.Print(printFile);

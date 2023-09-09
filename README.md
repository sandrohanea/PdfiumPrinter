# PdfiumPrinter
Open-Source PdfiumPrinter

For this to work will be needed one of the following libraries NuGet packages:
bblanchon.PDFium.Win32
bblanchon.PDFiumV8.Win32

# PdfiumPrinter
A small library for printing pdf files.
This was adapted to netstandard from [PdfiumViewer](https://github.com/pvginkel/PdfiumViewer) using Pdfium by google
Also upgraded to latest version of pdfium.


# Usage
```

	var printerName = "Microsoft Print to PDF"; //You can use your own printer;
	var printer = new PdfPrinter(printerName);
	var printFile = "somePdf.pdf"; //The path to the pdf which needs to be printed;
    printer.Print(printFile);

```
	Additionally, you can specify the number of copies, or a stream for a pdf file.
	
## Getting started
To install PdfiumPrinter, run the following command in the [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console):

    PM> Install-Package PdfiumPrinter

or simply add a package reference in your csproj:
```
    <PackageReference Include="PdfiumPrinter" Version="1.4.0" />
```

	
Additionally, you'll have to install ONE of the following NuGet Packages(based on your needs):
[bblanchon.PDFium.Win32](https://www.nuget.org/packages/bblanchon.PDFium.Win32/)
[bblanchon.PDFiumV8.Win32](https://www.nuget.org/packages/bblanchon.PDFiumV8.Win32/)


## Custom Library Loader
Alternatively, you may opt to bring your own runtime and implement a custom library loader. See [https://github.com/sandrohanea/PdfiumPrinter/](https://github.com/sandrohanea/PdfiumPrinter/blob/master/PdfiumPrinter/LibraryLoader/ILibraryLoader.cs)

You can load your own library (before loading any PDF) by:
```
    using PdfiumPrinter.LibraryLoader;

    ...

    NativeLibraryLoader.SetLibraryLoader(new MyCustomLoader());

    ...
    var printer = new PdfPrinter(printerName);
    ...
```


## Documentation
You can find the documentation and code samples here: [https://github.com/sandrohanea/PdfiumPrinter/](https://github.com/sandrohanea/PdfiumPrinter/)

## License
Apache-2.0
[https://licenses.nuget.org/Apache-2.0](https://licenses.nuget.org/Apache-2.0)

## Platform support
Even if the library can be loaded on a variaty of platforms: Windows X64, X86, ARM64, MacOS X64, MacOS Arm64, Linux X64, most of the operations are only supported on Windows. 

This is because [System.Drawing.Common is Windows Only](https://learn.microsoft.com/en-gb/dotnet/core/compatibility/core-libraries/6.0/system-drawing-common-windows-only)

For other OS, you will be able to load a PDF, search in it, remove pages, add pages and even store a copy of it, but printing and rendering is using System.Drawing.Common

Additional work is needed to migrate the graphics to something different e.g. [SkiaSharp](https://github.com/mono/SkiaSharp) which is cross-platform.
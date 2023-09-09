namespace PdfiumPrinter.LibraryLoader;

public interface ILibraryLoader
{
    LoadResult OpenLibrary(string fileName);
}

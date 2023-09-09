using System;
using PdfiumPrinter.LibraryLoader;

namespace PdfiumPrinter
{
    public class PdfLibrary : IDisposable
    {
        private static readonly object _syncRoot = new object();
        private static PdfLibrary _library;

        public static void EnsureLoaded(string libraryPath = null, bool bypassLoading = false)
        {
            lock (_syncRoot)
            {
                if (_library == null)
                {
                    _library = new PdfLibrary(libraryPath, bypassLoading);
                }
            }
        }

        private bool _disposed;

        private PdfLibrary(string libraryPath, bool bypassLoading)
        {
            NativeLibraryLoader.LoadNativeLibrary(libraryPath, bypassLoading);
            NativeMethods.FPDF_InitLibrary();
        }

        ~PdfLibrary()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            
            NativeMethods.FPDF_DestroyLibrary();

            _disposed = true;
        }
    }
}

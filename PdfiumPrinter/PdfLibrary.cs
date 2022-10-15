using System;

namespace PdfiumPrinter
{
    internal class PdfLibrary : IDisposable
    {
        private static readonly object _syncRoot = new object();
        private static PdfLibrary _library;

        public static void EnsureLoaded()
        {
            lock (_syncRoot)
            {
                if (_library == null)
                {
                    _library = new PdfLibrary();
                }
            }
        }

        private bool _disposed;

        private PdfLibrary()
        {
            if (NativeMethods.IsNativePdfium)
            {
                NativeMethods.FPDF_InitLibrary();
            }
            else
            {
                NativeMethods.FPDF_AddRef();
            }
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
            
            if (NativeMethods.IsNativePdfium)
            {
                NativeMethods.FPDF_DestroyLibrary();
            }
            else
            {
                NativeMethods.FPDF_Release();
            }

            _disposed = true;
        }
    }
}

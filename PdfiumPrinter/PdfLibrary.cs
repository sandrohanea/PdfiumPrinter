﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

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
                    _library = new PdfLibrary();
            }
        }

        private bool _disposed;

        private PdfLibrary()
        {
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
            if (!_disposed)
            {
                NativeMethods.FPDF_DestroyLibrary();

                _disposed = true;
            }
        }
    }
}

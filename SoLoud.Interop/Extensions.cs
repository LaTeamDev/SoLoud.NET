using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SoLoud.Interop;

public static class Extensions {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfError(this SOLOUD_ERRORS error) {
        switch (error) {
            case SOLOUD_ERRORS.SO_NO_ERROR:
                return;
            case SOLOUD_ERRORS.INVALID_PARAMETER:
                throw new ArgumentException();
            case SOLOUD_ERRORS.FILE_NOT_FOUND:
                throw new FileNotFoundException();
            case SOLOUD_ERRORS.FILE_LOAD_FAILED:
                throw new FileLoadException();
            case SOLOUD_ERRORS.DLL_NOT_FOUND:
                throw new DllNotFoundException();
            case SOLOUD_ERRORS.OUT_OF_MEMORY:
                throw new OutOfMemoryException();
            case SOLOUD_ERRORS.NOT_IMPLEMENTED:
                throw new NotImplementedException();
            case SOLOUD_ERRORS.UNKNOWN_ERROR:
            default:
                throw new Exception("Unknown Exception");
        }
    }
}
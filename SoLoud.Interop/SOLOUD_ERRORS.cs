namespace SoLoud.Interop;

[NativeTypeName("unsigned int")]
public enum SOLOUD_ERRORS : uint
{
    SO_NO_ERROR = 0,
    INVALID_PARAMETER = 1,
    FILE_NOT_FOUND = 2,
    FILE_LOAD_FAILED = 3,
    DLL_NOT_FOUND = 4,
    OUT_OF_MEMORY = 5,
    NOT_IMPLEMENTED = 6,
    UNKNOWN_ERROR = 7,
}

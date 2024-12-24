namespace SoLoud;

public abstract unsafe class SoLoudObject {
    internal readonly void** _handle;
    
    public SoLoudObject(void** handle) {
        _handle = handle;
    }
    
    public override int GetHashCode() => (int)_handle;
    
    public static implicit operator void**(SoLoudObject o) => o._handle;
}
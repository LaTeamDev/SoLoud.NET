using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace SoLoud;

public unsafe class VoiceGroup(uint handle, SoLoud? soloud = null) : IDisposable {
    public readonly uint Handle = handle;
    [MaybeNull]
    private SoLoud _soLoud = soloud;
    
    public static implicit operator uint(VoiceGroup o) => o.Handle;
    public static implicit operator VoiceGroup(uint o) => new(o);

    public void Dispose() {
        _soLoud?.DestroyVoiceGroup(this);
    }

    public void Add(Voice voice) => _soLoud?.AddVoiceToGroup(this, voice);

    public bool Valid => _soLoud.IsValidVoiceGroup(this);
    public bool Empty => _soLoud.IsVoiceGroupEmpty(this);
}
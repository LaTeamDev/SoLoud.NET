using System;
using System.IO;
using SoLoud.Interop;

namespace SoLoud;

public unsafe class WavStream(void** handle) : AudioSource(handle), IDisposable {
    public WavStream() : this(WavStream_create()) {}

    public static Wav Load(string filename) {
        var wav = new Wav();
        fixed (char* ptr = filename)
            ((SOLOUD_ERRORS)WavStream_load(wav, (sbyte*) ptr)).ThrowIfError();
        return wav;
    }

    /// <summary>
    /// SoLoud function assumes that the pointer and the data pointed will be valid as long as SoLoud needs them.
    /// You can use the aCopy parameter to tell SoLoud to take a copy of the data instead of using the pointers
    /// directly, and the aTakeOwnership parameter to tell SoLoud to free the pointer when the object is being
    /// destroyed.
    /// </summary>
    public static WavStream LoadFromMemory(byte* mem, int length, bool copy, bool takeOwnership) {
        var wav = new WavStream(); 
        ((SOLOUD_ERRORS)WavStream_loadMemEx(wav, mem, (uint)length, copy?1:0, takeOwnership?1:0)).ThrowIfError();
        return wav;
    }
    public static WavStream LoadFromMemory(byte[] array) {
        fixed (byte* ptr = array)
            return LoadFromMemory(ptr, array.Length, true, false);
    }

    public static WavStream LoadFromStream(Stream stream) {
        using var ms = new MemoryStream();
        stream.CopyTo(ms);
        return LoadFromMemory(ms.ToArray());
    }

    public void Dispose() {
        WavStream_destroy(this);
    }

    public override bool Loop {
        set => WavStream_setLooping(this, value?1:0);
    }

    public override void SetFilter(uint filterId, Filter filter) =>
        WavStream_setFilter(this, filterId, filter);

    public override void SetMinMaxDistance3D(float minDistance, float maxDistance) =>
        WavStream_set3dMinMaxDistance(this, minDistance, maxDistance);

    public override void SetAttenuation3D(SoLoudAttenuationModel model, float rolloffFactor) =>
        WavStream_set3dAttenuation(this, (uint) model, rolloffFactor);

    public override float DopplerFactor3D {
        set => WavStream_set3dDopplerFactor(this, value);
    }

    public override bool ListenerRelative3D {
        set => WavStream_set3dListenerRelative(this, value?1:0);
    }

    public override bool DistanceDelay3D {
        set => WavStream_set3dDistanceDelay(this, value?1:0);
    }

    public override void SetCollider3D(AudioCollider collider, int userData) {
        WavStream_set3dColliderEx(this, collider, userData);
    }

    public override AudioAttenuator Attenuator3D {
        set => WavStream_set3dAttenuator(this, value);
    }

    public override void SetInaudibleBehavior(bool mustTick, bool kill) {
        WavStream_setInaudibleBehavior(this, mustTick?1:0, kill?1:0);
    }

    public override float Volume {
        set => WavStream_setVolume(this, value);
    }
}
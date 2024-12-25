using System;
using System.IO;
using SoLoud.Interop;

namespace SoLoud;

public unsafe class Wav(void** handle) : AudioSource(handle), IDisposable {
    public Wav() : this(Wav_create()) {}

    public static Wav Load(string filename) {
        var wav = new Wav();
        fixed (char* ptr = filename)
            ((SOLOUD_ERRORS)Wav_load(wav, (sbyte*) ptr)).ThrowIfError();
        return wav;
    }

    /// <summary>
    /// SoLoud function assumes that the pointer and the data pointed will be valid as long as SoLoud needs them.
    /// You can use the aCopy parameter to tell SoLoud to take a copy of the data instead of using the pointers
    /// directly, and the aTakeOwnership parameter to tell SoLoud to free the pointer when the object is being
    /// destroyed.
    /// </summary>
    public static Wav LoadFromMemory(byte* mem, int length, bool copy, bool takeOwnership) {
        var wav = new Wav(); 
        ((SOLOUD_ERRORS)Wav_loadMemEx(wav, mem, (uint)length, copy?1:0, takeOwnership?1:0)).ThrowIfError();
        return wav;
    }

    public static Wav LoadFromMemory(byte[] array, bool copy, bool takeOwnership) {
        fixed (byte* ptr = array)
            return LoadFromMemory(ptr, array.Length, copy, takeOwnership);
    }

    public static Wav LoadFromStream(Stream stream) {
        using var ms = new MemoryStream();
        stream.CopyTo(ms);
        return LoadFromMemory(ms.ToArray(), false, false);
    }

    public void Dispose() {
        Wav_destroy(this);
    }

    public override bool Loop {
        set => Wav_setLooping(this, value?1:0);
    }

    public override void SetFilter(uint filterId, Filter filter) =>
        Wav_setFilter(this, filterId, filter);

    public override void SetMinMaxDistance3D(float minDistance, float maxDistance) =>
        Wav_set3dMinMaxDistance(this, minDistance, maxDistance);

    public override void SetAttenuation3D(SoLoudAttenuationModel model, float rolloffFactor) =>
        Wav_set3dAttenuation(this, (uint) model, rolloffFactor);

    public override float DopplerFactor3D {
        set => Wav_set3dDopplerFactor(this, value);
    }

    public override bool ListenerRelative3D {
        set => Wav_set3dListenerRelative(this, value?1:0);
    }

    public override bool DistanceDelay3D {
        set => Wav_set3dDistanceDelay(this, value?1:0);
    }

    public override void SetCollider3D(AudioCollider collider, int userData) {
        Wav_set3dColliderEx(this, collider, userData);
    }

    public override AudioAttenuator Attenuator3D {
        set => Wav_set3dAttenuator(this, value);
    }

    public override void SetInaudibleBehavior(bool mustTick, bool kill) {
        Wav_setInaudibleBehavior(this, mustTick?1:0, kill?1:0);
    }

    public override float Volume {
        set => Wav_setVolume(this, value);
    }
}
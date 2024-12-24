using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;

namespace SoLoud;

[StructLayout(LayoutKind.Sequential)]
public unsafe class Voice(uint handle, SoLoud? soloud = null) {
    public uint Handle = handle;
    [MaybeNull]
    private SoLoud _soLoud = soloud;
    
    public static implicit operator uint(Voice o) => o.Handle;
    public static implicit operator Voice(uint o) => new(o);

    public void Seek(double seconds) => _soLoud.Seek(this, seconds);
    
    public void Stop() => _soLoud.Stop(this);

    public void SetFilterParameter(uint filter, uint attribute, float value) =>
        _soLoud.SetFilterParameter(this, filter, attribute, value);
    
    public float GetFilterParameter(uint filter, uint attribute) =>
        _soLoud.GetFilterParameter(this, filter, attribute);
    
    public void FadeFilterParameter(uint filter, uint attribute, float to, double time) =>
        _soLoud.FadeFilterParameter(this, filter, attribute, to, time);
    
    public void OscillateFilterParameter(uint filter, uint attribute, float from, float to, double time) =>
        _soLoud.OscillateFilterParameter(this, filter, attribute, from, to, time);

    public double StreamTime => _soLoud.GetStreamTime(this);
    public double StreamPosition => _soLoud.GetStreamPosition(this);
    
    public bool IsPaused {
        get => _soLoud.GetPause(this);
        set => _soLoud.SetPause(this, value);
    }

    public float Volume {
        get => _soLoud.GetVolume(this);
        set => _soLoud.SetVolume(this, value);
    }

    public float VolumeOverall => _soLoud.GetOverallVolume(this);
    
    public float Pan {
        get => _soLoud.GetPan(this);
        set => _soLoud.SetPan(this, value);
    }

    public void SetPanAbsolute(float lVolume, float rVolume) =>
        _soLoud.SetPanAbsolute(this, lVolume, rVolume);

    public void SetChannelVolume(int channel, float volume) =>
        _soLoud.SetChannelVolume(this, channel, volume);
    
    

    public float Samplerate {
        get => _soLoud.GetSamplerate(this);
        set => _soLoud.SetSampleRate(this, value);
    }

    public bool Protected {
        get => _soLoud.GetProtectVoice(this);
        set => _soLoud.SetProtectVoice(this, value);
    }

    public bool IsValid => _soLoud.IsValidVoiceHandle(this);
    
    public float RelativePlaySpeed {
        get => _soLoud.GetRelativePlaySpeed(this);
        set => _soLoud.SetRelativePlaySpeed(this, value);
    }

    public bool Loop {
        get => _soLoud.GetLooping(this);
        set => _soLoud.SetLooping(this, value);
    }

    public bool AutoStop {
        get => _soLoud.GetAutoStop(this);
        set => _soLoud.SetAutoStop(this, value);
    }

    public double LoopPoint {
        get => _soLoud.GetLoopPoint(this);
        set => _soLoud.SetLoopPoint(this, value);
    }

    public void SetDelaySamples(uint samples) =>
        _soLoud.SetDelaySamples(this, samples);

    public void FadeVolume(float to, double time) =>
        _soLoud.FadeVolume(this, to, time);
    
    public void FadePan(float to, double time) =>
        _soLoud.FadePan(this, to, time);
    
    public void FadeRelativePlaySpeed(float to, double time) =>
        _soLoud.FadeRelativePlaySpeed(this, to, time);

    public void SchedulePause(double time) =>
        _soLoud.SchedulePause(this, time);
    
    public void ScheduleStop(double time) =>
        _soLoud.ScheduleStop(this, time);

    public void OscillateVolume(float from, float to, double time) =>
        _soLoud.OscillateVolume(this, from, to, time);
    
    public void OscillatePan(float from, float to, double time) =>
        _soLoud.OscillatePan(this, from, to, time);
    
    public void OscillateRelativePlaySpeed(float from, float to, double time) =>
        _soLoud.OscillateRelativePlaySpeed(this, from, to, time);

    public int GetLoopCount => _soLoud.GetLoopCount(this);

    public float GetInfo(uint infoKey) =>
        _soLoud.GetInfo(this, infoKey);

    public void Set3dSourceParameters(Vector3 position, Vector3 velocity = default) =>
        _soLoud.Set3dSourceParameters(this, position, velocity);

    public Vector3 SourcePosition3d {
        set => _soLoud.Set3dSourcePosition(this, value);
    }
    
    public Vector3 SourceVelocity3d {
        set => _soLoud.Set3dSourceVelocity(this, value);
    }

    public void Set3dSourceMinMaxDistance(float minDistance, float maxDistance) =>
        _soLoud.Set3dSourceMinMaxDistance(this, minDistance, maxDistance);

    public void Set3dSourceAttenuation(uint attenuationModel, float attenuationRolloffFactor) =>
        _soLoud.Set3dSourceAttenuation(this, attenuationModel, attenuationRolloffFactor);
    
    public void Set3dSourceDopplerFactor(float dopplerFactor) =>
        _soLoud.Set3dSourceDopplerFactor(this, dopplerFactor);
}
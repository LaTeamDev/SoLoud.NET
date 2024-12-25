namespace SoLoud;

public unsafe abstract class AudioSource(void** handle) : SoLoudObject(handle) {
    public abstract bool Loop { set; }

    public abstract void SetFilter(uint filterId, Filter filter);

    public abstract void SetMinMaxDistance3D(float minDistance, float maxDistance);
    public abstract void SetAttenuation3D(SoLoudAttenuationModel model, float rolloffFactor);
    public abstract float DopplerFactor3D { set; }
    public abstract bool ListenerRelative3D { set; }
    public abstract bool DistanceDelay3D { set; }
    public abstract void SetCollider3D(AudioCollider collider, int userData);
    public abstract AudioAttenuator Attenuator3D { set; }
    public abstract void SetInaudibleBehavior(bool mustTick, bool kill);
    public abstract float Volume { set; }
}
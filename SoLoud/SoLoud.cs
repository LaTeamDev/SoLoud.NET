using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using SoLoud.Interop;

namespace SoLoud;

public unsafe class SoLoud : SoLoudObject {
    public SoLoud(void** handle) : base(handle) { }

    public SoLoud() : base(create()) { }

    /// <summary>
    /// Initialize SoLoud. Must be called before SoLoud can be used.
    /// </summary>
    /// <param name="flags"></param>
    /// <param name="backend"></param>
    /// <param name="samplerate"></param>
    /// <param name="bufferSize"></param>
    /// <param name="channels"></param>
    public void Init(
        SoloudFlags flags = SoloudFlags.ClipRoundoff,
        SoLoudBackend backend = SoLoudBackend.Auto,
        int samplerate = 0, //auto
        int bufferSize = 0, //auto
        int channels = 2) =>
        ((SOLOUD_ERRORS)initEx(
            this,
            (uint)flags,
            (uint)backend,
            (uint)samplerate,
            (uint)bufferSize,
            (uint)channels)).ThrowIfError();

    /// <summary>
    /// Deinitialize SoLoud. Must be called before shutting down.
    /// </summary>
    public void DeInit() => deinit(this);

    /// <summary>
    /// Query SoLoud version number
    /// </summary>
    public uint Version => getVersion(this);
    
    /// <summary>
    /// Current Backend
    /// </summary>
    public SoLoudBackend Backend => (SoLoudBackend)getBackendId(this);
    
    /// <summary>
    /// Returns current backend string. May be NULL.
    /// </summary>
    public string? BackendString => Marshal.PtrToStringAnsi((nint)getBackendString(this));
    
    /// <summary>
    /// Returns current backend channel count (1 mono, 2 stereo, etc)
    /// </summary>
    public int BackendChannels => (int)getBackendChannels(this);
    
    /// <summary>
    /// Returns current backend sample rate
    /// </summary>
    public int BackendSampleRate => (int)getBackendSamplerate(this);
    
    /// <summary>
    /// Returns current backend buffer size
    /// </summary>
    public int BackendBufferSize => (int)getBackendBufferSize(this);

    /// <summary>
    /// Get speaker position in 3d space
    /// </summary>
    public Vector3 GetSpeakerPosition(int channel) {
        var pos = new Vector3();
        ((SOLOUD_ERRORS)getSpeakerPosition(this, (uint)channel,
            (float*)Unsafe.AsPointer(ref pos.X),
            (float*)Unsafe.AsPointer(ref pos.Y),
            (float*)Unsafe.AsPointer(ref pos.Z))).ThrowIfError();
        return pos;
    }
    
    /// <summary>
    /// Set speaker position in 3d space
    /// </summary>
    public void SetSpeakerPosition(int channel, Vector3 position) =>
        ((SOLOUD_ERRORS)setSpeakerPosition(this, (uint)channel,
            position.X,
            position.Y,
            position.Z)).ThrowIfError();

    /// <summary>
    /// Start playing a sound. Returns voice handle,
    /// which can be ignored or used to alter the
    /// playing sound's parameters. Negative volume
    /// means to use default.
    /// </summary>
    /// <param name="bus">
    /// Unless you know what are you doing, leave this as zero
    /// </param>
    /// <returns>
    /// The play function returns a channel handle
    /// which can be used to adjust the parameters
    /// of the sound while it's playing. The most
    /// common parameters can be set with the play
    /// function parameters, but for more complex
    /// processing you may want to start the sound
    /// paused, adjust the parameters, and then
    /// un-pause it.
    /// </returns>
    public Voice Play(AudioSource audioSource, float volume = -1f, float pan = 0f, bool paused = false, uint bus = 0) =>
        playEx(this, audioSource, volume, pan, paused?1:0, bus);
    
    /// <summary>
    /// Start playing a sound delayed in relation
    /// to other sounds called via this function.
    /// Negative volume means to use default.
    /// <br/>
    /// This is a variant of the play function
    /// that takes additional parameter, the time
    /// offset for the sound. While the vanilla
    /// play() tries to play sounds as soon as
    /// possible, the playClocked will delay the
    /// start of sounds so that rapidly launched
    /// sounds don't all get clumped to the
    /// start of the next outgoing sound buffer.
    /// </summary>
    /// <param name="soundTime">
    /// This should be your game's "physics time",
    /// in seconds. SoLoud will then use that time
    /// (as well as the time you previously used)
    /// to calculate the delay between two sound
    /// effects. If an output sound buffer
    /// threshold is passed between the two
    /// sounds, SoLoud will adjust the delay
    /// accordingly.
    /// </param>
    public Voice PlayClocked(double soundTime, AudioSource audioSource, float volume = -1f, float pan = 0f, uint bus = 0) =>
        playClockedEx(this, soundTime, audioSource, volume, pan, bus);

    /// <summary>
    /// Start playing a 3d audio source
    /// </summary>
    public Voice Play3D(
        AudioSource audioSource, 
        Vector3 position, 
        Vector3 velocity, 
        float volume = -1f,
        bool paused = false, 
        uint bus = 0) =>
        play3dEx(
            this, 
            audioSource, 
            position.X,
            position.Y,
            position.Z,
            velocity.X,
            velocity.Y,
            velocity.Z,
            volume,
            paused ? 1 : 0,
            bus);
    
    /// <summary>
    /// Start playing a 3d audio source, delayed
    /// in relation to other sounds called via this function.
    /// </summary>
    public Voice Play3DClocked(
        double seconds,
        AudioSource audioSource,
        Vector3 position, 
        Vector3 velocity, 
        float volume = -1f,
        bool paused = false, 
        uint bus = 0) =>
        play3dClockedEx(
            this,
            seconds,
            audioSource, 
            position.X,
            position.Y,
            position.Z,
            velocity.X,
            velocity.Y,
            velocity.Z,
            volume,
            bus);

    /// <summary>
    /// The playBackground() function can be used to play
    /// sounds without panning, primarily meant for
    /// background music.
    /// <br/>
    /// It's a convenience function, and is equivalent to
    /// play() followed by setPanAbsolute() to set left
    /// and right channels to full volme.
    /// </summary>
    public Voice PlayBackground(AudioSource audioSource, float volume = -1f, bool paused = false, uint bus = 0) =>
	    playBackgroundEx(this, audioSource, volume, paused?1:0, bus);

    /// <summary>
    /// You can seek to a specific time in the sound
    /// with the seek function. Note that the seek
    /// operation may be rather heavy, and some audio
    /// sources will not support seeking backwards
    /// at all. <br/>
    /// Relative play speed affects time.
    /// </summary>
    public void Seek(Voice voice, double seconds) => seek(this, voice, seconds);
    
    /// <summary>
    /// Stop the sound.
    /// </summary>
    public void Stop(Voice voice) => stop(this, voice);
    
    /// <summary>
    /// Stop all voices. Note that this will also stop the protected sounds.
    /// </summary>
    public void StopAll() => stopAll(this);
    
    /// <summary>
    /// Stop all voices that play this sound source
    /// </summary>
    public void Stop(AudioSource audioSource) => stopAudioSource(this, audioSource);
    
    /// <summary>
    /// Count voices that play this audio source
    /// </summary>
    public void VoicesCount(AudioSource audioSource) => countAudioSource(this, audioSource);
    
    /// Set a live filter parameter. Use 0 for the global filters.
    public void SetFilterParameter(Voice voice, uint filter, uint attribute, float value) =>
	    setFilterParameter(this, voice, filter, attribute, value);
	
    // Get a live filter parameter. Use 0 for the global filters.
	public float GetFilterParameter(Voice voice, uint filter, uint attribute) =>
		getFilterParameter(this, voice, filter, attribute);
	
	// Fade a live filter parameter. Use 0 for the global filters.
	public void FadeFilterParameter(Voice voice, uint filter, uint attribute, float to,
		double time) =>
		fadeFilterParameter(this, voice, filter, attribute, to, time);
	
	// Oscillate a live filter parameter. Use 0 for the global filters.
	public void OscillateFilterParameter(Voice voice, uint filter, uint attribute, float from,
		float to, double time) =>
		oscillateFilterParameter(this, voice, filter, attribute, from, to, time);

	// Get current play time, in seconds.
	public double GetStreamTime(Voice voice) =>
		getStreamTime(this, voice);
		
	// Get current sample position, in seconds.
	public double GetStreamPosition(Voice voice) =>
		getStreamPosition(this, voice);
	
	// Get current pause state.
	public bool GetPause(Voice voice) =>
		getPause(this, voice)!=0;
	
	// Get current volume.
	public float GetVolume(Voice voice) => 
		getVolume(this, voice);
	
	// Get current overall volume (set volume * 3d volume)
	public float GetOverallVolume(Voice voice) =>
		getOverallVolume(this, voice);
	
	// Get current pan.
	public float GetPan(Voice voice) =>
		getPan(this, voice);
	
	// Get current sample rate.
	public float GetSamplerate(Voice voice)=>
		getSamplerate(this, voice);
	
	// Get current voice protection state.
	public bool GetProtectVoice(Voice voice) =>
		getProtectVoice(this, voice)!=0;
	
	// Get the current number of busy voices.
	public uint ActiveVoiceCount =>
		getActiveVoiceCount(this);
	
	// Get the current number of voices in SoLoud
	public uint VoiceCount =>
		getVoiceCount(this);
		
	// Check if the handle is still valid, or if the sound has stopped.
	public bool IsValidVoiceHandle(Voice voice) =>
		isValidVoiceHandle(this, voice)!=0;
	
	// Get current relative play speed.
	public float GetRelativePlaySpeed(Voice voice) =>
		getRelativePlaySpeed(this, voice);
		
	// Get current post-clip scaler value.
	public float PostClipScaler {
		get => getPostClipScaler(this);
		set => setPostClipScaler(this, value);
	}

	// Get the current main resampler
	public uint MainResampler {
		get => getMainResampler(this);
		set => setMainResampler(this, value);
	}

	// Get current global volume
	public float GlobalVolume {
		get => getGlobalVolume(this);
		set => setGlobalVolume(this, value);
	}

	// Get current maximum active voice setting
	public uint MaxActiveVoiceCount {
		get => getMaxActiveVoiceCount(this);
		set => setMaxActiveVoiceCount(this, value);
	}

	// Query whether a voice is set to loop.
	public bool GetLooping(Voice voice) =>
		getLooping(this, voice)!=0;
		
	// Query whether a voice is set to auto-stop when it ends.
	public bool GetAutoStop(Voice voice) =>
		getAutoStop(this, voice)!=0;
	
	// Get voice loop point value
	public double GetLoopPoint(Voice voice) =>
		getLoopPoint(this, voice);

	// Set voice loop point value
	public void SetLoopPoint(Voice voice, double loopPoint) =>
		setLoopPoint(this, voice, loopPoint);
		
	// Set voice's loop state
	public void SetLooping(Voice voice, bool looping) =>
		setLooping(this, voice, looping?1:0);
		
	// Set whether sound should auto-stop when it ends
	public void SetAutoStop(Voice voice, bool autoStop) =>
		setAutoStop(this, voice, autoStop?1:0);
		
	// Set behavior for inaudible sounds
	public void SetInaudibleBehavior(Voice voice, bool mustTick, bool kill) =>
		setInaudibleBehavior(this, voice, mustTick?1:0, kill?1:0);
		
	// Set the pause state
	public void SetPause(Voice voice, bool pause) =>
		setPause(this, voice, pause ? 1 : 0);
	
	// Pause all voices
	public void SetPauseAll(bool pause) =>
		setPauseAll(this, pause?1:0);
		
	// Set the relative play speed
	public void SetRelativePlaySpeed(Voice voice, float speed) =>
		((SOLOUD_ERRORS)setRelativePlaySpeed(this, voice, speed)).ThrowIfError();
		
	// Set the voice protection state
	public void SetProtectVoice(Voice voice, bool protect) =>
		setProtectVoice(this, voice, protect?1:0);
		
	// Set the sample rate
	public void SetSampleRate(Voice voice, float samplerate) =>
		setSamplerate(this, voice, samplerate);
		
	// Set panning value; -1 is left, 0 is center, 1 is right
	public void SetPan(Voice voice, float pan) =>
		setPan(this, voice, pan);
		
	// Set absolute left/right volumes
	public void SetPanAbsolute(Voice voice, float lVolume, float rVolume) =>
		setPanAbsolute(this, voice, lVolume, lVolume);
		
	// Set channel volume (volume for a specific speaker)
	public void SetChannelVolume(Voice voice, int channel, float volume) =>
		setChannelVolume(this, voice, (uint)channel, volume);
		
	// Set overall volume
	public void SetVolume(Voice voice, float volume) =>
		setVolume(this, voice, volume);
		
	// Set delay, in samples, before starting to play samples. Calling this on a live sound will cause glitches.
	public void SetDelaySamples(Voice voice, uint samples) =>
		setDelaySamples(this, voice, samples);

	// Set up volume fader
	public void FadeVolume(Voice voice, float to, double time) =>
		fadeVolume(this, voice, to, time);
		
	// Set up panning fader
	public void FadePan(Voice voice, float to, double time) =>
		fadePan(this, voice, to, time);
		
	// Set up relative play speed fader
	public void FadeRelativePlaySpeed(Voice voice, float to, double time) =>
		fadeRelativePlaySpeed(this, voice, to, time);
		
	// Set up global volume fader
	public void FadeGlobalVolume(float to, double time) =>
		fadeGlobalVolume(this, to, time);
		
	// Schedule a stream to pause
	public void SchedulePause(Voice voice, double time) =>
		schedulePause(this, voice, time);
		
	// Schedule a stream to stop
	public void ScheduleStop(Voice voice, double time) =>
		scheduleStop(this, voice, time);

	// Set up volume oscillator
	public void OscillateVolume(Voice voice, float from, float to, double time) =>
		oscillateVolume(this, voice, from, to, time);
		
	// Set up panning oscillator
	public void OscillatePan(Voice voice, float from, float to, double time) =>
		oscillatePan(this, voice, from, to, time);
		
	// Set up relative play speed oscillator
	public void OscillateRelativePlaySpeed(Voice voice, float from, float to, double time) =>
		oscillateRelativePlaySpeed(this, voice, from, to, time);
		
	// Set up global volume oscillator
	public void OscillateGlobalVolume(float from, float to, double time) =>
		oscillateGlobalVolume(this, from, to, time);

	// Set global filters. Set to NULL to clear the filter.
	public void SetGlobalFilter(uint filterId, Filter filter) =>
		setGlobalFilter(this, filterId, filter);

	// Enable or disable visualization data gathering
	public bool VisualizationEnabled {
		set => setVisualizationEnable(this, value?1:0);
	}

	// Calculate and get 256 floats of FFT data for visualization. Visualization has to be enabled before use.
	public float[] CalcFFT() {
		var span = new Span<float>(calcFFT(this), 256);
		return span.ToArray();
	}

	// Get 256 floats of wave data for visualization. Visualization has to be enabled before use.
	public float[] GetWave() {
		var span = new Span<float>(getWave(this), 256);
		return span.ToArray();
	}

	// Get approximate output volume for a channel for visualization. Visualization has to be enabled before use.
	public float GetApproximateVolume(int channel) =>
		getApproximateVolume(this, (uint)channel);

	// Get current loop count. Returns 0 if handle is not valid. (All audio sources may not update loop count)
	public int GetLoopCount(Voice voice) =>
		(int)getLoopCount(this, voice);

	// Get audiosource-specific information from a voice.
	public float GetInfo(Voice voice, uint infoKey) =>
		getInfo(this, voice, infoKey);

	// Create a voice group. Returns 0 if unable (out of voice groups / out of memory)
	public VoiceGroup CreateVoiceGroup() {
		var group = createVoiceGroup(this);
		if (group == 0)
			throw new OutOfMemoryException("Unable to create group: no more voice group available or out of memory");
		return new VoiceGroup(group, this);
	}
	
	// Destroy a voice group.
	public void DestroyVoiceGroup(VoiceGroup voiceGroup) =>
		((SOLOUD_ERRORS)destroyVoiceGroup(this, voiceGroup)).ThrowIfError();
	
	// Add a voice handle to a voice group
	public void AddVoiceToGroup(VoiceGroup voiceGroup, Voice voice) =>
		((SOLOUD_ERRORS)addVoiceToGroup(this, voiceGroup, voice)).ThrowIfError();
	
	// Is this handle a valid voice group?
	public bool IsValidVoiceGroup(VoiceGroup voiceGroup) =>
		isVoiceGroup(this, voiceGroup)!=0;
	
	// Is this voice group empty?
	public bool IsVoiceGroupEmpty(VoiceGroup voiceGroup) =>
		isVoiceGroupEmpty(this, voiceGroup)!=0;

	// Perform 3d audio parameter update
	public void Update3dAudio() =>
		update3dAudio(this);

	// Speed of sound constant for doppler
	public float SoundSpeed3D {
		get => get3dSoundSpeed(this);
		set => ((SOLOUD_ERRORS)set3dSoundSpeed(this, value)).ThrowIfError();
	}
	
	// Set 3d listener parameters
	public void Set3dListenerParameters(Vector3 position, Vector3 at, Vector3 up, Vector3 velocity = default) =>
		set3dListenerParametersEx(this,
			position.X, position.Y, position.Z,
			at.X, at.Y, at.Z,
			up.X, up.Y, up.Z,
			velocity.X, velocity.Y, velocity.Z);
	
	// Set 3d listener position
	public Vector3 ListenerPosition3D {
		set => set3dListenerPosition(this, value.X, value.Y, value.Z);
	}
	
	public Vector3 ListenerAt3D {
		set => set3dListenerAt(this, value.X, value.Y, value.Z);
	}
	
	public Vector3 ListenerUp3D {
		set => set3dListenerUp(this, value.X, value.Y, value.Z);
	}
	
	public Vector3 ListenerVelocity3D {
		set => set3dListenerVelocity(this, value.X, value.Y, value.Z);
	}

	// Set 3d audio source parameters
	public void Set3dSourceParameters(Voice voice, Vector3 position, Vector3 velocity = default) =>
		set3dSourceParametersEx(this, voice,
			position.X, position.Y, position.Z,
			velocity.X, velocity.Y, velocity.Z);
	
	// Set 3d audio source position
	public void Set3dSourcePosition(Voice voice, Vector3 position) =>
		set3dSourcePosition(this, voice, position.X, position.Y, position.Z);
	
	// Set 3d audio source velocity
	public void Set3dSourceVelocity(Voice voice, Vector3 velocity) =>
		set3dSourceVelocity(this, voice, velocity.X, velocity.Y, velocity.Z);
	
	// Set 3d audio source min/max distance (distance < min means max volume)
	public void Set3dSourceMinMaxDistance(Voice voice, float minDistance, float maxDistance) =>
		set3dSourceMinMaxDistance(this, voice, minDistance, maxDistance);
	
	// Set 3d audio source attenuation parameters
	public void Set3dSourceAttenuation(Voice voice, uint attenuationModel, float attenuationRolloffFactor) =>
		set3dSourceAttenuation(this, voice, attenuationModel, attenuationRolloffFactor);
	
	// Set 3d audio source doppler factor to reduce or enhance doppler effect. Default = 1.0
	public void Set3dSourceDopplerFactor(Voice voice, float dopplerFactor) =>
	 set3dSourceDopplerFactor(this, voice, dopplerFactor);
}
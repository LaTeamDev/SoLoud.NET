using System.Runtime.InteropServices;

namespace SoLoud.Interop;

public static unsafe partial class SoLoud
{
    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_destroy", ExactSpelling = true)]
    public static extern void destroy([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_create", ExactSpelling = true)]
    [return: NativeTypeName("Soloud *")]
    public static extern void** create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_init", ExactSpelling = true)]
    public static extern int init([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_initEx", ExactSpelling = true)]
    public static extern int initEx([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aFlags, [NativeTypeName("unsigned int")] uint aBackend, [NativeTypeName("unsigned int")] uint aSamplerate, [NativeTypeName("unsigned int")] uint aBufferSize, [NativeTypeName("unsigned int")] uint aChannels);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_deinit", ExactSpelling = true)]
    public static extern void deinit([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getVersion", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getVersion([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getErrorString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* getErrorString([NativeTypeName("Soloud *")] void** aSoloud, int aErrorCode);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getBackendId", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getBackendId([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getBackendString", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* getBackendString([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getBackendChannels", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getBackendChannels([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getBackendSamplerate", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getBackendSamplerate([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getBackendBufferSize", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getBackendBufferSize([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setSpeakerPosition", ExactSpelling = true)]
    public static extern int setSpeakerPosition([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aChannel, float aX, float aY, float aZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getSpeakerPosition", ExactSpelling = true)]
    public static extern int getSpeakerPosition([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aChannel, float* aX, float* aY, float* aZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_play", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint play([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_playEx", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint playEx([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("AudioSource *")] void** aSound, float aVolume, float aPan, int aPaused, [NativeTypeName("unsigned int")] uint aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_playClocked", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint playClocked([NativeTypeName("Soloud *")] void** aSoloud, double aSoundTime, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_playClockedEx", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint playClockedEx([NativeTypeName("Soloud *")] void** aSoloud, double aSoundTime, [NativeTypeName("AudioSource *")] void** aSound, float aVolume, float aPan, [NativeTypeName("unsigned int")] uint aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_play3d", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint play3d([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("AudioSource *")] void** aSound, float aPosX, float aPosY, float aPosZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_play3dEx", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint play3dEx([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("AudioSource *")] void** aSound, float aPosX, float aPosY, float aPosZ, float aVelX, float aVelY, float aVelZ, float aVolume, int aPaused, [NativeTypeName("unsigned int")] uint aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_play3dClocked", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint play3dClocked([NativeTypeName("Soloud *")] void** aSoloud, double aSoundTime, [NativeTypeName("AudioSource *")] void** aSound, float aPosX, float aPosY, float aPosZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_play3dClockedEx", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint play3dClockedEx([NativeTypeName("Soloud *")] void** aSoloud, double aSoundTime, [NativeTypeName("AudioSource *")] void** aSound, float aPosX, float aPosY, float aPosZ, float aVelX, float aVelY, float aVelZ, float aVolume, [NativeTypeName("unsigned int")] uint aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_playBackground", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint playBackground([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_playBackgroundEx", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint playBackgroundEx([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("AudioSource *")] void** aSound, float aVolume, int aPaused, [NativeTypeName("unsigned int")] uint aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_seek", ExactSpelling = true)]
    public static extern int seek([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, double aSeconds);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_stop", ExactSpelling = true)]
    public static extern void stop([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_stopAll", ExactSpelling = true)]
    public static extern void stopAll([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_stopAudioSource", ExactSpelling = true)]
    public static extern void stopAudioSource([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_countAudioSource", ExactSpelling = true)]
    public static extern int countAudioSource([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setFilterParameter", ExactSpelling = true)]
    public static extern void setFilterParameter([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("unsigned int")] uint aAttributeId, float aValue);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getFilterParameter", ExactSpelling = true)]
    public static extern float getFilterParameter([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("unsigned int")] uint aAttributeId);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_fadeFilterParameter", ExactSpelling = true)]
    public static extern void fadeFilterParameter([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("unsigned int")] uint aAttributeId, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_oscillateFilterParameter", ExactSpelling = true)]
    public static extern void oscillateFilterParameter([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("unsigned int")] uint aAttributeId, float aFrom, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getStreamTime", ExactSpelling = true)]
    public static extern double getStreamTime([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getStreamPosition", ExactSpelling = true)]
    public static extern double getStreamPosition([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getPause", ExactSpelling = true)]
    public static extern int getPause([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getVolume", ExactSpelling = true)]
    public static extern float getVolume([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getOverallVolume", ExactSpelling = true)]
    public static extern float getOverallVolume([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getPan", ExactSpelling = true)]
    public static extern float getPan([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getSamplerate", ExactSpelling = true)]
    public static extern float getSamplerate([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getProtectVoice", ExactSpelling = true)]
    public static extern int getProtectVoice([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getActiveVoiceCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getActiveVoiceCount([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getVoiceCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getVoiceCount([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_isValidVoiceHandle", ExactSpelling = true)]
    public static extern int isValidVoiceHandle([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getRelativePlaySpeed", ExactSpelling = true)]
    public static extern float getRelativePlaySpeed([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getPostClipScaler", ExactSpelling = true)]
    public static extern float getPostClipScaler([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getMainResampler", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getMainResampler([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getGlobalVolume", ExactSpelling = true)]
    public static extern float getGlobalVolume([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getMaxActiveVoiceCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getMaxActiveVoiceCount([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getLooping", ExactSpelling = true)]
    public static extern int getLooping([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getAutoStop", ExactSpelling = true)]
    public static extern int getAutoStop([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getLoopPoint", ExactSpelling = true)]
    public static extern double getLoopPoint([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setLoopPoint", ExactSpelling = true)]
    public static extern void setLoopPoint([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setLooping", ExactSpelling = true)]
    public static extern void setLooping([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, int aLooping);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setAutoStop", ExactSpelling = true)]
    public static extern void setAutoStop([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setMaxActiveVoiceCount", ExactSpelling = true)]
    public static extern int setMaxActiveVoiceCount([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceCount);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setInaudibleBehavior", ExactSpelling = true)]
    public static extern void setInaudibleBehavior([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setGlobalVolume", ExactSpelling = true)]
    public static extern void setGlobalVolume([NativeTypeName("Soloud *")] void** aSoloud, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setPostClipScaler", ExactSpelling = true)]
    public static extern void setPostClipScaler([NativeTypeName("Soloud *")] void** aSoloud, float aScaler);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setMainResampler", ExactSpelling = true)]
    public static extern void setMainResampler([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aResampler);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setPause", ExactSpelling = true)]
    public static extern void setPause([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, int aPause);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setPauseAll", ExactSpelling = true)]
    public static extern void setPauseAll([NativeTypeName("Soloud *")] void** aSoloud, int aPause);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setRelativePlaySpeed", ExactSpelling = true)]
    public static extern int setRelativePlaySpeed([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aSpeed);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setProtectVoice", ExactSpelling = true)]
    public static extern void setProtectVoice([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, int aProtect);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setSamplerate", ExactSpelling = true)]
    public static extern void setSamplerate([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aSamplerate);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setPan", ExactSpelling = true)]
    public static extern void setPan([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aPan);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setPanAbsolute", ExactSpelling = true)]
    public static extern void setPanAbsolute([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aLVolume, float aRVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setChannelVolume", ExactSpelling = true)]
    public static extern void setChannelVolume([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, [NativeTypeName("unsigned int")] uint aChannel, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setVolume", ExactSpelling = true)]
    public static extern void setVolume([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setDelaySamples", ExactSpelling = true)]
    public static extern void setDelaySamples([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, [NativeTypeName("unsigned int")] uint aSamples);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_fadeVolume", ExactSpelling = true)]
    public static extern void fadeVolume([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_fadePan", ExactSpelling = true)]
    public static extern void fadePan([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_fadeRelativePlaySpeed", ExactSpelling = true)]
    public static extern void fadeRelativePlaySpeed([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_fadeGlobalVolume", ExactSpelling = true)]
    public static extern void fadeGlobalVolume([NativeTypeName("Soloud *")] void** aSoloud, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_schedulePause", ExactSpelling = true)]
    public static extern void schedulePause([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_scheduleStop", ExactSpelling = true)]
    public static extern void scheduleStop([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_oscillateVolume", ExactSpelling = true)]
    public static extern void oscillateVolume([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aFrom, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_oscillatePan", ExactSpelling = true)]
    public static extern void oscillatePan([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aFrom, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_oscillateRelativePlaySpeed", ExactSpelling = true)]
    public static extern void oscillateRelativePlaySpeed([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aFrom, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_oscillateGlobalVolume", ExactSpelling = true)]
    public static extern void oscillateGlobalVolume([NativeTypeName("Soloud *")] void** aSoloud, float aFrom, float aTo, double aTime);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setGlobalFilter", ExactSpelling = true)]
    public static extern void setGlobalFilter([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_setVisualizationEnable", ExactSpelling = true)]
    public static extern void setVisualizationEnable([NativeTypeName("Soloud *")] void** aSoloud, int aEnable);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_calcFFT", ExactSpelling = true)]
    public static extern float* calcFFT([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getWave", ExactSpelling = true)]
    public static extern float* getWave([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getApproximateVolume", ExactSpelling = true)]
    public static extern float getApproximateVolume([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aChannel);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getLoopCount", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint getLoopCount([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_getInfo", ExactSpelling = true)]
    public static extern float getInfo([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, [NativeTypeName("unsigned int")] uint aInfoKey);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_createVoiceGroup", ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint createVoiceGroup([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_destroyVoiceGroup", ExactSpelling = true)]
    public static extern int destroyVoiceGroup([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceGroupHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_addVoiceToGroup", ExactSpelling = true)]
    public static extern int addVoiceToGroup([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceGroupHandle, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_isVoiceGroup", ExactSpelling = true)]
    public static extern int isVoiceGroup([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceGroupHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_isVoiceGroupEmpty", ExactSpelling = true)]
    public static extern int isVoiceGroupEmpty([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceGroupHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_update3dAudio", ExactSpelling = true)]
    public static extern void update3dAudio([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dSoundSpeed", ExactSpelling = true)]
    public static extern int set3dSoundSpeed([NativeTypeName("Soloud *")] void** aSoloud, float aSpeed);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_get3dSoundSpeed", ExactSpelling = true)]
    public static extern float get3dSoundSpeed([NativeTypeName("Soloud *")] void** aSoloud);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dListenerParameters", ExactSpelling = true)]
    public static extern void set3dListenerParameters([NativeTypeName("Soloud *")] void** aSoloud, float aPosX, float aPosY, float aPosZ, float aAtX, float aAtY, float aAtZ, float aUpX, float aUpY, float aUpZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dListenerParametersEx", ExactSpelling = true)]
    public static extern void set3dListenerParametersEx([NativeTypeName("Soloud *")] void** aSoloud, float aPosX, float aPosY, float aPosZ, float aAtX, float aAtY, float aAtZ, float aUpX, float aUpY, float aUpZ, float aVelocityX, float aVelocityY, float aVelocityZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dListenerPosition", ExactSpelling = true)]
    public static extern void set3dListenerPosition([NativeTypeName("Soloud *")] void** aSoloud, float aPosX, float aPosY, float aPosZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dListenerAt", ExactSpelling = true)]
    public static extern void set3dListenerAt([NativeTypeName("Soloud *")] void** aSoloud, float aAtX, float aAtY, float aAtZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dListenerUp", ExactSpelling = true)]
    public static extern void set3dListenerUp([NativeTypeName("Soloud *")] void** aSoloud, float aUpX, float aUpY, float aUpZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dListenerVelocity", ExactSpelling = true)]
    public static extern void set3dListenerVelocity([NativeTypeName("Soloud *")] void** aSoloud, float aVelocityX, float aVelocityY, float aVelocityZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dSourceParameters", ExactSpelling = true)]
    public static extern void set3dSourceParameters([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aPosX, float aPosY, float aPosZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dSourceParametersEx", ExactSpelling = true)]
    public static extern void set3dSourceParametersEx([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aPosX, float aPosY, float aPosZ, float aVelocityX, float aVelocityY, float aVelocityZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dSourcePosition", ExactSpelling = true)]
    public static extern void set3dSourcePosition([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aPosX, float aPosY, float aPosZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dSourceVelocity", ExactSpelling = true)]
    public static extern void set3dSourceVelocity([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aVelocityX, float aVelocityY, float aVelocityZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dSourceMinMaxDistance", ExactSpelling = true)]
    public static extern void set3dSourceMinMaxDistance([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dSourceAttenuation", ExactSpelling = true)]
    public static extern void set3dSourceAttenuation([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_set3dSourceDopplerFactor", ExactSpelling = true)]
    public static extern void set3dSourceDopplerFactor([NativeTypeName("Soloud *")] void** aSoloud, [NativeTypeName("unsigned int")] uint aVoiceHandle, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_mix", ExactSpelling = true)]
    public static extern void mix([NativeTypeName("Soloud *")] void** aSoloud, float* aBuffer, [NativeTypeName("unsigned int")] uint aSamples);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Soloud_mixSigned16", ExactSpelling = true)]
    public static extern void mixSigned16([NativeTypeName("Soloud *")] void** aSoloud, short* aBuffer, [NativeTypeName("unsigned int")] uint aSamples);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_destroy([NativeTypeName("Ay *")] void** aAy);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Ay *")]
    public static extern void** Ay_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_setVolume([NativeTypeName("Ay *")] void** aAy, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_setLooping([NativeTypeName("Ay *")] void** aAy, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_setAutoStop([NativeTypeName("Ay *")] void** aAy, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_set3dMinMaxDistance([NativeTypeName("Ay *")] void** aAy, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_set3dAttenuation([NativeTypeName("Ay *")] void** aAy, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_set3dDopplerFactor([NativeTypeName("Ay *")] void** aAy, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_set3dListenerRelative([NativeTypeName("Ay *")] void** aAy, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_set3dDistanceDelay([NativeTypeName("Ay *")] void** aAy, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_set3dCollider([NativeTypeName("Ay *")] void** aAy, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_set3dColliderEx([NativeTypeName("Ay *")] void** aAy, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_set3dAttenuator([NativeTypeName("Ay *")] void** aAy, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_setInaudibleBehavior([NativeTypeName("Ay *")] void** aAy, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_setLoopPoint([NativeTypeName("Ay *")] void** aAy, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Ay_getLoopPoint([NativeTypeName("Ay *")] void** aAy);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_setFilter([NativeTypeName("Ay *")] void** aAy, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Ay_stop([NativeTypeName("Ay *")] void** aAy);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void BassboostFilter_destroy([NativeTypeName("BassboostFilter *")] void** aBassboostFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int BassboostFilter_getParamCount([NativeTypeName("BassboostFilter *")] void** aBassboostFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* BassboostFilter_getParamName([NativeTypeName("BassboostFilter *")] void** aBassboostFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint BassboostFilter_getParamType([NativeTypeName("BassboostFilter *")] void** aBassboostFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float BassboostFilter_getParamMax([NativeTypeName("BassboostFilter *")] void** aBassboostFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float BassboostFilter_getParamMin([NativeTypeName("BassboostFilter *")] void** aBassboostFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int BassboostFilter_setParams([NativeTypeName("BassboostFilter *")] void** aBassboostFilter, float aBoost);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BassboostFilter *")]
    public static extern void** BassboostFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void BiquadResonantFilter_destroy([NativeTypeName("BiquadResonantFilter *")] void** aBiquadResonantFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int BiquadResonantFilter_getParamCount([NativeTypeName("BiquadResonantFilter *")] void** aBiquadResonantFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* BiquadResonantFilter_getParamName([NativeTypeName("BiquadResonantFilter *")] void** aBiquadResonantFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint BiquadResonantFilter_getParamType([NativeTypeName("BiquadResonantFilter *")] void** aBiquadResonantFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float BiquadResonantFilter_getParamMax([NativeTypeName("BiquadResonantFilter *")] void** aBiquadResonantFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float BiquadResonantFilter_getParamMin([NativeTypeName("BiquadResonantFilter *")] void** aBiquadResonantFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("BiquadResonantFilter *")]
    public static extern void** BiquadResonantFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int BiquadResonantFilter_setParams([NativeTypeName("BiquadResonantFilter *")] void** aBiquadResonantFilter, int aType, float aFrequency, float aResonance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_destroy([NativeTypeName("Bus *")] void** aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Bus *")]
    public static extern void** Bus_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_setFilter([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_play([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_playEx([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("AudioSource *")] void** aSound, float aVolume, float aPan, int aPaused);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_playClocked([NativeTypeName("Bus *")] void** aBus, double aSoundTime, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_playClockedEx([NativeTypeName("Bus *")] void** aBus, double aSoundTime, [NativeTypeName("AudioSource *")] void** aSound, float aVolume, float aPan);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_play3d([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("AudioSource *")] void** aSound, float aPosX, float aPosY, float aPosZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_play3dEx([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("AudioSource *")] void** aSound, float aPosX, float aPosY, float aPosZ, float aVelX, float aVelY, float aVelZ, float aVolume, int aPaused);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_play3dClocked([NativeTypeName("Bus *")] void** aBus, double aSoundTime, [NativeTypeName("AudioSource *")] void** aSound, float aPosX, float aPosY, float aPosZ);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_play3dClockedEx([NativeTypeName("Bus *")] void** aBus, double aSoundTime, [NativeTypeName("AudioSource *")] void** aSound, float aPosX, float aPosY, float aPosZ, float aVelX, float aVelY, float aVelZ, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Bus_setChannels([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("unsigned int")] uint aChannels);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_setVisualizationEnable([NativeTypeName("Bus *")] void** aBus, int aEnable);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_annexSound([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("unsigned int")] uint aVoiceHandle);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float* Bus_calcFFT([NativeTypeName("Bus *")] void** aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float* Bus_getWave([NativeTypeName("Bus *")] void** aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float Bus_getApproximateVolume([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("unsigned int")] uint aChannel);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_getActiveVoiceCount([NativeTypeName("Bus *")] void** aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Bus_getResampler([NativeTypeName("Bus *")] void** aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_setResampler([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("unsigned int")] uint aResampler);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_setVolume([NativeTypeName("Bus *")] void** aBus, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_setLooping([NativeTypeName("Bus *")] void** aBus, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_setAutoStop([NativeTypeName("Bus *")] void** aBus, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_set3dMinMaxDistance([NativeTypeName("Bus *")] void** aBus, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_set3dAttenuation([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_set3dDopplerFactor([NativeTypeName("Bus *")] void** aBus, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_set3dListenerRelative([NativeTypeName("Bus *")] void** aBus, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_set3dDistanceDelay([NativeTypeName("Bus *")] void** aBus, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_set3dCollider([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_set3dColliderEx([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_set3dAttenuator([NativeTypeName("Bus *")] void** aBus, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_setInaudibleBehavior([NativeTypeName("Bus *")] void** aBus, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_setLoopPoint([NativeTypeName("Bus *")] void** aBus, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Bus_getLoopPoint([NativeTypeName("Bus *")] void** aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Bus_stop([NativeTypeName("Bus *")] void** aBus);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void DCRemovalFilter_destroy([NativeTypeName("DCRemovalFilter *")] void** aDCRemovalFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("DCRemovalFilter *")]
    public static extern void** DCRemovalFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int DCRemovalFilter_setParams([NativeTypeName("DCRemovalFilter *")] void** aDCRemovalFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int DCRemovalFilter_setParamsEx([NativeTypeName("DCRemovalFilter *")] void** aDCRemovalFilter, float aLength);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int DCRemovalFilter_getParamCount([NativeTypeName("DCRemovalFilter *")] void** aDCRemovalFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* DCRemovalFilter_getParamName([NativeTypeName("DCRemovalFilter *")] void** aDCRemovalFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint DCRemovalFilter_getParamType([NativeTypeName("DCRemovalFilter *")] void** aDCRemovalFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float DCRemovalFilter_getParamMax([NativeTypeName("DCRemovalFilter *")] void** aDCRemovalFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float DCRemovalFilter_getParamMin([NativeTypeName("DCRemovalFilter *")] void** aDCRemovalFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void EchoFilter_destroy([NativeTypeName("EchoFilter *")] void** aEchoFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int EchoFilter_getParamCount([NativeTypeName("EchoFilter *")] void** aEchoFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* EchoFilter_getParamName([NativeTypeName("EchoFilter *")] void** aEchoFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint EchoFilter_getParamType([NativeTypeName("EchoFilter *")] void** aEchoFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float EchoFilter_getParamMax([NativeTypeName("EchoFilter *")] void** aEchoFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float EchoFilter_getParamMin([NativeTypeName("EchoFilter *")] void** aEchoFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("EchoFilter *")]
    public static extern void** EchoFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int EchoFilter_setParams([NativeTypeName("EchoFilter *")] void** aEchoFilter, float aDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int EchoFilter_setParamsEx([NativeTypeName("EchoFilter *")] void** aEchoFilter, float aDelay, float aDecay, float aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FFTFilter_destroy([NativeTypeName("FFTFilter *")] void** aFFTFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FFTFilter *")]
    public static extern void** FFTFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int FFTFilter_getParamCount([NativeTypeName("FFTFilter *")] void** aFFTFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FFTFilter_getParamName([NativeTypeName("FFTFilter *")] void** aFFTFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint FFTFilter_getParamType([NativeTypeName("FFTFilter *")] void** aFFTFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float FFTFilter_getParamMax([NativeTypeName("FFTFilter *")] void** aFFTFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float FFTFilter_getParamMin([NativeTypeName("FFTFilter *")] void** aFFTFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FlangerFilter_destroy([NativeTypeName("FlangerFilter *")] void** aFlangerFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int FlangerFilter_getParamCount([NativeTypeName("FlangerFilter *")] void** aFlangerFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FlangerFilter_getParamName([NativeTypeName("FlangerFilter *")] void** aFlangerFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint FlangerFilter_getParamType([NativeTypeName("FlangerFilter *")] void** aFlangerFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float FlangerFilter_getParamMax([NativeTypeName("FlangerFilter *")] void** aFlangerFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float FlangerFilter_getParamMin([NativeTypeName("FlangerFilter *")] void** aFlangerFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FlangerFilter *")]
    public static extern void** FlangerFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int FlangerFilter_setParams([NativeTypeName("FlangerFilter *")] void** aFlangerFilter, float aDelay, float aFreq);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void FreeverbFilter_destroy([NativeTypeName("FreeverbFilter *")] void** aFreeverbFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int FreeverbFilter_getParamCount([NativeTypeName("FreeverbFilter *")] void** aFreeverbFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* FreeverbFilter_getParamName([NativeTypeName("FreeverbFilter *")] void** aFreeverbFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint FreeverbFilter_getParamType([NativeTypeName("FreeverbFilter *")] void** aFreeverbFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float FreeverbFilter_getParamMax([NativeTypeName("FreeverbFilter *")] void** aFreeverbFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float FreeverbFilter_getParamMin([NativeTypeName("FreeverbFilter *")] void** aFreeverbFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FreeverbFilter *")]
    public static extern void** FreeverbFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int FreeverbFilter_setParams([NativeTypeName("FreeverbFilter *")] void** aFreeverbFilter, float aMode, float aRoomSize, float aDamp, float aWidth);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void LofiFilter_destroy([NativeTypeName("LofiFilter *")] void** aLofiFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int LofiFilter_getParamCount([NativeTypeName("LofiFilter *")] void** aLofiFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* LofiFilter_getParamName([NativeTypeName("LofiFilter *")] void** aLofiFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint LofiFilter_getParamType([NativeTypeName("LofiFilter *")] void** aLofiFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float LofiFilter_getParamMax([NativeTypeName("LofiFilter *")] void** aLofiFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float LofiFilter_getParamMin([NativeTypeName("LofiFilter *")] void** aLofiFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("LofiFilter *")]
    public static extern void** LofiFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int LofiFilter_setParams([NativeTypeName("LofiFilter *")] void** aLofiFilter, float aSampleRate, float aBitdepth);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_destroy([NativeTypeName("Monotone *")] void** aMonotone);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Monotone *")]
    public static extern void** Monotone_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Monotone_setParams([NativeTypeName("Monotone *")] void** aMonotone, int aHardwareChannels);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Monotone_setParamsEx([NativeTypeName("Monotone *")] void** aMonotone, int aHardwareChannels, int aWaveform);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Monotone_load([NativeTypeName("Monotone *")] void** aMonotone, [NativeTypeName("const char *")] sbyte* aFilename);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Monotone_loadMem([NativeTypeName("Monotone *")] void** aMonotone, [NativeTypeName("const unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Monotone_loadMemEx([NativeTypeName("Monotone *")] void** aMonotone, [NativeTypeName("const unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength, int aCopy, int aTakeOwnership);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Monotone_loadFile([NativeTypeName("Monotone *")] void** aMonotone, [NativeTypeName("File *")] void** aFile);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_setVolume([NativeTypeName("Monotone *")] void** aMonotone, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_setLooping([NativeTypeName("Monotone *")] void** aMonotone, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_setAutoStop([NativeTypeName("Monotone *")] void** aMonotone, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_set3dMinMaxDistance([NativeTypeName("Monotone *")] void** aMonotone, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_set3dAttenuation([NativeTypeName("Monotone *")] void** aMonotone, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_set3dDopplerFactor([NativeTypeName("Monotone *")] void** aMonotone, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_set3dListenerRelative([NativeTypeName("Monotone *")] void** aMonotone, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_set3dDistanceDelay([NativeTypeName("Monotone *")] void** aMonotone, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_set3dCollider([NativeTypeName("Monotone *")] void** aMonotone, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_set3dColliderEx([NativeTypeName("Monotone *")] void** aMonotone, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_set3dAttenuator([NativeTypeName("Monotone *")] void** aMonotone, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_setInaudibleBehavior([NativeTypeName("Monotone *")] void** aMonotone, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_setLoopPoint([NativeTypeName("Monotone *")] void** aMonotone, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Monotone_getLoopPoint([NativeTypeName("Monotone *")] void** aMonotone);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_setFilter([NativeTypeName("Monotone *")] void** aMonotone, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Monotone_stop([NativeTypeName("Monotone *")] void** aMonotone);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_destroy([NativeTypeName("Noise *")] void** aNoise);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Noise *")]
    public static extern void** Noise_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_setOctaveScale([NativeTypeName("Noise *")] void** aNoise, float aOct0, float aOct1, float aOct2, float aOct3, float aOct4, float aOct5, float aOct6, float aOct7, float aOct8, float aOct9);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_setType([NativeTypeName("Noise *")] void** aNoise, int aType);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_setVolume([NativeTypeName("Noise *")] void** aNoise, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_setLooping([NativeTypeName("Noise *")] void** aNoise, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_setAutoStop([NativeTypeName("Noise *")] void** aNoise, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_set3dMinMaxDistance([NativeTypeName("Noise *")] void** aNoise, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_set3dAttenuation([NativeTypeName("Noise *")] void** aNoise, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_set3dDopplerFactor([NativeTypeName("Noise *")] void** aNoise, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_set3dListenerRelative([NativeTypeName("Noise *")] void** aNoise, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_set3dDistanceDelay([NativeTypeName("Noise *")] void** aNoise, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_set3dCollider([NativeTypeName("Noise *")] void** aNoise, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_set3dColliderEx([NativeTypeName("Noise *")] void** aNoise, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_set3dAttenuator([NativeTypeName("Noise *")] void** aNoise, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_setInaudibleBehavior([NativeTypeName("Noise *")] void** aNoise, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_setLoopPoint([NativeTypeName("Noise *")] void** aNoise, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Noise_getLoopPoint([NativeTypeName("Noise *")] void** aNoise);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_setFilter([NativeTypeName("Noise *")] void** aNoise, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Noise_stop([NativeTypeName("Noise *")] void** aNoise);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_destroy([NativeTypeName("Openmpt *")] void** aOpenmpt);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Openmpt *")]
    public static extern void** Openmpt_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Openmpt_load([NativeTypeName("Openmpt *")] void** aOpenmpt, [NativeTypeName("const char *")] sbyte* aFilename);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Openmpt_loadMem([NativeTypeName("Openmpt *")] void** aOpenmpt, [NativeTypeName("const unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Openmpt_loadMemEx([NativeTypeName("Openmpt *")] void** aOpenmpt, [NativeTypeName("const unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength, int aCopy, int aTakeOwnership);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Openmpt_loadFile([NativeTypeName("Openmpt *")] void** aOpenmpt, [NativeTypeName("File *")] void** aFile);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_setVolume([NativeTypeName("Openmpt *")] void** aOpenmpt, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_setLooping([NativeTypeName("Openmpt *")] void** aOpenmpt, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_setAutoStop([NativeTypeName("Openmpt *")] void** aOpenmpt, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_set3dMinMaxDistance([NativeTypeName("Openmpt *")] void** aOpenmpt, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_set3dAttenuation([NativeTypeName("Openmpt *")] void** aOpenmpt, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_set3dDopplerFactor([NativeTypeName("Openmpt *")] void** aOpenmpt, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_set3dListenerRelative([NativeTypeName("Openmpt *")] void** aOpenmpt, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_set3dDistanceDelay([NativeTypeName("Openmpt *")] void** aOpenmpt, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_set3dCollider([NativeTypeName("Openmpt *")] void** aOpenmpt, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_set3dColliderEx([NativeTypeName("Openmpt *")] void** aOpenmpt, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_set3dAttenuator([NativeTypeName("Openmpt *")] void** aOpenmpt, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_setInaudibleBehavior([NativeTypeName("Openmpt *")] void** aOpenmpt, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_setLoopPoint([NativeTypeName("Openmpt *")] void** aOpenmpt, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Openmpt_getLoopPoint([NativeTypeName("Openmpt *")] void** aOpenmpt);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_setFilter([NativeTypeName("Openmpt *")] void** aOpenmpt, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Openmpt_stop([NativeTypeName("Openmpt *")] void** aOpenmpt);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_destroy([NativeTypeName("Queue *")] void** aQueue);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Queue *")]
    public static extern void** Queue_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Queue_play([NativeTypeName("Queue *")] void** aQueue, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint Queue_getQueueCount([NativeTypeName("Queue *")] void** aQueue);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Queue_isCurrentlyPlaying([NativeTypeName("Queue *")] void** aQueue, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Queue_setParamsFromAudioSource([NativeTypeName("Queue *")] void** aQueue, [NativeTypeName("AudioSource *")] void** aSound);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Queue_setParams([NativeTypeName("Queue *")] void** aQueue, float aSamplerate);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Queue_setParamsEx([NativeTypeName("Queue *")] void** aQueue, float aSamplerate, [NativeTypeName("unsigned int")] uint aChannels);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_setVolume([NativeTypeName("Queue *")] void** aQueue, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_setLooping([NativeTypeName("Queue *")] void** aQueue, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_setAutoStop([NativeTypeName("Queue *")] void** aQueue, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_set3dMinMaxDistance([NativeTypeName("Queue *")] void** aQueue, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_set3dAttenuation([NativeTypeName("Queue *")] void** aQueue, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_set3dDopplerFactor([NativeTypeName("Queue *")] void** aQueue, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_set3dListenerRelative([NativeTypeName("Queue *")] void** aQueue, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_set3dDistanceDelay([NativeTypeName("Queue *")] void** aQueue, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_set3dCollider([NativeTypeName("Queue *")] void** aQueue, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_set3dColliderEx([NativeTypeName("Queue *")] void** aQueue, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_set3dAttenuator([NativeTypeName("Queue *")] void** aQueue, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_setInaudibleBehavior([NativeTypeName("Queue *")] void** aQueue, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_setLoopPoint([NativeTypeName("Queue *")] void** aQueue, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Queue_getLoopPoint([NativeTypeName("Queue *")] void** aQueue);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_setFilter([NativeTypeName("Queue *")] void** aQueue, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Queue_stop([NativeTypeName("Queue *")] void** aQueue);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void RobotizeFilter_destroy([NativeTypeName("RobotizeFilter *")] void** aRobotizeFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int RobotizeFilter_getParamCount([NativeTypeName("RobotizeFilter *")] void** aRobotizeFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* RobotizeFilter_getParamName([NativeTypeName("RobotizeFilter *")] void** aRobotizeFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint RobotizeFilter_getParamType([NativeTypeName("RobotizeFilter *")] void** aRobotizeFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float RobotizeFilter_getParamMax([NativeTypeName("RobotizeFilter *")] void** aRobotizeFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float RobotizeFilter_getParamMin([NativeTypeName("RobotizeFilter *")] void** aRobotizeFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void RobotizeFilter_setParams([NativeTypeName("RobotizeFilter *")] void** aRobotizeFilter, float aFreq, int aWaveform);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("RobotizeFilter *")]
    public static extern void** RobotizeFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_destroy([NativeTypeName("Sfxr *")] void** aSfxr);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Sfxr *")]
    public static extern void** Sfxr_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_resetParams([NativeTypeName("Sfxr *")] void** aSfxr);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Sfxr_loadParams([NativeTypeName("Sfxr *")] void** aSfxr, [NativeTypeName("const char *")] sbyte* aFilename);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Sfxr_loadParamsMem([NativeTypeName("Sfxr *")] void** aSfxr, [NativeTypeName("unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Sfxr_loadParamsMemEx([NativeTypeName("Sfxr *")] void** aSfxr, [NativeTypeName("unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength, int aCopy, int aTakeOwnership);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Sfxr_loadParamsFile([NativeTypeName("Sfxr *")] void** aSfxr, [NativeTypeName("File *")] void** aFile);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Sfxr_loadPreset([NativeTypeName("Sfxr *")] void** aSfxr, int aPresetNo, int aRandSeed);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_setVolume([NativeTypeName("Sfxr *")] void** aSfxr, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_setLooping([NativeTypeName("Sfxr *")] void** aSfxr, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_setAutoStop([NativeTypeName("Sfxr *")] void** aSfxr, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_set3dMinMaxDistance([NativeTypeName("Sfxr *")] void** aSfxr, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_set3dAttenuation([NativeTypeName("Sfxr *")] void** aSfxr, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_set3dDopplerFactor([NativeTypeName("Sfxr *")] void** aSfxr, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_set3dListenerRelative([NativeTypeName("Sfxr *")] void** aSfxr, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_set3dDistanceDelay([NativeTypeName("Sfxr *")] void** aSfxr, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_set3dCollider([NativeTypeName("Sfxr *")] void** aSfxr, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_set3dColliderEx([NativeTypeName("Sfxr *")] void** aSfxr, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_set3dAttenuator([NativeTypeName("Sfxr *")] void** aSfxr, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_setInaudibleBehavior([NativeTypeName("Sfxr *")] void** aSfxr, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_setLoopPoint([NativeTypeName("Sfxr *")] void** aSfxr, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Sfxr_getLoopPoint([NativeTypeName("Sfxr *")] void** aSfxr);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_setFilter([NativeTypeName("Sfxr *")] void** aSfxr, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Sfxr_stop([NativeTypeName("Sfxr *")] void** aSfxr);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_destroy([NativeTypeName("Speech *")] void** aSpeech);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Speech *")]
    public static extern void** Speech_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Speech_setText([NativeTypeName("Speech *")] void** aSpeech, [NativeTypeName("const char *")] sbyte* aText);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Speech_setParams([NativeTypeName("Speech *")] void** aSpeech);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Speech_setParamsEx([NativeTypeName("Speech *")] void** aSpeech, [NativeTypeName("unsigned int")] uint aBaseFrequency, float aBaseSpeed, float aBaseDeclination, int aBaseWaveform);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_setVolume([NativeTypeName("Speech *")] void** aSpeech, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_setLooping([NativeTypeName("Speech *")] void** aSpeech, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_setAutoStop([NativeTypeName("Speech *")] void** aSpeech, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_set3dMinMaxDistance([NativeTypeName("Speech *")] void** aSpeech, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_set3dAttenuation([NativeTypeName("Speech *")] void** aSpeech, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_set3dDopplerFactor([NativeTypeName("Speech *")] void** aSpeech, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_set3dListenerRelative([NativeTypeName("Speech *")] void** aSpeech, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_set3dDistanceDelay([NativeTypeName("Speech *")] void** aSpeech, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_set3dCollider([NativeTypeName("Speech *")] void** aSpeech, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_set3dColliderEx([NativeTypeName("Speech *")] void** aSpeech, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_set3dAttenuator([NativeTypeName("Speech *")] void** aSpeech, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_setInaudibleBehavior([NativeTypeName("Speech *")] void** aSpeech, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_setLoopPoint([NativeTypeName("Speech *")] void** aSpeech, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Speech_getLoopPoint([NativeTypeName("Speech *")] void** aSpeech);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_setFilter([NativeTypeName("Speech *")] void** aSpeech, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Speech_stop([NativeTypeName("Speech *")] void** aSpeech);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_destroy([NativeTypeName("TedSid *")] void** aTedSid);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("TedSid *")]
    public static extern void** TedSid_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int TedSid_load([NativeTypeName("TedSid *")] void** aTedSid, [NativeTypeName("const char *")] sbyte* aFilename);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int TedSid_loadMem([NativeTypeName("TedSid *")] void** aTedSid, [NativeTypeName("const unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int TedSid_loadMemEx([NativeTypeName("TedSid *")] void** aTedSid, [NativeTypeName("const unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength, int aCopy, int aTakeOwnership);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int TedSid_loadFile([NativeTypeName("TedSid *")] void** aTedSid, [NativeTypeName("File *")] void** aFile);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_setVolume([NativeTypeName("TedSid *")] void** aTedSid, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_setLooping([NativeTypeName("TedSid *")] void** aTedSid, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_setAutoStop([NativeTypeName("TedSid *")] void** aTedSid, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_set3dMinMaxDistance([NativeTypeName("TedSid *")] void** aTedSid, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_set3dAttenuation([NativeTypeName("TedSid *")] void** aTedSid, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_set3dDopplerFactor([NativeTypeName("TedSid *")] void** aTedSid, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_set3dListenerRelative([NativeTypeName("TedSid *")] void** aTedSid, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_set3dDistanceDelay([NativeTypeName("TedSid *")] void** aTedSid, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_set3dCollider([NativeTypeName("TedSid *")] void** aTedSid, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_set3dColliderEx([NativeTypeName("TedSid *")] void** aTedSid, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_set3dAttenuator([NativeTypeName("TedSid *")] void** aTedSid, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_setInaudibleBehavior([NativeTypeName("TedSid *")] void** aTedSid, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_setLoopPoint([NativeTypeName("TedSid *")] void** aTedSid, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double TedSid_getLoopPoint([NativeTypeName("TedSid *")] void** aTedSid);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_setFilter([NativeTypeName("TedSid *")] void** aTedSid, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void TedSid_stop([NativeTypeName("TedSid *")] void** aTedSid);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_destroy([NativeTypeName("Vic *")] void** aVic);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Vic *")]
    public static extern void** Vic_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_setModel([NativeTypeName("Vic *")] void** aVic, int model);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Vic_getModel([NativeTypeName("Vic *")] void** aVic);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_setRegister([NativeTypeName("Vic *")] void** aVic, int reg, [NativeTypeName("unsigned char")] byte value);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned char")]
    public static extern byte Vic_getRegister([NativeTypeName("Vic *")] void** aVic, int reg);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_setVolume([NativeTypeName("Vic *")] void** aVic, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_setLooping([NativeTypeName("Vic *")] void** aVic, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_setAutoStop([NativeTypeName("Vic *")] void** aVic, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_set3dMinMaxDistance([NativeTypeName("Vic *")] void** aVic, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_set3dAttenuation([NativeTypeName("Vic *")] void** aVic, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_set3dDopplerFactor([NativeTypeName("Vic *")] void** aVic, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_set3dListenerRelative([NativeTypeName("Vic *")] void** aVic, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_set3dDistanceDelay([NativeTypeName("Vic *")] void** aVic, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_set3dCollider([NativeTypeName("Vic *")] void** aVic, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_set3dColliderEx([NativeTypeName("Vic *")] void** aVic, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_set3dAttenuator([NativeTypeName("Vic *")] void** aVic, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_setInaudibleBehavior([NativeTypeName("Vic *")] void** aVic, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_setLoopPoint([NativeTypeName("Vic *")] void** aVic, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Vic_getLoopPoint([NativeTypeName("Vic *")] void** aVic);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_setFilter([NativeTypeName("Vic *")] void** aVic, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vic_stop([NativeTypeName("Vic *")] void** aVic);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_destroy([NativeTypeName("Vizsn *")] void** aVizsn);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Vizsn *")]
    public static extern void** Vizsn_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_setText([NativeTypeName("Vizsn *")] void** aVizsn, [NativeTypeName("char *")] sbyte* aText);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_setVolume([NativeTypeName("Vizsn *")] void** aVizsn, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_setLooping([NativeTypeName("Vizsn *")] void** aVizsn, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_setAutoStop([NativeTypeName("Vizsn *")] void** aVizsn, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_set3dMinMaxDistance([NativeTypeName("Vizsn *")] void** aVizsn, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_set3dAttenuation([NativeTypeName("Vizsn *")] void** aVizsn, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_set3dDopplerFactor([NativeTypeName("Vizsn *")] void** aVizsn, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_set3dListenerRelative([NativeTypeName("Vizsn *")] void** aVizsn, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_set3dDistanceDelay([NativeTypeName("Vizsn *")] void** aVizsn, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_set3dCollider([NativeTypeName("Vizsn *")] void** aVizsn, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_set3dColliderEx([NativeTypeName("Vizsn *")] void** aVizsn, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_set3dAttenuator([NativeTypeName("Vizsn *")] void** aVizsn, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_setInaudibleBehavior([NativeTypeName("Vizsn *")] void** aVizsn, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_setLoopPoint([NativeTypeName("Vizsn *")] void** aVizsn, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Vizsn_getLoopPoint([NativeTypeName("Vizsn *")] void** aVizsn);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_setFilter([NativeTypeName("Vizsn *")] void** aVizsn, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Vizsn_stop([NativeTypeName("Vizsn *")] void** aVizsn);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_destroy([NativeTypeName("Wav *")] void** aWav);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Wav *")]
    public static extern void** Wav_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_load([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("const char *")] sbyte* aFilename);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_loadMem([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("const unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_loadMemEx([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("const unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength, int aCopy, int aTakeOwnership);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_loadFile([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("File *")] void** aFile);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_loadRawWave8([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_loadRawWave8Ex([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("unsigned char *")] byte* aMem, [NativeTypeName("unsigned int")] uint aLength, float aSamplerate, [NativeTypeName("unsigned int")] uint aChannels);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_loadRawWave16([NativeTypeName("Wav *")] void** aWav, short* aMem, [NativeTypeName("unsigned int")] uint aLength);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_loadRawWave16Ex([NativeTypeName("Wav *")] void** aWav, short* aMem, [NativeTypeName("unsigned int")] uint aLength, float aSamplerate, [NativeTypeName("unsigned int")] uint aChannels);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_loadRawWave([NativeTypeName("Wav *")] void** aWav, float* aMem, [NativeTypeName("unsigned int")] uint aLength);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int Wav_loadRawWaveEx([NativeTypeName("Wav *")] void** aWav, float* aMem, [NativeTypeName("unsigned int")] uint aLength, float aSamplerate, [NativeTypeName("unsigned int")] uint aChannels, int aCopy, int aTakeOwnership);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Wav_getLength([NativeTypeName("Wav *")] void** aWav);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_setVolume([NativeTypeName("Wav *")] void** aWav, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_setLooping([NativeTypeName("Wav *")] void** aWav, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_setAutoStop([NativeTypeName("Wav *")] void** aWav, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_set3dMinMaxDistance([NativeTypeName("Wav *")] void** aWav, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_set3dAttenuation([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_set3dDopplerFactor([NativeTypeName("Wav *")] void** aWav, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_set3dListenerRelative([NativeTypeName("Wav *")] void** aWav, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_set3dDistanceDelay([NativeTypeName("Wav *")] void** aWav, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_set3dCollider([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_set3dColliderEx([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_set3dAttenuator([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_setInaudibleBehavior([NativeTypeName("Wav *")] void** aWav, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_setLoopPoint([NativeTypeName("Wav *")] void** aWav, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double Wav_getLoopPoint([NativeTypeName("Wav *")] void** aWav);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_setFilter([NativeTypeName("Wav *")] void** aWav, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Wav_stop([NativeTypeName("Wav *")] void** aWav);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WaveShaperFilter_destroy([NativeTypeName("WaveShaperFilter *")] void** aWaveShaperFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int WaveShaperFilter_setParams([NativeTypeName("WaveShaperFilter *")] void** aWaveShaperFilter, float aAmount);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("WaveShaperFilter *")]
    public static extern void** WaveShaperFilter_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int WaveShaperFilter_getParamCount([NativeTypeName("WaveShaperFilter *")] void** aWaveShaperFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* WaveShaperFilter_getParamName([NativeTypeName("WaveShaperFilter *")] void** aWaveShaperFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint WaveShaperFilter_getParamType([NativeTypeName("WaveShaperFilter *")] void** aWaveShaperFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float WaveShaperFilter_getParamMax([NativeTypeName("WaveShaperFilter *")] void** aWaveShaperFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float WaveShaperFilter_getParamMin([NativeTypeName("WaveShaperFilter *")] void** aWaveShaperFilter, [NativeTypeName("unsigned int")] uint aParamIndex);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_destroy([NativeTypeName("WavStream *")] void** aWavStream);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("WavStream *")]
    public static extern void** WavStream_create();

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int WavStream_load([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("const char *")] sbyte* aFilename);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int WavStream_loadMem([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("const unsigned char *")] byte* aData, [NativeTypeName("unsigned int")] uint aDataLen);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int WavStream_loadMemEx([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("const unsigned char *")] byte* aData, [NativeTypeName("unsigned int")] uint aDataLen, int aCopy, int aTakeOwnership);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int WavStream_loadToMem([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("const char *")] sbyte* aFilename);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int WavStream_loadFile([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("File *")] void** aFile);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int WavStream_loadFileToMem([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("File *")] void** aFile);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double WavStream_getLength([NativeTypeName("WavStream *")] void** aWavStream);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_setVolume([NativeTypeName("WavStream *")] void** aWavStream, float aVolume);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_setLooping([NativeTypeName("WavStream *")] void** aWavStream, int aLoop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_setAutoStop([NativeTypeName("WavStream *")] void** aWavStream, int aAutoStop);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_set3dMinMaxDistance([NativeTypeName("WavStream *")] void** aWavStream, float aMinDistance, float aMaxDistance);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_set3dAttenuation([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("unsigned int")] uint aAttenuationModel, float aAttenuationRolloffFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_set3dDopplerFactor([NativeTypeName("WavStream *")] void** aWavStream, float aDopplerFactor);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_set3dListenerRelative([NativeTypeName("WavStream *")] void** aWavStream, int aListenerRelative);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_set3dDistanceDelay([NativeTypeName("WavStream *")] void** aWavStream, int aDistanceDelay);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_set3dCollider([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("AudioCollider *")] void** aCollider);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_set3dColliderEx([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("AudioCollider *")] void** aCollider, int aUserData);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_set3dAttenuator([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("AudioAttenuator *")] void** aAttenuator);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_setInaudibleBehavior([NativeTypeName("WavStream *")] void** aWavStream, int aMustTick, int aKill);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_setLoopPoint([NativeTypeName("WavStream *")] void** aWavStream, double aLoopPoint);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern double WavStream_getLoopPoint([NativeTypeName("WavStream *")] void** aWavStream);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_setFilter([NativeTypeName("WavStream *")] void** aWavStream, [NativeTypeName("unsigned int")] uint aFilterId, [NativeTypeName("Filter *")] void** aFilter);

    [DllImport("soloud", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void WavStream_stop([NativeTypeName("WavStream *")] void** aWavStream);
}

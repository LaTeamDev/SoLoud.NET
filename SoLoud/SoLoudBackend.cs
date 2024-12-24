namespace SoLoud;

public enum SoLoudBackend : uint {
    Auto = SOLOUD_AUTO,
    SDL1 = SOLOUD_SDL1,
    SDL2 = SOLOUD_SDL2,
    PortAudio = SOLOUD_PORTAUDIO,
    WinMM = SOLOUD_WINMM,
    XAudio2 = SOLOUD_XAUDIO2,
    WASAPI = SOLOUD_WASAPI,
    ALSA = SOLOUD_ALSA,
    JACK = SOLOUD_JACK,
    OSS = SOLOUD_OSS,
    OpenAL = SOLOUD_OPENAL,
    CoreAudio = SOLOUD_COREAUDIO,
    OpenSLES = SOLOUD_OPENSLES,
    VitaHomebrew = SOLOUD_VITA_HOMEBREW,
    MiniAudio = SOLOUD_MINIAUDIO,
    NoSound = SOLOUD_NOSOUND,
    NullDriver = SOLOUD_NULLDRIVER
}
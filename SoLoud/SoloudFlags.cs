using System;

namespace SoLoud;

[Flags]
public enum SoloudFlags : uint {
    /// <summary>
    /// Use roundoff clipper. Without this flag the clipper defaults to "hard" clipping to -1/+1
    /// </summary>
    ClipRoundoff = SOLOUD_CLIP_ROUNDOFF,
    /// <summary>
    /// Enable gathering of visualization data. Can be changed at runtime with setVisualizationEnable()
    /// </summary>
    EnableVisualization = SOLOUD_ENABLE_VISUALIZATION,
    /// <summary>
    /// Use left-handed (Direct3D) 3d coordinates. Default is right-handed (OpenGL) coordinates.
    /// </summary>
    LeftHanded3D = SOLOUD_LEFT_HANDED_3D,
    /// <summary>
    /// Do not alter the FPU state in audio threads. By default, SoLoud uses "fast" fpu options.
    /// </summary>
    NoFpuRegisterChange = SOLOUD_NO_FPU_REGISTER_CHANGE
}
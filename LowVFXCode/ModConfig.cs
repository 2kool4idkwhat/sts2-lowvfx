using BaseLib.Config;

namespace LowVFX;

internal class ModConfig : SimpleModConfig
{
    // public static bool KeepCardTransformVfx { get; set; } = false;

    public static bool NoRecolorCardTransformVfx { get; set; } = false;

    // public static bool KeepParticlesVfx { get; set; } = false;

    [ConfigHoverTip]
    public static bool KeepInsatiableBgSandfalls { get; set; } = false;

    [ConfigSection("AttackVfx")]
    // public static bool KeepSlashVfx { get; set; } = false;

    // [ConfigHoverTip]
    // public static bool KeepBiteVfx { get; set; } = false;

    // [ConfigHoverTip]
    // public static bool KeepScratchVfx { get; set; } = false;

    [ConfigHoverTip]
    public static bool KeepScreamVfx { get; set; } = false;

    [ConfigHoverTip]
    public static bool KeepSpookyScreamVfx { get; set; } = false;
}

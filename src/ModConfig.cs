using BaseLib.Config;

namespace LowVFX;

internal class ModConfig : SimpleModConfig
{
    public static bool KeepHitSparks { get; set; } = false;

    public static bool KeepCardTransformVfx { get; set; } = false;
}

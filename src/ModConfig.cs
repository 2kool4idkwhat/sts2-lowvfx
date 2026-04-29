using BaseLib.Config;

namespace LowVFX;

internal class ModConfig : SimpleModConfig
{
    public static bool KeepCardTransformVfx { get; set; } = false;

    [ConfigHoverTip]
    public static bool KeepInsatiableBgSandfalls { get; set; } = false;
}

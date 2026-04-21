using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NCardTransformVfx), "_Ready")]
public static class NCardTransformVfxPatch
{

    public static bool Prefix()
    {
        return ModConfig.KeepCardTransformVfx;
    }

}

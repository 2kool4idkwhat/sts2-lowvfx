using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NCardTransformVfx), "_Ready")]
public static class NCardTransformVfx_Patch
{

    public static bool Prefix()
    {
        return ModConfig.KeepCardTransformVfx;
    }

}

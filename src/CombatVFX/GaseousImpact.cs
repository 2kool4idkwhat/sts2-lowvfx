using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NGaseousImpactVfx), "_Ready")]
public static class NGaseousImpactVfxPatch
{

    public static bool Prefix()
    {
        return false;
    }

}

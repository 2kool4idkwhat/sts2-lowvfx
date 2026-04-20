using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NMinionDiveBombVfx), "_Ready")]
public static class NMinionDiveBombVfxPatch
{

    public static bool Prefix()
    {
        return false;
    }

}

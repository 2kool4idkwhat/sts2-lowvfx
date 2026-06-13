using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NSweepingBeamVfx), "_Ready")]
public static class NSweepingBeamVfx_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

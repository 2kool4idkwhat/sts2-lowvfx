// "small magic missile" - comet, ...

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NSmallMagicMissileVfx), "_Ready")]
public static class NSmallMagicMissileVfx_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

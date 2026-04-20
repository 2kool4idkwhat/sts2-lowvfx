// "scratch (impact)" - claw, maul, rip and tear, ...

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NScratchVfx), "_Ready")]
public static class NScratchVfxPatch
{

    public static bool Prefix()
    {
        return false;
    }

}

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NCardSmithVfx), "_Ready")]
public static class NCardSmithVfxPatch
{

    public static bool Prefix()
    {
        return false;
    }

}

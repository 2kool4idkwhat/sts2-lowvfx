using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NCardSmithVfx), "_Ready")]
public static class NCardSmithVfx_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

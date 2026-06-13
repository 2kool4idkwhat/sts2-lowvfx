using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NBigSlashVfx), "_Ready")]
public static class NBigSlashVfx_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

[HarmonyPatch(typeof(NBigSlashImpactVfx), "_Ready")]
public static class NBigSlashImpactVfx_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

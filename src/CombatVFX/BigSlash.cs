using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NBigSlashVfx), "_Ready")]
public static class NBigSlashVfxPatch
{

    public static bool Prefix()
    {
        return false;
    }

}

[HarmonyPatch(typeof(NBigSlashImpactVfx), "_Ready")]
public static class NBigSlashImpactVfxPatch
{

    public static bool Prefix()
    {
        return false;
    }

}

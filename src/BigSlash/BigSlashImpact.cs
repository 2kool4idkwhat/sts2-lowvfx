using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NBigSlashImpactVfx), "_Ready")]
public static class NBigSlashImpactVfxPatch
{

    public static bool Prefix()
    {
        return false;
    }

}

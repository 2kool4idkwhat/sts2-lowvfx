using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(
    typeof(NMinionDiveBombVfx),
    "Create",
    new Type[] { typeof(Creature), typeof(Creature) }
)]
public static class NMinionDiveBombVfx_Create_Patch
{
    public static bool Prefix(ref NMinionDiveBombVfx? __result)
    {
        __result = null;
        return false;
    }
}

[HarmonyPatch(typeof(NMinionDiveBombVfx), "_Ready")]
public static class NMinionDiveBombVfx_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

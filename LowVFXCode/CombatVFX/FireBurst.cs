// "fire burst" - cinder, architect

using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NFireBurstVfx), "Create", new Type[] { typeof(Creature), typeof(float) })]
public static class NFireBurstVfx_Patch
{
    public static bool Prefix(ref NFireBurstVfx? __result)
    {
        __result = null;
        return false;
    }
}

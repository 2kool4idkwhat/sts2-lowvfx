using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NKinPriestGrenadeVfx), "Create")]
public static class NKinPriestGrenadeVfxPatch
{

    public static bool Prefix(ref NKinPriestGrenadeVfx? __result)
    {
        __result = null;
        return false;
    }

}

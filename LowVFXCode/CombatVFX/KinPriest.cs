using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NKinPriestGrenadeVfx), "Create")]
public static class NKinPriestGrenadeVfx_Patch
{
    public static bool Prefix(ref NKinPriestGrenadeVfx? __result)
    {
        __result = null;
        return false;
    }
}

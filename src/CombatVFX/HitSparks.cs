using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NHitSparkVfx), "Create")]
public static class NHitSparkVfx_Patch
{
    public static bool Prefix(ref NHitSparkVfx? __result)
    {
        __result = null;
        return false;
    }
}

[HarmonyPatch(typeof(NBlockSparkVfx), "Create")]
public static class NBlockSparkVfx_Patch
{
    public static bool Prefix(ref NBlockSparkVfx? __result)
    {
        __result = null;
        return false;
    }
}

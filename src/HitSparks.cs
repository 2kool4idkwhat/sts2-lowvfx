using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NHitSparkVfx), "Create")]
public static class NHitSparkVfxPatch
{

    public static bool Prefix(ref NHitSparkVfx? __result)
    {
        if (ModConfig.KeepHitSparks)
        {
            return true;
        }

        __result = null;
        return false;
    }

}

[HarmonyPatch(typeof(NBlockSparkVfx), "Create")]
public static class NBlockSparkVfxPatch
{

    public static bool Prefix(ref NBlockSparkVfx? __result)
    {
        if (ModConfig.KeepHitSparks)
        {
            return true;
        }

        __result = null;
        return false;
    }

}

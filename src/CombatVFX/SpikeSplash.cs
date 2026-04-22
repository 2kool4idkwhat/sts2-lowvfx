// "spike splash" - crush under, stomp, mecha knight, ...

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx.Cards;

namespace LowVFX;

[HarmonyPatch(typeof(NSpikeSplashVfx), "Create")]
public static class NSpikeSplashVfx_Patch
{

    public static bool Prefix(ref NSpikeSplashVfx? __result)
    {
        __result = null;
        return false;
    }

}

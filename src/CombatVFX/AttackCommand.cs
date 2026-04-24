using HarmonyLib;
using MegaCrit.Sts2.Core.Commands.Builders;

namespace LowVFX;

// generic attack vfx
[HarmonyPatch(typeof(AttackCommand), "WithHitFx")]
public static class WithHitFx_Patch
{

    static void Prefix(ref string? vfx)
    {
        vfx = null;
    }

}

[HarmonyPatch(typeof(AttackCommand), "WithAttackerAnim")]
public static class WithAttackerAnim_Patch
{

    static void Prefix(ref string? animName)
    {
        // waterfall giant death explosion
        if (animName == "Erupt")
        {
            animName = null;
        }
    }

}

// generic attack vfx

using HarmonyLib;
using MegaCrit.Sts2.Core.Commands.Builders;

namespace LowVFX;

[HarmonyPatch(typeof(AttackCommand), "WithHitFx")]
public static class WithHitFxPatch
{

    static void Prefix(ref string? vfx)
    {
        vfx = null;
    }

}

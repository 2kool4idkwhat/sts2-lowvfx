using System.Reflection;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;
using MegaCrit.Sts2.Core.Nodes.Vfx.Cards;

namespace LowVFX;

// [HarmonyPatch(typeof(NCardTransformVfx), "_Ready")]
// public static class NCardTransformVfx_Patch
// {
//     public static bool Prefix()
//     {
//         return ModConfig.KeepCardTransformVfx;
//     }
// }

[HarmonyPatch(typeof(NCardTransformShineVfx))]
[HarmonyPatch(MethodType.Constructor)]
class NCardTransformShineVfx_Patch
{
    static readonly FieldInfo WhiteOpaqueField = AccessTools.Field(
        typeof(NCardTransformShineVfx),
        "_whiteOpaque"
    );

    static readonly FieldInfo WhiteClearField = AccessTools.Field(
        typeof(NCardTransformShineVfx),
        "_whiteClear"
    );

    static void Postfix(object __instance)
    {
        if (ModConfig.NoRecolorCardTransformVfx)
            return;

        WhiteOpaqueField.SetValue(
            __instance,
            new Color(0f, 0f, 0f) // black
        );

        WhiteClearField.SetValue(
            __instance,
            new Color(0f, 0f, 0f, 0f) // black
        );
    }
}

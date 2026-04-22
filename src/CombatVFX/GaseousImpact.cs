using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;
using Godot;

namespace LowVFX;

[HarmonyPatch(typeof(NGaseousImpactVfx), "Create", new Type[] { typeof(Vector2), typeof(Color) })]
public static class NGaseousImpactVfx_Patch
{

    public static bool Prefix(ref NGaseousImpactVfx? __result)
    {
        __result = null;
        return false;
    }

}

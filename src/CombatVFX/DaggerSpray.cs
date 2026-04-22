using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;
using Godot;

namespace LowVFX;

[HarmonyPatch(typeof(NDaggerSprayFlurryVfx), "Create", new Type[] { typeof(Vector2), typeof(Color), typeof(bool) })]
public static class NDaggerSprayFlurryVfx_Patch
{

    public static bool Prefix(ref NDaggerSprayFlurryVfx? __result)
    {
        __result = null;
        return false;
    }

}

[HarmonyPatch(typeof(NDaggerSprayImpactVfx), "Create", new Type[] { typeof(Vector2), typeof(Color), typeof(bool) })]
public static class NDaggerSprayImpactVfx_Patch
{

    public static bool Prefix(ref NDaggerSprayImpactVfx? __result)
    {
        __result = null;
        return false;
    }

}

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;
using Godot;

namespace LowVFX;

[HarmonyPatch(typeof(NWormyImpactVfx), "Create", new Type[] { typeof(Vector2), typeof(Vector2) })]
public static class NWormyImpactVfx_Patch
{

    public static bool Prefix(ref NWormyImpactVfx? __result)
    {
        __result = null;
        return false;
    }

}

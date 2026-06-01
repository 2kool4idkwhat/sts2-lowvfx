using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NSporeImpactVfx), "Create", new Type[] { typeof(Creature), typeof(Color) })]
public static class NSporeImpactVfx_Patch
{
    public static bool Prefix(ref NSporeImpactVfx? __result)
    {
        __result = null;
        return false;
    }
}

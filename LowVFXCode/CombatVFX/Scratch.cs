// "scratch (impact)" - claw, maul, rip and tear, ...

using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NScratchVfx), "Create", new Type[] { typeof(Vector2), typeof(bool) })]
public static class NScratchVfx_Patch
{
    public static bool Prefix(ref NScratchVfx? __result)
    {
        __result = null;
        return false;
    }
}

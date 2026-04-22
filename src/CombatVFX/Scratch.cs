// "scratch (impact)" - claw, maul, rip and tear, ...

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;
using Godot;

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

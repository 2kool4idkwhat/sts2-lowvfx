// "goopy impact" - gunk up, slimed, ...

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;
using Godot;

namespace LowVFX;

[HarmonyPatch(
    typeof(NGoopyImpactVfx),
    nameof(NGoopyImpactVfx.Create),
    new Type[] { typeof(Vector2), typeof(Color) }
)]
public static class NGoopyImpactVfx_Patch
{

    public static bool Prefix(ref NGoopyImpactVfx? __result)
    {
        __result = null;
        return false;
    }

}

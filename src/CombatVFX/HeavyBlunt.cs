// this is the vfx/vfx_heavy_blunt effect so it should already be disabled at
// WithHitFx but SOMEHOW crash landing still displays it

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

// NOTE: no-oping Create() doesn't work, only _Ready() does
[HarmonyPatch(typeof(NHeavyBluntVfx), nameof(NHeavyBluntVfx._Ready))]
public static class NHeavyBluntVfx_Patch
{

    public static bool Prefix()
    {
        return false;
    }

}

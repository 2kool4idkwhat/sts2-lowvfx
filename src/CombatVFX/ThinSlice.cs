// "thin slice" - flash of steel, neutralize, suppress, slice

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NThinSliceVfx), "Create")]
public static class NThinSliceVfxPatch
{

    public static bool Prefix(ref NThinSliceVfx? __result)
    {
        __result = null;
        return false;
    }

}

// "large magic missile" - bombardment, meteor strike, ...

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NLargeMagicMissileVfx), "_Ready")]
public static class NLargeMagicMissileVfx_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

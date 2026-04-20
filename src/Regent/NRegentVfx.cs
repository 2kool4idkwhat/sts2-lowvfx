// disable the swords that appear above regent for a moment when playing an attack

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NRegentVfx), "Attack")]
public static class NRegentVfxPatch
{

    public static bool Prefix()
    {
        return false;
    }

}

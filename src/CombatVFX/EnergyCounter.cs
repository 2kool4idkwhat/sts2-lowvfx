// disable the flash around the energy counter when gaining energy

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace LowVFX;

[HarmonyPatch(typeof(NEnergyCounter), "OnEnergyChanged")]
public static class NEnergyCounter_Patch
{

    public static bool Prefix()
    {
        return false;
    }

}

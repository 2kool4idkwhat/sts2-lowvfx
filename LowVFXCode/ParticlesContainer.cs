using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx.Utilities;

namespace LowVFX;

[HarmonyPatch(typeof(NParticlesContainer), nameof(NParticlesContainer.SetEmitting))]
public static class NParticlesContainer_SetEmitting_Patch
{
    public static void Prefix(ref bool emitting)
    {
        // if (ModConfig.KeepParticlesVfx)
        //     return;

        emitting = false;
    }
}

[HarmonyPatch(typeof(NParticlesContainer), nameof(NParticlesContainer.Restart))]
public static class NParticlesContainer_Restart_Patch
{
    public static bool Prefix()
    {
        // if (ModConfig.KeepParticlesVfx)
        //     return true;

        return false;
    }
}

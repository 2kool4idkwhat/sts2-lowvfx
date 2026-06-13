using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Commands;

namespace LowVFX;

public static class Helper
{
    public static bool CheckIfVfxPathAllowed(string? vfxPath)
    {
        switch (vfxPath)
        {
            case null:
                return false;

            // ATTACK VFX

            case VfxCmd.slashPath:
                return ModConfig.KeepSlashVfx;

            case VfxCmd.bitePath:
                return ModConfig.KeepBiteVfx;

            case VfxCmd.scratchPath:
                return ModConfig.KeepScratchVfx;

            // NON-ATTACK VFX

            // block gain effect
            case VfxCmd.blockPath:
                return true;

            case VfxCmd.screamVfx:
                return ModConfig.KeepScreamVfx;

            case VfxCmd.spookyScreamVfx:
                return ModConfig.KeepSpookyScreamVfx;
        }

        return false;
    }
}

[HarmonyPatch(typeof(VfxCmd), nameof(VfxCmd.PlayOnCreature))]
public static class PlayOnCreature_Patch
{
    public static bool Prefix(ref string path)
    {
        return Helper.CheckIfVfxPathAllowed(path);
    }
}

[HarmonyPatch(typeof(VfxCmd), nameof(VfxCmd.PlayOnCreatureCenter))]
public static class PlayOnCreatureCenter_Patch
{
    public static bool Prefix(ref string path)
    {
        return Helper.CheckIfVfxPathAllowed(path);
    }
}

[HarmonyPatch(typeof(VfxCmd), "PlayFullScreenInCombat")]
public static class PlayFullScreenInCombat_Patch
{
    public static bool Prefix(ref string path)
    {
        return Helper.CheckIfVfxPathAllowed(path);
    }
}

// jungle maze adventure, dense vegetation
[HarmonyPatch(typeof(VfxCmd), "PlayNonCombatVfx")]
public static class PlayNonCombatVfx_Patch
{
    public static bool Prefix(ref string path, ref Node2D? __result)
    {
        // dense vegetation event uses the returned Node2D without checking for null
        // so we can't disable the vfx that it uses or the game will crash. this also
        // means we can't fully disable jungle maze adventure vfx (because it uses
        // vfx/vfx_attack_slash too) :(
        // TODO: look into replacing sprites as a solution to this
        switch (path)
        {
            case "vfx/vfx_attack_slash":
                return true;

            case "vfx/events/dense_vegetation_slice_vfx":
                return true;
        }

        __result = null;
        return false;
    }
}

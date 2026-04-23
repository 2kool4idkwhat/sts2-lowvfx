using HarmonyLib;
using MegaCrit.Sts2.Core.Commands;
using Godot;

namespace LowVFX;

public static class Helper
{
    public static bool CheckIfVfxPathAllowed(string vfxPath)
    {
        switch (vfxPath)
        {
            // ATTACK VFX

            case "vfx/vfx_attack_slash":
                return false;

            case "vfx/vfx_attack_blunt":
                return false;

            case "vfx/vfx_heavy_blunt":
                return false;

            case "vfx/vfx_bloody_impact":
                return false;

            case "vfx/vfx_rock_shatter":
                return false;

            case "vfx/vfx_dagger_spray":
                return false;

            case "vfx/vfx_flying_slash":
                return false;

            case "vfx/vfx_dramatic_stab":
                return false;

            case "vfx/vfx_dagger_throw":
                return false;

            case "vfx/vfx_attack_lightning":
                return false;

            case "vfx/vfx_starry_impact":
                return false;

            case "vfx/vfx_scratch":
                return false;

            case "vfx/vfx_dramatic_entrance_fullscreen":
                return false;

            // NON-ATTACK VFX

            // devoted sculptor, terror eel, the insatiable, ceremonial beast
            case "vfx/vfx_scream":
                return false;
        }

        return true;
    }
}

[HarmonyPatch(typeof(VfxCmd), "PlayOnCreature")]
public static class PlayOnCreaturePatch
{

    public static bool Prefix(ref string path)
    {
        return Helper.CheckIfVfxPathAllowed(path);
    }

}

[HarmonyPatch(typeof(VfxCmd), "PlayOnCreatureCenter")]
public static class PlayOnCreatureCenterPatch
{

    public static bool Prefix(ref string path)
    {
        return Helper.CheckIfVfxPathAllowed(path);
    }

}

[HarmonyPatch(typeof(VfxCmd), "PlayFullScreenInCombat")]
public static class PlayFullScreenInCombatPatch
{

    public static bool Prefix(ref string path)
    {
        return Helper.CheckIfVfxPathAllowed(path);
    }

}

// jungle maze adventure, dense vegetation
[HarmonyPatch(typeof(VfxCmd), "PlayNonCombatVfx")]
public static class PlayNonCombatVfxPatch
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

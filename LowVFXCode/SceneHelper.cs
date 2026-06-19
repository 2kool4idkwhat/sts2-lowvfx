using HarmonyLib;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Helpers;

namespace LowVFX;

[HarmonyPatch(typeof(SceneHelper), nameof(SceneHelper.GetScenePath))]
public static class SceneHelper_Patch
{
    private const string emptyReplacementPath = "res://LowVFX/replacement_vfx/empty.tscn";

    static bool Prefix(string innerPath, ref string __result)
    {
        switch (innerPath)
        {
            case VfxCmd.slashPath:
                // if (ModConfig.KeepSlashVfx)
                //     return true;

                __result = emptyReplacementPath;
                return false;
        }

        return true;
    }
}

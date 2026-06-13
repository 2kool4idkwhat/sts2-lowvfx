using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Rooms;

namespace LowVFX;

// disable the sandfalls in the insatiable's background
[HarmonyPatch(typeof(NCombatBackground), nameof(NCombatBackground.Create))]
public static class NCombatBackground_Sandfalls_Patch
{
    public static void Postfix(NCombatBackground __result)
    {
        if (ModConfig.KeepInsatiableBgSandfalls)
            return;

        if (!__result.SceneFilePath.Contains("the_insatiable_boss"))
            return;

        MainFile.Logger.Info("Disabling sandfalls");

        for (var i = 1; i <= 9; i++)
        {
            var sandfall = __result.GetNodeOrNull<Node2D>($"gpu waterfall {i}");
            if (sandfall == null)
            {
                MainFile.Logger.Info($"Skipping sandfall {i}");
                continue;
            }

            sandfall.Visible = false;
            sandfall.ProcessMode = Node.ProcessModeEnum.Disabled;
        }
    }
}

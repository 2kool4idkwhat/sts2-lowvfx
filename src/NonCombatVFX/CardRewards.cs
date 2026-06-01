// disable the glow around uncommon/rare cards in card rewards (and a few other
// places like card potions)

using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Cards;

namespace LowVFX;

[HarmonyPatch(typeof(NCard), nameof(NCard.ActivateRewardScreenGlow))]
public static class NCard_Patch
{
    public static bool Prefix()
    {
        return false;
    }
}

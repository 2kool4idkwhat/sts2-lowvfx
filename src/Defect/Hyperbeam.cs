using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace LowVFX;

[HarmonyPatch(typeof(NHyperbeamVfx), "Create", new Type[] { typeof(Creature), typeof(Creature) })]
public static class NHyperbeamVfxPatch
{

    public static bool Prefix(ref NHyperbeamVfx? __result)
    {
        __result = null;
        return false;
    }

}

[HarmonyPatch(typeof(NHyperbeamImpactVfx), "Create", new Type[] { typeof(Creature), typeof(Creature) })]
public static class NHyperbeamImpactVfxPatch
{

    public static bool Prefix(ref NHyperbeamImpactVfx? __result)
    {
        __result = null;
        return false;
    }

}

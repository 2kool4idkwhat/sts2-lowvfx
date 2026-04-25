using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace LowVFX;

[HarmonyPatch(typeof(NTestSubjectBurnVfx), "Create")]
public static class NTestSubjectBurnVfx_Patch
{

    public static bool Prefix(ref NTestSubjectBurnVfx? __result)
    {
        __result = null;
        return false;
    }

}

[HarmonyPatch(typeof(NTestSubjectVfx), "StartBurnVfx")]
public static class NTestSubjectVfx_StartBurnVfx_Patch
{

    public static bool Prefix()
    {
        return false;
    }

}

[HarmonyPatch(typeof(NTestSubjectVfx), "StartDizzies")]
public static class NTestSubjectVfx_StartDizzies_Patch
{

    public static bool Prefix()
    {
        return false;
    }

}

[HarmonyPatch(typeof(NTestSubjectVfx), "StartCeilingSparks")]
public static class NTestSubjectVfx_StartCeilingSparks_Patch
{

    public static bool Prefix()
    {
        return false;
    }

}

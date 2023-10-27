using Il2Cpp;
using MelonLoader;
using HarmonyLib;

namespace NoCameraSway.src
{
    class Implementation : MelonMod
    {
        //
    }

    [HarmonyPatch(typeof(vp_FPSCamera), nameof(vp_FPSCamera.Start))]
    public static class vp_FPSCamera_Start
    {
        internal static void Postfix(ref vp_FPSCamera __instance)
        {
            __instance.m_MaxAmbientSwayAngleDegreesA = 0;
            __instance.m_AmbientAimingSwaySpeedA = 0;
        }
    }

}


using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using UnityEngine;
using System;

namespace NoCameraSway
{
    public class NoCameraSway : MelonMod
    {
        public override void OnInitializeMelon()
        {
            HarmonyInstance.PatchAll();
            MelonLogger.Msg("Static Camera Mod loaded");
        }
    }

    [HarmonyPatch(typeof(vp_FPSCamera), "Update")]
    public static class ForceStaticCamera
    {
        static void Postfix(vp_FPSCamera __instance)
        {
            if (__instance == null)
                return;
            __instance.m_CurrentAmbientSwaySpeed = 0.001f;
            __instance.m_CurrentMaxAmbientSwayAngle = 0.001f;
            __instance.m_MaxAmbientSwayAngleDegreesA = 0.001f;
        }
    }
}
using HarmonyLib;
using MelonLoader;

namespace NoCameraSway
{
    public class NoCameraSway : MelonMod
    {
        public override void OnInitializeMelon()
        {
            HarmonyInstance.PatchAll();
        }

        [HarmonyPatch(typeof(Il2Cpp.vp_FPSCamera), nameof(Il2Cpp.vp_FPSCamera.Awake))]
        private static class DisableCameraSway
        {
            internal static void Postfix(Il2Cpp.vp_FPSCamera __instance)
            {
                if (__instance == null)
                {
                    MelonLogger.Warning("vp_FPSCamera instance was null");
                    return;
                }

                Il2Cpp.vp_FPSCamera.m_DisableAmbientSway = true;

            }
        }
    }
}
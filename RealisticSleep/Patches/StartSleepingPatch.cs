using HarmonyLib;
using UnityEngine;

namespace RealisticSleep.Patches
{
    [HarmonyPatch(typeof(Build_Bed), nameof(Build_Bed.Sleeping))]
    public class StartSleepingPatch
    {
        static bool Prefix()
        {
            if (Time.timeScale != Mod.Instance.Config.SleepSpeed)
                Time.timeScale = Mod.Instance.Config.SleepSpeed;
            return true;
        }
    }
}

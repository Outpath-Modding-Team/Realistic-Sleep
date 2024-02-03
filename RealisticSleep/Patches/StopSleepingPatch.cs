using HarmonyLib;
using UnityEngine;

namespace RealisticSleep.Patches
{
    [HarmonyPatch(typeof(Build_Bed), nameof(Build_Bed.StopSleeping))]
    public class StopSleepingPatch
    {
        static bool Prefix()
        {
            Time.timeScale = 1f;
            return true;
        }
    }
}

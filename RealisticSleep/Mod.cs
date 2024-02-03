using HarmonyLib;
using Outpath_Modding.API.Mod;
using Outpath_Modding.GameConsole;
using System;

namespace RealisticSleep
{
    public class Mod : Mod<Config>
    {
        public override string Author { get; set; } = "MrAfitol";
        public override string Name { get; set; } = "Realistic Sleep";
        public override string Description { get; set; } = "A mod that adds a realistic sleep.";
        public override Version Version { get; set; } = new Version(1, 0, 0);

        private static readonly Harmony Harmony = new Harmony("com.outpath.realisticsleep");
        public static Mod Instance { get; private set; }

        public override void OnLoaded()
        {
            Instance = this;

            OnPatch();

            base.OnLoaded();
        }

        public override void OnUnloaded()
        {
            OnUnpatch();

            Instance = null;

            base.OnUnloaded();
        }

        public static void OnPatch()
        {
            try
            {
                Harmony.PatchAll();
            }
            catch (Exception ex)
            {
                Logger.Error("An error occurred during patching: \n" + ex.ToString());
            }
        }

        public static void OnUnpatch()
        {
            try
            {
                Harmony.UnpatchAll();
            }
            catch (Exception ex)
            {
                Logger.Error("An error occurred during unpatching: \n" + ex.ToString());
            }
        }

    }
}

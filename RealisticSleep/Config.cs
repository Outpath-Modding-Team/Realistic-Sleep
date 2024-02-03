using Outpath_Modding.API.Config;

namespace RealisticSleep
{
    public class Config : IConfig
    {
        public bool Enable { get; set; } = true;

        public float SleepSpeed { get; set; } = 2.5f;
    }
}

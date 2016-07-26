using Rocket.API;

namespace AutoDropsTimer
{
     public class AutoDropsConfig : IRocketPluginConfiguration
{
        public bool Enabled = true;
        public ushort SendInterval = 1200;

        public void LoadDefaults()
        {

        }
    }
}

using Rocket.API;

namespace AutoDropsTimer
{
     public class AutoDropsConfig : IRocketPluginConfiguration
{
        public bool Enabled;
        public ushort SendInterval;
        public string SendMsg;

        public void LoadDefaults()
        {
             Enabled = true; 
             SendInterval = 20; 
             SendMsg = "Automatic Airdrop Launched! Go catch it!";
        }
    }
}

using System;
using UnityEngine;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System.Collections.Generic;
using SDG.Unturned;

namespace AutoDropsTimer
{
    public class AutoDrop : RocketPlugin<AutoDropsConfig>
    {
        private DateTime lastCalled = DateTime.Now;

        protected override void Load()
        {
            Logger.LogWarning("\tPlugin Loaded Successfully");
            this.checkChat();
        }

        private void checkChat()
        {
            if ((DateTime.Now - this.lastCalled).TotalSeconds > 20)
            {
                SendChat();
                RunDrop();
                this.lastCalled = DateTime.Now;
                FixedUpdate();
            }
        }
        public static void SendChat()
        {
            UnturnedChat.Say("Automatic airdrop launched! Go catch it!");
        }

        public void RunDrop()
        {
            CommandAirdrop Type
        }

        public void FixedUpdate()
        {
            if ((DateTime.Now - this.lastCalled).TotalSeconds > 1)
            {
                checkChat();
            }
        }
    }
}
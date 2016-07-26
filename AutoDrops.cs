using System;
using UnityEngine;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Commands;
using System.Collections.Generic;
using SDG.Unturned;

namespace AutoDropsTimer
{
    public class AutoDrops : RocketPlugin<AutoDropsConfig>
    {
        private DateTime lastCalled = DateTime.Now;

        protected override void Load()
        {
            Logger.LogWarning("\tAutoDrops Loaded Successfully");
            checkChat();
        }

        protected override void Unload()
        {
            Logger.LogWarning("\tAutoDrops Unloaded Successfully");
        }

        private void checkChat()
        {
            if ((DateTime.Now - this.lastCalled).TotalSeconds > 1200)
            {
                SendMSG();
                RunDrop();
                this.lastCalled = DateTime.Now;
                FixedUpdate();
            }
        }
        public static void SendMSG()
        {
            UnturnedChat.Say("Automatic airdrop launched! Go catch it!");
        }

        public void RunDrop()
        {
            CommandWindow.ConsoleInput.onInputText.Invoke("airdrop");
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

using System.Collections.Generic;
using Oxide.Core.Plugins;

namespace Oxide.Plugins
{
    [Info("RespawnMessages", "PapaRust", "1.0.1")]
    [Description("Sends a random respawn message to the player when they respawn")]

    class RespawnMessages : RustPlugin
    {
        private List<string> respawnMessages;

        class PluginConfig
        {
            public List<string> RespawnMessages { get; set; }
        }

        private PluginConfig config;

        protected override void LoadDefaultConfig()
        {
            Config.WriteObject(new PluginConfig
            {
                RespawnMessages = new List<string>
                {
                    "Rise and shine, sleeping beauty!",
                    "Back so soon?",
                    // Add more default messages as needed
                }
            }, true);
        }

        private void Init()
        {
            config = Config.ReadObject<PluginConfig>();
            respawnMessages = config.RespawnMessages;
            Puts("RespawnMessages has been loaded");
        }

        private void Unload()
        {
            Puts("RespawnMessages has been unloaded");
        }

        private void OnPlayerRespawned(BasePlayer player)
        {
            if (player == null) return;

            int index = UnityEngine.Random.Range(0, respawnMessages.Count);
            string message = respawnMessages[index];

            SendReply(player, message);
        }
    }
}

# RespawnMessages
A Rust server plugin written in C# that greets players with pre-defined messages when they respawn in-game.

# Overview
TheRespawnMessages plugin is a Rust server plugin for the Oxide framework that sends a random respawn message to players when they respawn. The messages are pulled from a configurable list stored in a JSON configuration file.

# Installation
Make sure you have the Oxide framework installed on your Rust server. You can download it from here.
Save the RespawnMessages.cs file in the oxide/plugins directory on your Rust server.
Restart your Rust server or run the oxide.reload RespawnMessages command in the server console.
# Configuration
The plugin uses a RespawnMessages.json configuration file to store the list of possible messages to send to players when they respawn. The JSON file is automatically created in the oxide/config directory when the plugin is loaded for the first time. If the file already exists, the plugin will read the list of messages from it.

Here is an example of the JSON configuration file:
```
{
  "RespawnMessages": [
    "Rise and shine, sleeping beauty!",
    "Back so soon?",
    // Add more messages here
  ]
}
```

To add or modify the list of messages, edit the RespawnMessages array in the JSON file. The plugin will use these messages when sending respawn messages to players.

# Features
Sends a random respawn message to players when they respawn.
Messages are loaded from a configurable list in the RespawnMessages.json file.
Only the respawning player can see the message. Other players on the server will not see it.
# Event Handlers
OnPlayerRespawned(BasePlayer player): This function is called when a player respawns in the game. The function chooses a random message from the respawnMessages list and sends it to the respawning player using the SendReply function.
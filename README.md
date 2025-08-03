![](https://i.imgur.com/50GrY3m.png)

# TweakTheirPermissions
Plugin for LabAPI that tweaks default LabAPI permissions provider (changes the way the player's group is defined)
# Installation
Put plugin dll from [releases](https://github.com/CosmosZvezdo4kin/TweakTheirPermissions/releases/latest) in `LabAPI/plugins/...`

Put `0Harmony.dll` from [releases](https://github.com/CosmosZvezdo4kin/TweakTheirPermissions/releases/latest) in `LabAPI/dependencies/...`
# FAQ
> **Why does this plugin even exist ?**
>
> By default LabAPI checks permissions via `PermissionsGroupName` (the group given to the player via the `config_remoteadmin.txt` file) because of which when using other methods of giving permissions to the player (for example, synchronization via Discord or using the setgroup command) the player does not have the appropriate permissions. This plugin checks player permissions via `UserGroup`

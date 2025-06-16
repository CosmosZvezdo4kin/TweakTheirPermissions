using HarmonyLib;
using LabApi.Features.Permissions.Providers;
using LabApi.Features.Wrappers;

namespace TweakTheirPermissions.Patches;

[HarmonyPatch(typeof(DefaultPermissionsProvider), nameof(DefaultPermissionsProvider.GetPlayerGroup))]
public class GetPlayerGroup
{
    public static bool Prefix(DefaultPermissionsProvider __instance, Player player, ref PermissionGroup __result)
    {
        var groupName = player.UserGroup?.Name ?? "default";

        __result = __instance._permissionsDictionary.TryGetValue(groupName, out var permissionGroup) ? permissionGroup : 
            groupName != "default" && __instance._permissionsDictionary.TryGetValue("default", out permissionGroup) ? permissionGroup : PermissionGroup.Default;
        return false;
    }
}
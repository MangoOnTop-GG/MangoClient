using GorillaNetworking;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using StupidTemplate.Mods.StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Safety", method =() => SettingsMods.Safety(), isTogglable = false, toolTip = "Opens the safety page for the menu."},
                new ButtonInfo { buttonText = "Room", method =() => SettingsMods.Room(), isTogglable = false, toolTip = "Opens the room page for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.Movement(), isTogglable = false, toolTip = "Opens the movement page for the menu."},
                new ButtonInfo { buttonText = "Advantages", method =() => SettingsMods.Adv(), isTogglable = false, toolTip = "Opens the advantages page for the menu."},
                new ButtonInfo { buttonText = "VRRig", method =() => SettingsMods.Rig(), isTogglable = false, toolTip = "Opens the rig page for the menu."},
                new ButtonInfo { buttonText = "Overpowered", method =() => SettingsMods.OP(), isTogglable = false, toolTip = "Opens the Overpowered page for the menu."},
                new ButtonInfo { buttonText = "Credits", method =() => SettingsMods.Credits(), isTogglable = false, toolTip = "Opens the credits page for the menu."},
            },
            
            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
            new ButtonInfo[] { // Important/Safety
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the main page of the menu."},
                new ButtonInfo { buttonText = "Quit Gorilla Tag", method =() => UnityEngine.Application.Quit(), isTogglable = false, toolTip = "Quits The Game"},
                new ButtonInfo { buttonText = "Trigger Disconnect", method =() => Safety.TriggerDisconnect(), isTogglable = true, toolTip = "Disconnects you when clicking trigger"},
            },
            new ButtonInfo[] { // Room
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the main page of the menu."},
                new ButtonInfo { buttonText = "Disconnect", method =() => NetworkSystem.Instance.ReturnToSinglePlayer(), isTogglable = false, toolTip = "Disconnects you from the room."},
                new ButtonInfo { buttonText = "Join Menu Code", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("$mangoclientontop!", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Mango Client Code"},
                new ButtonInfo { buttonText = "Join Hamburbur Code", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("[hamburbur_menu]", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Hamburbur Menu Code"},
                new ButtonInfo { buttonText = "Join Seralyth Code", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("<$SERALYTH_5.0.1>", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Seralyth Menu Code"},
                new ButtonInfo { buttonText = "Join Code Femboy", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("FEMBOY", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code Femboy"},
                new ButtonInfo { buttonText = "Join Code Furry", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("FURRY", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code FURRY"},
                new ButtonInfo { buttonText = "Join Code Mod", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("MOD", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code Mod"},
                new ButtonInfo { buttonText = "Join Code Mods", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("MODS", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code Mods"},
                new ButtonInfo { buttonText = "Join Code Modding", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("MODDING", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code Modding"},
                new ButtonInfo { buttonText = "Join Code Gay", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("GAY", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code GAY" },
                new ButtonInfo { buttonText = "Join Code K9", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("K9", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code K9" },
                new ButtonInfo { buttonText = "Join Code J3VU", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("J3VU", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code J3VU" },
                new ButtonInfo { buttonText = "Join Code Statue", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("STATUE", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code Statue" },
                new ButtonInfo { buttonText = "Join Code PBBV", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("PBBV", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code PBBV" },
                new ButtonInfo { buttonText = "Join Code Hard R", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("NIGGER", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code N-Word Hard R" },
                new ButtonInfo { buttonText = "Join Code Soft A", method =() => PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("NIGGA", JoinType.Solo), isTogglable = false, toolTip = "Attempts To Join The Code N-Word Hard R" },
            },
            new ButtonInfo[] { // Movement
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the main page of the menu."},
                new ButtonInfo { buttonText = "Speedboost", method = () => Movement.Speedboost(), toolTip = "Makes you have a boost of speed" },
                new ButtonInfo { buttonText = "MosaBoost", method = () => Movement.MosaBoost(), toolTip = "Makes you have a boost of speed" },
                new ButtonInfo { buttonText = "Fly [<color=green>A</color>]", method = () => Movement.Fly(), toolTip = "Makes you fly forward while holding A" },
                new ButtonInfo { buttonText = "Platforms [<color=green>G</color>]", method = () => Movement.Platforms(), toolTip = "Makes you have a platform when you hold grip" },
                new ButtonInfo { buttonText = "Noclip [<color=green>RT</color>]", method = () => Movement.Noclip(), isTogglable = true, toolTip = "Allows you to move through objects" },
                new ButtonInfo { buttonText = "Trigger Platforms [<color=green>T</color>]", method = () => Movement.TriggerPlatforms(), toolTip = "Makes you have a platform when you hold trigger" },
                new ButtonInfo { buttonText = "Teleport Gun [<color=yellow>G & RT</color>]", method = () => Movement.TeleportGun(), toolTip = "Makes you Teleport To Where Your Hand Goes To With The Gun" },
                new ButtonInfo { buttonText = "Long Arms", enableMethod =() => Movement.EnableSteamArms(), disableMethod =() => Movement.DisableSteamArms(), toolTip = "gives you longer arms"},
                new ButtonInfo { buttonText = "Comp Arms", enableMethod =() => Movement.EnableCompArms(), disableMethod =() => Movement.DisableCompArms(), toolTip = "gives you long arms that comp players have"},
            },
            new ButtonInfo[] { // Advantages
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the main page of the menu."},
                new ButtonInfo { buttonText = "Tag Gun", method =() => Advantage.TagGun(), isTogglable = true, toolTip = "Tags the player on who ever the gun lands on"},
                new ButtonInfo { buttonText = "Tag All", method =() => Advantage.TagAll(), isTogglable = false, toolTip = "Tags Everyone in the room you are in"},
                new ButtonInfo { buttonText = "Insta Tag All", method =() => Advantage.InstaTagAll(), isTogglable = true, toolTip = "Tags Everyone in the room you are in But it's faster."},
                new ButtonInfo { buttonText = "Insta Tag Gun", method =() => Advantage.InstaTagGun(), isTogglable = true, toolTip = "Tags the player on who ever the gun landed on But it's faster."},
                new ButtonInfo { buttonText = "Tag Self", method =() => Advantage.TagSelf(), isTogglable = true, toolTip = "Force Tags yourself"},
                new ButtonInfo { buttonText = "Fix Rig", method =() => Advantage.FixRig(), isTogglable = false, toolTip = "Click This Only After You Tag All Or Tag Gun."},
                new ButtonInfo { buttonText = "Box ESP", method =() => Advantage.BoxESP(), isTogglable = true, toolTip = "Puts a box around all players so you can see them"},
            },
            new ButtonInfo[] { // VRRig
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the main page of the menu."},
            },
            new ButtonInfo[] { // Overpowered/Exploits
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the main page of the menu."},
                new ButtonInfo { buttonText = "Grey Screen All", method =() => Overpowered.GreyScreenAll(), isTogglable = true, toolTip = "Makes People Screen Go Gray If You Have Master" },
                new ButtonInfo { buttonText = "Party Kicker", method =() => Overpowered.PartyKicker(), isTogglable = false, toolTip = "Kicks The People That Are In The Party"},
                new ButtonInfo { buttonText = "Party KickerHardR", method =() => Overpowered.PartyKickerHardR(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into the Code N Word Hard R"},
                new ButtonInfo { buttonText = "Party KickerMangoOnTop", method =() => Overpowered.PartyKickerMangoOnTop(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code MangoOnTop"},
                new ButtonInfo { buttonText = "Party KickerMINI99", method =() => Overpowered.PartyKickerMINI99(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code MINI99"},
                new ButtonInfo { buttonText = "Party KickerFuck", method =() => Overpowered.PartyKickerFuck(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code FUCK"},
                new ButtonInfo { buttonText = "Party KickerModdedCode", method =() => Overpowered.PartyKickerModdedCode(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into My Modded Code"},
                new ButtonInfo { buttonText = "Party KickerKKK", method =() => Overpowered.PartyKickerKKK(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code KKK"},
                new ButtonInfo { buttonText = "Party KickerShit", method =() => Overpowered.PartyKickerShit(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code Shit"},
                new ButtonInfo { buttonText = "Party KickerSoftA", method =() => Overpowered.PartyKickerSoftA(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code N Word Soft A"},
                new ButtonInfo { buttonText = "Party KickerMods", method =() => Overpowered.PartyKickerMods(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code Mods"},
                new ButtonInfo { buttonText = "Party KickerMod", method =() => Overpowered.PartyKickerMod(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code Mod"},
                new ButtonInfo { buttonText = "Party KickerModding", method =() => Overpowered.PartyKickerModding(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code Moddng"},
                new ButtonInfo { buttonText = "Party KickerFurry", method =() => Overpowered.PartyKickerFurry(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code Furry"},
                new ButtonInfo { buttonText = "Party KickerGay", method =() => Overpowered.PartyKickerGay(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code Gay"},
                new ButtonInfo { buttonText = "Party KickerFemboy", method =() => Overpowered.PartyKickerFemboy(), isTogglable = false, toolTip = "Kicks The People That Are In The Party Into The Code Femboy"},
            },
            new ButtonInfo[] { // Fun/Misc
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = true, toolTip = "Opens the main page of the menu."},

            },
            new ButtonInfo[] { // Credits
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the main page of the menu."},
                new ButtonInfo { buttonText = "MangoVRYT", method =() => UnityEngine.Application.OpenURL("https://guns.lol/mangoytplayz, https://github.com/MangoOnTop-GG"), isTogglable = false, toolTip = "OWNER OF MENU AND MADE MADE SOME CODE"},
                new ButtonInfo { buttonText = "Velx", method =() => UnityEngine.Application.OpenURL("https://www.youtube.com/@velxthegorilla"), isTogglable = false, toolTip = "Made this temp that is II temp but remade and fixed and better also helped with Platforms, Fly, And Speedboost"},
                new ButtonInfo { buttonText = "Notmonk", method =() => UnityEngine.Application.OpenURL("https://gtag.lol/notmonk"), isTogglable = false, toolTip = "He helped me fix so errors and helps code so thanks to him"},
                new ButtonInfo { buttonText = "Malachi", isTogglable = false, toolTip = "Used NoClip script from Malachi Temp and changed it some"},
                new ButtonInfo { buttonText = "Visual", method =() => UnityEngine.Application.OpenURL("https://guns.lol/personvr/"), isTogglable = false, toolTip = "Helped And Gave Me Code For Gradient text\r\n"},
            },
        };
    }
}

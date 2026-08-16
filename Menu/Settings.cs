using StupidTemplate.Classes;
using UnityEngine;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate
{
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient{colors=GetSolidGradient(Color.purple)};
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(Color.pink) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(Color.hotPink) }, // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };

        public static Font currentFont = (Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font);

        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.LeftAlt;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 8;

    }
}

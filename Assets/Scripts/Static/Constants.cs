using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Static
{
    public static class Constants
    {
        public static readonly List<string> Directions = new List<string>()
        {
            "Left",
            "Right",
            "Up",
            "Down",
        };

        public static readonly Dictionary<string, Vector2> VectorDirections = new Dictionary<string, Vector2>()
        {
            {"Up", Vector2.up},
            {"Down", Vector2.down},
            {"Left", Vector2.left},
            {"Right", Vector2.right}
        };

        public static Dictionary<string, string> KeysUp = new Dictionary<string, string>()
        {
            {"LeftIsUp", "Left"},
            {"RightIsUp", "Right"},
            {"UpIsUp", "Up"},
            {"DownIsUp", "Down"}
        };

        public static Dictionary<string, string> AttackDirections = new Dictionary<string, string>()
        {
            {"Left", "SwordSwingLeft"},
            {"Right", "SwordSwingRight"},
            {"Up", "SwordSwingUp"},
            {"Down", "SwordSwingDown"}
        };

        public const string Left = "Left";
        public const string Right = "Right";
        public const string Up = "Up";
        public const string Down = "Down";

        public const string LeftKeyUp = "LeftIsUp";
        public const string RightKeyUp = "RightIsUp";
        public const string UpKeyUp = "UpIsUp";
        public const string DownKeyUp = "DownIsUp";

        public const string Attack = "Space";

        public const string NoneKey = "None";
    }
}
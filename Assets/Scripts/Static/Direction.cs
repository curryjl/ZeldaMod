using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Static
{
    public static class Direction
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

        public static string Left = "Left";
        public static string Right = "Right";
        public static string Up = "Up";
        public static string Down = "Down";

        public static string LeftKeyUp = "LeftIsUp";
        public static string RightKeyUp = "RightIsUp";
        public static string UpKeyUp = "UpIsUp";
        public static string DownKeyUp = "DownIsUp";

        public static string NoneKey = "None";
    }
}
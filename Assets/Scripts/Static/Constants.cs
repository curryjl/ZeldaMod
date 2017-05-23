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

        public static readonly Vector2[] WisdomRoomPositions = new Vector2[]
        {
            new Vector2(-20f, 0f),
            new Vector2(-20f, 1.7f),
            new Vector2(-17.41f, 1.692f),
            new Vector2(-22.59f, 1.692f),
            new Vector2(-14.85f, 1.692f),
            new Vector2(-17.4f, 3.41f),
            new Vector2(-14.85f, 3.41f),
            new Vector2(-17.39f, 5.11f),
            new Vector2(-14.84f, 5.11f),
            new Vector2(-17.35f, 6.84f),
            new Vector2(-14.8f, 6.84f),
            new Vector2(-17.367f, 8.543f),
            new Vector2(-14.837f, 8.543f),
            new Vector2(-17.365f, 10.237f),
            new Vector2(-14.818f, 10.237f),
            new Vector2(-17.38f, 11.92f),
            new Vector2(-19.93f, 11.92f)
        };

        public static readonly Dictionary<string, Vector2> VectorByDirection = new Dictionary<string, Vector2>()
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

        public static readonly Dictionary<string, string> AttackAnimationByDirection = new Dictionary<string, string>()
        {
            {"Left", "SwordSwingLeft"},
            {"Right", "SwordSwingRight"},
            {"Up", "SwordSwingUp"},
            {"Down", "SwordSwingDown"}
        };

        public const int WisdomRoomCount = 17;

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
        public const string ChoiceRoom = "ChoiceRoom";

        public const string DungeonTag = "Dungeon";

        public static readonly Dictionary<string, Vector2> PositionByWisdomRooms = new Dictionary<string, Vector2>()
        {
            {"WisdomRoomEntrance", new Vector2(-20f, -0.436f)},
            {"WR1TO2", new Vector3(-20f, 1.096f)},
            {"WR2TO1", new Vector3(-20f, 1.096f)}

        };

        public static readonly Dictionary<GameObject, Vector3> CameraPositionByRoom = new Dictionary<GameObject, Vector3>()
        {
                
        };

        public const string WisdomRoomEntrance = "WisdomRoomEntrance";
        public const string WisdomRoom1To2 = "WR1TO2";
        public const string WisdomRoom2To1 = "WR2TO1";

        public static readonly Vector3 PlayerStartPosition = new Vector3(0f, -.5f, 0f);
    }
}
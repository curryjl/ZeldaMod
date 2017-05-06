using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Direction
{
    public static List<string> KeysDown = new List<string>()
    {
        "Left",
        "Right",
        "Up",
        "Down",
    };

    public static Dictionary<string, string> KeysUp = new Dictionary<string, string>()
    {
        {"LeftIsUp", "Left"},
        {"RightIsUp", "Right"},
        {"UpIsUp", "Up"},
        {"DownIsUp", "Down"}
    };

    public static string LeftKeyDown = "Left";
    public static string RightKeyDown = "Right";
    public static string UpKeyDown = "Up";
    public static string DownKeyDown = "Down";

    public static string LeftKeyUp = "LeftIsUp";
    public static string RightKeyUp = "RightIsUp";
    public static string UpKeyUp = "UpIsUp";
    public static string DownKeyUp = "DownIsUp";

    public static string NoneKey = "None";
}

using System.Collections.Generic;
using Assets.Scripts.Static;
using UnityEngine;

namespace Assets.Scripts.Singletons
{
    public class Player : MonoBehaviour
    {
        public static Player Instance { get; private set; }

        public string Input = Constants.NoneKey;
        public string LastDirectionalInput = Constants.NoneKey;
        public int Health = 3;

        public Dictionary<string, bool> MoveableDirections = new Dictionary<string, bool>()
        {
            {"Up", true},
            {"Down", true},
            {"Left", true},
            {"Right", true}
        };

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);
        }
    }
}
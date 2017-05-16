using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Static;
using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class DungeonManager : MonoBehaviour
    {
        public GameObject[] WisdomDungeon = new GameObject[Constants.WisdomRoomCount];
        public readonly Dictionary<GameObject, Vector2> WisdomRoomsByPosition = new Dictionary<GameObject, Vector2>();

        void Awake()
        {
            InitializeRooms();
        }

        private void InitializeRooms()
        {
            for (int i = 0; i < Constants.WisdomRoomCount; i++)
            {
                WisdomRoomsByPosition.Add(WisdomDungeon[i], Constants.WisdomRoomPositions[i]);
            }
        }
    }
}

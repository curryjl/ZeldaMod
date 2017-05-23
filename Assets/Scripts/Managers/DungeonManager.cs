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
        private GameObject _choiceRoom;
        private GameObject _currentRoom;
        private readonly GameObject[] _wisdomDungeon = new GameObject[Constants.WisdomRoomCount];

        public static DungeonManager Instance { get; private set; }



        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);

            _choiceRoom = GameObject.Find("ChoiceRoom");
            for (var i = 0; i < Constants.WisdomRoomCount; i++)
                _wisdomDungeon[i] = GameObject.Find("WisdomDungeon").transform.GetChild(i).gameObject;

            DisableRooms();
            _currentRoom = _choiceRoom;
        }

        private void DisableRooms()
        {
            foreach (var room in _wisdomDungeon)
                room.gameObject.SetActive(false);
        }

        public void UpdateCurrentRoom(string room)
        {
            switch (room)
            {
                case "WisdomRoomEntrance":
                    _currentRoom.SetActive(false);
                    _currentRoom = _wisdomDungeon[0];
                    _currentRoom.SetActive(true);
                    break;
                case Constants.WisdomRoom1To2:
                    _currentRoom.SetActive(false);
                    _currentRoom = _wisdomDungeon[1];
                    _currentRoom.SetActive(true);
                    break;
                default:
                    break;
            }
        }
    }
}

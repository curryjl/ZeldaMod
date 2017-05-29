using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Design;
using Assets.Scripts.Singletons;
using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class DungeonManager : MonoBehaviour
    {
        private GameObject _currentRoom;
        private Dungeon _wisdomDungeon;
        private string _collision;

        public GameObject ChoiceRoom;

        public static DungeonManager Instance { get; private set; }

        private readonly List<string> _doors = new List<string>() { "NorthDoor", "SouthDoor", "WestDoor", "EastDoor" };

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);
            InitializeDungeon();
        }

        void Update()
        {
            MonitorCollision();
        }

        void OnApplicationQuit()
        {
            ChoiceRoom.SetActive(true);
        }

        public void SetCollision(string collision)
        {
            _collision = collision;
        }

        private void InitializeDungeon()
        {
            _wisdomDungeon = GameObject.Find("WisdomDungeon").GetComponent<Dungeon>();
            DisableRooms();

            _currentRoom = ChoiceRoom;
        }

        private void DisableRooms()
        {
            foreach (var wisdomDungeonRoom in _wisdomDungeon.Rooms)
                wisdomDungeonRoom.SetActive(false);
        }

        private void MonitorCollision()
        {
            var doors = _currentRoom.GetComponentsInChildren<Door>();


            switch (_collision)
            {
                case "WisdomRoomEntrance":
                    SetDungeonRoom(_currentRoom.GetComponentInChildren<Door>().ConnectedRoom, _collision);
                    break;
                default:
                    break;
            }

            if (_doors.Contains(_collision))
            {
                var door = doors.FirstOrDefault(x => x.name == _collision);
                if (door != null)
                    SetDungeonRoom(door.ConnectedRoom, _collision);
            }

            _collision = string.Empty;
        }

        private void SetDungeonRoom(GameObject connectedRoom, string doorHit)
        {
            _currentRoom.SetActive(false);
            _currentRoom = _wisdomDungeon.Rooms.FirstOrDefault(x => x.name == connectedRoom.name);

            if (_currentRoom != null)
            {
                _currentRoom.SetActive(true);
                _currentRoom.GetComponent<Room>().Player = Player.Instance.gameObject;

                SetCameraPosition(new Vector3(_currentRoom.transform.position.x, _currentRoom.transform.position.y, -10f));

                // Special Case
                if (doorHit == "WisdomRoomEntrance")
                    SetPlayerPositionInRoom(new Vector3(-20f, -0.436f));
            }
        }

        private void SetPlayerPositionInRoom(Vector3 position)
        {
            Player.Instance.transform.position = position;
        }

        private void SetCameraPosition(Vector3 cameraPosition)
        {
            GameManager.Instance.MainCamera.transform.position = cameraPosition;
        }
    }
}

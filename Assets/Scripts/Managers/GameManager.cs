using Assets.Scripts.Static;
using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class GameManager : MonoBehaviour
    {
        public GameObject Dungeon;
        public GameObject Player;
        public GameObject MainCamera;


        public static GameManager Instance { get; private set; }


        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);


            InstantiateDungeon();
            InstantiatePlayer();
            ConnectCameraToGameManager();
        }

        private void InstantiateDungeon()
        {
            Instantiate(Dungeon, Vector3.zero, Quaternion.identity);
        }

        private void InstantiatePlayer()
        {
            Instantiate(Player, Constants.PlayerStartPosition, Quaternion.identity);
        }

        private void ConnectCameraToGameManager()
        {
            MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        }
    }
}
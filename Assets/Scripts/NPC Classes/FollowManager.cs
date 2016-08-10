using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class FollowManager:MonoBehaviour
    {
        GameObject[] _tempPlayer;
        static List<Transform> _players;

        Transform playerToFollow;

        void Awake()
        {
            _players = new List<Transform>();
        }

        void Start()
        {
            _tempPlayer = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject go in _tempPlayer)
            {
                if (go.HasTag("Player"))
                {
                    _players.Add(go.transform);
                }
            }
        }
        public void Update()
        {
            if (_tempPlayer.Length == 0)
            {
                _tempPlayer = GameObject.FindGameObjectsWithTag("Player");
                foreach (GameObject go in _tempPlayer)
                {
                    if (go.HasTag("Player"))
                    {
                        _players.Add(go.transform);
                    }
                }
            }
        }
        public Transform GetPlayerToFollow(Transform npc)
        {
            /*
            Get all players that RayCast = true and return the Transform to NPC
            */
            foreach (Transform go in _players)
            {
                if (Physics.Linecast(npc.position, go.position))
                {
                    return go;
                }
            }
            return null;
        }
    }
}

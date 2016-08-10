using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.Player;

namespace Assets.Scripts.NPC
{
    class NPCFollowManager:MonoBehaviour
    {
        /*TODONetwork
        Once networking is added will have to update this as people enter and leave scene
        */
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
            if(_tempPlayer.Length == 0)
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
            //TODONetwork need to update to return a list once network is added.
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

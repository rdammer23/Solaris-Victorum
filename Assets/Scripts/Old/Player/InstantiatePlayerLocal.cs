using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class InstantiatePlayerLocal:MonoBehaviour
    {
        public GameObject player = null;

        private void Start()
        {
            UnityEngine.GameObject.Instantiate(player, new Vector3(0, 0, -400), Quaternion.identity);
        }
    }
}

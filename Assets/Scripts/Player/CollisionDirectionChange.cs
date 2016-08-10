using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class CollisionDirectionChange:MonoBehaviour
    {
        private GameObject player;

        public void CollissionHappened()
        {
            player = GameObject.FindWithTag("Player");
            //Debug.Log(player.transform.name);
            player.transform.localPosition -= (Vector3.forward * 5);
            player.transform.rotation = UnityEngine.Random.rotationUniform;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class CameraFollow:MonoBehaviour
    {
        GameObject camera;
        public Vector3 offset;

        void Start()
        {
            camera = GameObject.FindWithTag("MainCamera");
            offset = new Vector3(-0,-250,50);
        }

        void Update()
        {
            camera.transform.position = transform.position - offset;
        }
    }
}

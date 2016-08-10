using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Moon_Classes
{
    class MoonOrbit:MonoBehaviour
    {
        private float defaultMoonOrbitSpeed = 80f;
        private float moonOrbitSpeed;
        private int jumpInTime = 3; //this is used on startup to seperate orbits

        void Start()
        {
            moonOrbitSpeed = Math.Abs((100 / (this.transform.position.x * 2)) * defaultMoonOrbitSpeed);
            for (int i = 0; i < jumpInTime; i++)
            {
                this.transform.RotateAround(this.transform.parent.position, new Vector3(0, 1, 0), moonOrbitSpeed * 10000);
            }
        }

        void Update()
        {
            this.transform.RotateAround(this.transform.parent.position, new Vector3(0, 1, 0), moonOrbitSpeed * Time.deltaTime);
        }
    }
}

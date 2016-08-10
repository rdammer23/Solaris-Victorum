using System;
using UnityEngine;

namespace Assets.Scripts.Planet_Classes
{
    class PlanetOrbit:MonoBehaviour
    {
        private float defaultPlanetOrbitSpeed = 500f;
        
        private float planetOrbitSpeed;

        void Start()
        {
            planetOrbitSpeed = Math.Abs((1 / (this.transform.position.x)) * defaultPlanetOrbitSpeed);
        }

        void Update()
        {
            this.transform.RotateAround(this.transform.parent.position, new Vector3(0, 1, 0), planetOrbitSpeed * Time.deltaTime);
        }
    }
}

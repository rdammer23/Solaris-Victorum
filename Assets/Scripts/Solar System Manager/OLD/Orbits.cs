using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Solar_System_Manager
{
    //THIS IS NOT USED ANYLONGER
    class Orbits:MonoBehaviour
    {
        static bool ifPlanetOrbit = false;
        static bool ifMoonOrbit = false;

        static GameObject[] planets;
        static GameObject[] moons;

        public Transform star;

        private float defaultPlanetOrbitSpeed = 500f;
        private float defaultMoonOrbitSpeed = 5000f;

        private float planetOrbitSpeed;
        private float moonOrbitSpeed;

        public void OnEnable()
        {
            planets = GameObject.FindGameObjectsWithTag("Planet");
            moons = GameObject.FindGameObjectsWithTag("Moon");
            
        }

        public void Update()
        {
            if (ifPlanetOrbit)
            {
                foreach (GameObject p in planets)
                {
                    planetOrbitSpeed = defaultPlanetOrbitSpeed / Vector3.Distance(p.transform.parent.transform.position, star.position);
                    p.transform.parent.RotateAround(star.position, new Vector3(0, 1, 0), planetOrbitSpeed * Time.deltaTime);
                }
            }

            if (ifMoonOrbit)
            {
                foreach (GameObject m in moons)
                {
                    var planetLocation = m.transform.parent.transform.parent.transform;
                    //moonOrbitSpeed = defaultMoonOrbitSpeed / Vector3.Distance(m.transform.parent.transform.position, planetLocation.position);
                    moonOrbitSpeed = defaultMoonOrbitSpeed / (planetLocation.transform.position.x - m.transform.parent.position.x);
                    m.transform.parent.RotateAround(planetLocation.position, new Vector3(0, 1, 0), moonOrbitSpeed * Time.deltaTime);
                }
            }
        }
    }
}

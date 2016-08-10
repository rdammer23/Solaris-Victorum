/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BeardedManStudios.Network;
using Assets.Scripts.Planet;
using Assets.Scripts.SolarSystem;

namespace Assets.Scripts.Moon {
    class MoonManager:SimpleNetworkedMonoBehavior {

        static string moonTexture;

        static bool isMoonsLoaded = false;

        static int numberOfMoons;
        static int currentNumMoonsLoaded = 0;

        SolarSystemManager _solarSystemManager;

        static Vector3 moonPosition;
        static Vector3 moonScale;
        Quaternion moonRotation = new Quaternion();

        public void Update() {
            if(isMoonsLoaded) {
                Debug.Log("From Moon Manager All Moons are Loaded");
                _solarSystemManager = new SolarSystemManager();
                _solarSystemManager.AllMoonsLoaded();
                isMoonsLoaded = false;
            }
        }

        public void InstantiateMoon(int moonSize, int moonLevel, float locationX,
    float locationY, float locationZ, int moonID, int numMoons) {
            MoonSizes _moonSize;
            MoonLevel _moonLevel;

            string moonName = moonID.ToString();
            numberOfMoons = numMoons;

            _moonSize = new MoonSizes();
            _moonLevel = new MoonLevel();

            GameObject moonTemplate = Resources.Load("MoonTemplate", typeof(GameObject)) as GameObject;

            moonPosition = new Vector3(locationX, locationY, locationZ);

            float finalMoonSize = _moonSize.MoonSize(moonSize);
            moonScale = new Vector3(finalMoonSize, finalMoonSize, finalMoonSize);
            moonTexture = _moonLevel.GetMoonTexture(moonLevel);
            moonRotation = new Quaternion(0, 0, 0, 0);

            if (NetworkingManager.Socket == null || NetworkingManager.Socket.Connected) {
                Networking.Instantiate(moonTemplate, moonName, moonPosition, moonRotation, NetworkReceivers.AllBuffered, MoonSpawned);
            }
            else {
                NetworkingManager.Instance.OwningNetWorker.connected += delegate () {
                    Networking.Instantiate(moonTemplate, moonName, moonPosition, moonRotation, NetworkReceivers.AllBuffered, MoonSpawned);


                };
            }
        }
        private void MoonSpawned(SimpleNetworkedMonoBehavior moonObject) {
            //            MoonAttributes _moonAttributes;
            //            _moonAttributes = new MoonAttributes();
          /*  Debug.Log("The Moon object " + moonObject.name + " has spawned at " +
                "X: " + moonObject.transform.position.x +
                "Y: " + moonObject.transform.position.y +
                "Z: " + moonObject.transform.position.z);
  
                currentNumMoonsLoaded += 1;

            if (currentNumMoonsLoaded == numberOfMoons) {
                isMoonsLoaded = true;
            }
        }

    }
}
*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BeardedManStudios.Network;
using Assets.Scripts.SolarSystem;

/*
Available Planet Scale: 10, 15, 20, 25, 30, 35, 40, 45





namespace Assets.Scripts.Planet {
    class PlanetManager: SimpleNetworkedMonoBehavior {

        static string planetTexture;

        static bool isPlanetsLoaded = false;

        static int numberOfPlanets;
        static int currentNumPlanetsLoaded = 0;

        SolarSystemManager _solarSystemManager;

        static Vector3 planetPosition;
        static Vector3 planetScale;
        Quaternion planetRotation = new Quaternion();

        protected override void OwnerUpdate()
        {
            base.OwnerUpdate();
        
            Debug.Log("In Update isPlanetsLoaded = " + isPlanetsLoaded);
            if (isPlanetsLoaded) {
                Debug.Log("First check PLanets Loaded");
                _solarSystemManager = new SolarSystemManager();
                Debug.Log("From Planet Manager All Planets are Loaded");
                _solarSystemManager.AllPlanetsLoaded();
                isPlanetsLoaded = false;
            }
        }

        public void InstantiatePlanet(int planetSize, int planetLevel, float locationX, 
            float locationY, float locationZ, int planetID, int numPlanets) {
            PlanetSizes _planetSize;
            PlanetLevel _planetLevel;

            string planetName = planetID.ToString();
            numberOfPlanets = numPlanets;

            _planetSize = new PlanetSizes();
            _planetLevel = new PlanetLevel();
            
            GameObject planetTemplate = Resources.Load("PlanetTemplate", typeof(GameObject)) as GameObject;

            planetPosition = new Vector3(locationX, locationY, locationZ);

            int finalPlanetSize = _planetSize.PlanetSize(planetSize);
            planetScale = new Vector3(finalPlanetSize, finalPlanetSize, finalPlanetSize);
            planetTexture = _planetLevel.GetPlanetTexture(planetLevel);
            planetRotation = new Quaternion(0, 0, 0, 0);

            if (NetworkingManager.Socket == null || NetworkingManager.Socket.Connected) {
                Networking.Instantiate(planetTemplate, planetName, planetPosition, planetRotation, NetworkReceivers.AllBuffered, PlanetSpawned);
            }
            else {
                NetworkingManager.Instance.OwningNetWorker.connected += delegate () {
                    Networking.Instantiate(planetTemplate, planetName, planetPosition, planetRotation, NetworkReceivers.AllBuffered, PlanetSpawned);
                    

                };
            }
        }

        private void PlanetSpawned(SimpleNetworkedMonoBehavior planetObject) {
            //            PlanetAttributes _planetAttributes;
            //            _planetAttributes = new PlanetAttributes();
        //    Debug.Log("The Planet object " + planetObject.name + " has spawned at " +
        //        "X: " + planetObject.transform.position.x +
        //        "Y: " + planetObject.transform.position.y +
        //        "Z: " + planetObject.transform.position.z);
            currentNumPlanetsLoaded += 1;
        //    Debug.Log("NUmber of Planets to load = " + numberOfPlanets);
        //    Debug.Log("Current # Planets Loaded = " + currentNumPlanetsLoaded);
            if (currentNumPlanetsLoaded == numberOfPlanets) {
                //isPlanetsLoaded = true;
                _solarSystemManager = new SolarSystemManager();
                Debug.Log("From Planet Manager All Planets are Loaded");
                _solarSystemManager.AllPlanetsLoaded();
                //isPlanetsLoaded = false;
                //_planetAttributes.SetPlanetAttributes(planetScale, planetTexture);
            }
        }
    }
}
*/
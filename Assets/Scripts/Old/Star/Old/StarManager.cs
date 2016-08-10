/*using UnityEngine;
using System.Collections;
using Assets.Scripts.SolarSystem;
using BeardedManStudios.Network;

namespace Assets.Scripts.Star {

    public class StarManager : SimpleNetworkedMonoBehavior {

        SolarSystemManager _solarSystemManager;

        static bool isStarsLoaded = false;

        string starType = null;
        GameObject localStar;
        public GameObject parentGameObject;
        GameObject[] tempGO;

        static int numberOfStars;
        static int currentNumStarsLoaded = 0;

        Vector3 starPosition;
        Quaternion starRotation = new Quaternion(0,0,0,0);
        StarTypes _starTypes;

        private void Update() {
            if (isStarsLoaded) {
                _solarSystemManager = new SolarSystemManager();
                _solarSystemManager.AllStarsLoaded();
                isStarsLoaded = false;
            }
        }

        public void InstantiateStars(int starType, float locationX, float locationY, float locationZ, int numStars, int solarSystemID) {
            string instanceName = solarSystemID.ToString();
            numberOfStars = numStars;
            _starTypes = new StarTypes();
            string starTypeString = _starTypes.StarTypeLookup(starType);
            starPosition = new Vector3(locationX, locationY, locationZ);

            GameObject instance = Resources.Load(starTypeString, typeof(GameObject)) as GameObject;
            localStar = instance;

            if (NetworkingManager.Socket == null || NetworkingManager.Socket.Connected) {
                Networking.Instantiate(localStar, instanceName, starPosition, starRotation,
                    NetworkReceivers.AllBuffered, StarSpawned);
            }
            else {
                NetworkingManager.Instance.OwningNetWorker.connected += delegate () {
                    Networking.Instantiate(localStar, instanceName, starPosition, starRotation, 
                        NetworkReceivers.AllBuffered, StarSpawned);
                };
            }
        }

 

        private void StarSpawned(SimpleNetworkedMonoBehavior starObject) {
            Debug.Log("The Star with ID " + starObject.name + " has spawned at " +
                "X: " + starObject.transform.position.x +
                "Y: " + starObject.transform.position.y +
                "Z: " + starObject.transform.position.z);
            currentNumStarsLoaded += 1;

            if(currentNumStarsLoaded == numberOfStars) {
                isStarsLoaded = true;
            }
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assets.Scripts.SolarSystem {
    class SolarSystem {
        private int solarSystemID;
        private int sceneID;
        private string solarSystemName;
        private int starType;
        private float locationX;
        private float locationY;
        private float locationZ;

        #region Get and Set
        public int SolarSystemID {
            get {
                return solarSystemID;
            }

            set {
                solarSystemID = value;
            }
        }

        public int SceneID {
            get {
                return sceneID;
            }

            set {
                sceneID = value;
            }
        }

        public string SolarSystemName {
            get {
                return solarSystemName;
            }

            set {
                solarSystemName = value;
            }
        }

        public int StarType {
            get {
                return starType;
            }

            set {
                starType = value;
            }
        }

        public float LocationX {
            get {
                return locationX;
            }

            set {
                locationX = value;
            }
        }

        public float LocationY {
            get {
                return locationY;
            }

            set {
                locationY = value;
            }
        }

        public float LocationZ {
            get {
                return locationZ;
            }

            set {
                locationZ = value;
            }
        }
        #endregion

        public SolarSystem(int solarSystemID, int sceneID, string solarSystemName, int starType, float locationX, float locationY, float locationZ) {
            this.solarSystemID = solarSystemID;
            this.sceneID = sceneID;
            this.solarSystemName = solarSystemName;
            this.starType = starType;
            this.locationX = locationX;
            this.locationY = locationY;
            this.locationZ = locationZ;
        }
    }
}

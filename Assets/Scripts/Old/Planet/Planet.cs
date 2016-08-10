using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet {
    class Planet {
        private int planetID;
        private int solarSystemID;
        private int planetSize;
        private int planetLevel;
        private float locationX;
        private float locationY;
        private float locationZ;

        public Planet(int planetID, int solarSystemID, int planetSize, int planetLevel, float locationX, float locationY, float locationZ) {
            this.planetID = planetID;
            this.solarSystemID = solarSystemID;
            this.planetSize = planetSize;
            this.planetLevel = planetLevel;
            this.locationX = locationX;
            this.locationY = locationY;
            this.locationZ = locationZ;
        }
        
        //Currently only used in Solar System Creation
        public Planet(int planetID, int planetSize, float locationX, float locationY, float locationZ)
        {
            this.planetID = planetID;
            this.planetSize = planetSize;
            this.locationX = locationX;
            this.locationY = locationY;
            this.locationZ = locationZ;
        }


        #region Get and Set
        public int PlanetID {
            get {
                return planetID;
            }

            set {
                planetID = value;
            }
        }

        public int SolarSystemID {
            get {
                return solarSystemID;
            }

            set {
                solarSystemID = value;
            }
        }

        public int PlanetSize {
            get {
                return planetSize;
            }

            set {
                planetSize = value;
            }
        }

        public int PlanetLevel {
            get {
                return planetLevel;
            }

            set {
                planetLevel = value;
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
    }
}

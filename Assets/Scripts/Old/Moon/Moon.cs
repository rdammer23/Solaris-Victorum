using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Moon {
    class Moon {
        private int moonID;
        private int planetID;
        private int moonSize;
        private int moonLevel;
        private float locationX;
        private float locationY;
        private float locationZ;

        public Moon(int moonID, int planetID, int moonSize, int moonLevel, float locationX, float locationY, float locationZ) {
            this.moonID = moonID;
            this.planetID = planetID;
            this.moonSize = moonSize;
            this.moonLevel = moonLevel;
            this.locationX = locationX;
            this.locationY = locationY;
            this.locationZ = locationZ;
        }

        public Moon(int moonID, int planetID, int moonSize, float locationX, float locationY, float locationZ)
        {
            this.moonID = moonID;
            this.planetID = planetID;
            this.moonSize = moonSize;
            this.locationX = locationX;
            this.locationY = locationY;
            this.locationZ = locationZ;
        }

        #region Get and Set
        public int MoonID {
            get {
                return moonID;
            }

            set {
                moonID = value;
            }
        }

        public int PlanetID {
            get {
                return planetID;
            }

            set {
                planetID = value;
            }
        }

        public int MoonSize {
            get {
                return moonSize;
            }

            set {
                moonSize = value;
            }
        }

        public int MoonLevel {
            get {
                return moonLevel;
            }

            set {
                moonLevel = value;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Ships {
    class Ship {
        private float mass;
        private float cargoWeight;

        #region Get and Set
        public float Mass {
            get {
                return mass;
            }

            set {
                mass = value;
                mass = 9999.99f;
            }
        }

        public float CargoWeight {
            get {
                return cargoWeight;
            }

            set {
                cargoWeight = value;
            }
        }
        #endregion

        public Ship(float mass) {
            this.Mass = mass;
        }

        public Ship(float mass, float cargoWeight) {
            this.mass = mass;
            this.cargoWeight = cargoWeight;
        }
    }
}

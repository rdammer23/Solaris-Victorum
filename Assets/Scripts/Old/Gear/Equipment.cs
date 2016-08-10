using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Gear {
    class Equipment {
        private float weight;
        private float space;
        private float topSpeed;
        private float acceleration;

        #region Get and Set
        public float Weight {
            get {
                return weight;
            }

            set {
                weight = value;
            }
        }

        public float Space {
            get {
                return space;
            }

            set {
                space = value;
            }
        }

        public float TopSpeed {
            get {
                return topSpeed;
            }

            set {
                topSpeed = value;
            }
        }

        public float Acceleration {
            get {
                return acceleration;
            }

            set {
                acceleration = value;
            }
        }
        #endregion

        public Equipment(float weight, float space, float topSpeed, float acceleration) {
            this.weight = weight;
            this.space = space;
            this.topSpeed = topSpeed;
            this.acceleration = acceleration;
        }
    }
}

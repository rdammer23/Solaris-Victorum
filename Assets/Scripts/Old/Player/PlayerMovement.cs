/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BeardedManStudios.Network;
using UnityEngine;
using Assets.Scripts.Ships;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Scripts.Player {
    class PlayerMovement: SimpleNetworkedMonoBehavior {
        static bool ifX = false;
        static int x = 0;

        static float moveForce = 25f;
        static float newThrottleValue = 0f;
        static float throttleValue = 0f;
        static float desiredThrottleValue;
        static float oldThrottleValue = 0f;
        static float throttleChange = 0f;

        static float turnRight = 0;
        float maxTurnRight = 10f;
        static float turnLeft = 0;
        float maxTurnLeft = 10f;
        static float turnUp = 0;
        float maxTurnUp = 10f;
        static float turnDown = 0;
        float maxTurnDown = 10f;
        static float turnSpeed = .01f;

        static float cyclesToTopSpeed;
        static float timeToSpeed;

        //static bool ifSpeedChange = false;
        static bool ifIncreaseSpeed = false;
        static bool ifDecreaseSpeed = false;

        static bool isTurnRight = false;
        static bool isTurnLeft = false;
        static bool isTurnUp = false;
        static bool isTurnDown = false;

        //public GameObject player;

        //Rigidbody myBody;

        static Vector3 pos;

        //Ship ship;

        void Start() {
            //myBody = this.GetComponent<Rigidbody>();

            //ship = new Ship(2f);
        }

        // void FixedUpdate() {
        protected override void OwnerUpdate() {
            base.OwnerUpdate();
            //Vector2 rotateVec = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;
            //myBody.AddForce(moveVec);




            // Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
            // transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);

            Turning();

            if (ifIncreaseSpeed) {
                IncreaseSpeed();
             }
            else if (ifDecreaseSpeed) {
                DecreaseSpeed();
            }
            else {
                MoveShipForward(throttleValue);
            }
        }

        public void IncreaseSpeed() {
            /*
            OldThrottle is only set to newThrottleValue if
                All ModifiedCyclesToTopSpeed Used......DONE
                or 
                if NewModifiedCyclesToTopSpeed < ModifiedCyclesToTopSpeed....NOT DONE
            Then Do calculation

            
            throttleChange = desiredThrottleValue - oldThrottleValue;
            timeToSpeed = TimeToSpeed(cyclesToTopSpeed, throttleChange);
            throttleValue += throttleChange / timeToSpeed;
            MoveShipForward(throttleValue);
            if(throttleValue >= desiredThrottleValue) {
                oldThrottleValue = desiredThrottleValue;
                throttleValue = desiredThrottleValue;
                ifIncreaseSpeed = false;
            }
        }

        public void DecreaseSpeed() {
            throttleChange = oldThrottleValue - desiredThrottleValue;
            timeToSpeed = TimeToSpeed(cyclesToTopSpeed, throttleChange);
            throttleValue -= throttleChange / timeToSpeed;
            MoveShipForward(throttleValue);
            if (throttleValue <= desiredThrottleValue) {
                oldThrottleValue = desiredThrottleValue;
                throttleValue = desiredThrottleValue;
                ifDecreaseSpeed = false;
            }
        }

        public void TimeToTopSpeed(float shipWeight, float cargoWeight, float moveForce) {
            if (shipWeight < 1) {
                shipWeight = 100f;
            }
            if (cargoWeight < 1) {
                cargoWeight = 100f;
            }
            cyclesToTopSpeed = (shipWeight + cargoWeight) / moveForce;
        }

        public float TimeToSpeed(float cyclesToTopSpeed, float throttleChange) {
            return cyclesToTopSpeed * throttleChange;
        }
  
        public void MoveShipForward(float throttleValue) {
            //TODO Need to add some error checking to prevent NAN, NAN, NAN
            Debug.Log(throttleValue + " throttle value");
            Debug.Log(moveForce + " moveForce");
            transform.localPosition += transform.forward * throttleValue * moveForce * Time.deltaTime;
        }

        public void Throttle_Changed(float newThrottleValue) {
            desiredThrottleValue = newThrottleValue;
            if(desiredThrottleValue > oldThrottleValue) {
                ifIncreaseSpeed = true;
                ifDecreaseSpeed = false;
            }
            else if (desiredThrottleValue < oldThrottleValue) {
                ifDecreaseSpeed = true;
                ifIncreaseSpeed = false;
            }
            TimeToTopSpeed(0f, 0f, moveForce);
            
            
            
            /*pos = player.transform.position;
            pos.y = newThrottleValue * moveForce;
            player.transform.position = pos;
            
        }

        public void TurnRight() {
            isTurnLeft = false;
            isTurnRight = true;
        }

        public void StopTurnRight() {
            isTurnRight = false;
            turnRight = 0;
        }

        public void TurnLeft() {
            isTurnLeft = true;
            isTurnRight = false;
        }

        public void StopTurnLeft() {
            isTurnLeft = false;
            turnLeft = 0;
        }

        public void TurnUp() {
            isTurnUp = true;
            isTurnDown = false;
        }

        public void StopTurnUp() {
            isTurnUp = false;
            turnUp = 0;
        }

        public void TurnDown() {
            isTurnDown = true;
            isTurnUp = false;
        }

        public void StopTurnDown() {
            isTurnDown = false;
            turnDown = 0;
        }

        public void Turning() {

            if (isTurnRight) {
                turnRight += .1f;
                if (turnRight > maxTurnRight) {
                    turnRight = maxTurnRight;
                }
                transform.Rotate(0, turnRight, 0);
            }

            if (isTurnLeft) {
                turnLeft += .1f;
                if (turnLeft > maxTurnLeft) {
                    turnLeft = maxTurnLeft;
                }
                transform.Rotate(0, -turnLeft, 0);
            }


            if (isTurnUp) {
                turnUp += .1f;
                if (turnUp > maxTurnUp) {
                    turnUp = maxTurnUp;
                }
                transform.Rotate(turnUp, 0, 0);
            }

            if (isTurnDown) {
                turnDown += .1f;
                if (turnDown > maxTurnDown) {
                    turnDown = maxTurnDown;
                }
                transform.Rotate(-turnDown, 0, 0);
            }
        }
    }
}
*/
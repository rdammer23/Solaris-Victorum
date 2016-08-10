using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Scripts.Player
{
    class PlayerMovementLocal:MonoBehaviour
    {
        Rigidbody myBody;

        static float turnForce = 0.50f;

        static bool ifX = false;
        static int x = 0;

        static float moveForce = 25f;
        //static float newThrottleValue = 0f;
        static float throttleValue;
        static float desiredThrottleValue;
        static float oldThrottleValue = 0f;
        static float throttleChange;
        private float oldThrottleChange;

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

        static Vector3 pos;

        //Ship ship;

        public void Start()
        {
            myBody = this.GetComponent<Rigidbody>();

            //ship = new Ship(2f);
        }

        public void FixedUpdate()
        {
            float turn = CrossPlatformInputManager.GetAxis("Horizontal") * turnForce;
            float pitch = CrossPlatformInputManager.GetAxis("Vertical") * turnForce;

            TurnShip(turn, pitch);

            //Turning();

            if (ifIncreaseSpeed)
            {
                IncreaseSpeed();
            }
            else if (ifDecreaseSpeed)
            {
                DecreaseSpeed();
            }
            else
            {
                MoveShipForward(throttleValue);
            }
        }

        public void TurnShip(float turn, float pitch)
        {
            transform.Rotate(-pitch, turn, 0); //Remove - if I want flight joystick
        }

        public void IncreaseSpeed()
        {
            /*
            OldThrottle is only set to newThrottleValue if
                All ModifiedCyclesToTopSpeed Used......DONE
                or 
                if NewModifiedCyclesToTopSpeed < ModifiedCyclesToTopSpeed....NOT DONE
            Then Do calculation

            */
            throttleChange = desiredThrottleValue - oldThrottleValue;
            timeToSpeed = TimeToSpeed(cyclesToTopSpeed, throttleChange);
            throttleValue += throttleChange / timeToSpeed;
            MoveShipForward(throttleValue);
            if (throttleValue >= desiredThrottleValue)
            {
                oldThrottleValue = desiredThrottleValue;
                throttleValue = desiredThrottleValue;
                ifIncreaseSpeed = false;
            }
        }

        public void DecreaseSpeed()
        {
            throttleChange = oldThrottleValue - desiredThrottleValue;
            timeToSpeed = TimeToSpeed(cyclesToTopSpeed, throttleChange);

            throttleValue -= throttleChange / timeToSpeed;
            MoveShipForward(throttleValue);
            if (throttleValue <= desiredThrottleValue)
            {
                oldThrottleValue = desiredThrottleValue;
                throttleValue = desiredThrottleValue;
                ifDecreaseSpeed = false;
            }
        }

        public void TimeToTopSpeed(float shipWeight, float cargoWeight, float moveForce)
        {
            if (shipWeight < 1)
            {
                shipWeight = 100f;
            }
            if (cargoWeight < 1)
            {
                cargoWeight = 100f;
            }
            cyclesToTopSpeed = (shipWeight + cargoWeight) / moveForce;
        }

        public float TimeToSpeed(float cyclesToTopSpeed, float throttleChange)
        {
            if(throttleChange == 0)
            {
                throttleChange = oldThrottleChange;
            }
            oldThrottleChange = throttleChange;
            return cyclesToTopSpeed * throttleChange;
        }

        public void MoveShipForward(float throttleValue)
        {

            transform.localPosition += transform.forward * throttleValue * moveForce * Time.deltaTime;
        }

        public void Throttle_Changed(float newThrottleValue)
        {
            desiredThrottleValue = newThrottleValue;
            if (desiredThrottleValue > oldThrottleValue)
            {
                ifIncreaseSpeed = true;
                ifDecreaseSpeed = false;
            }
            else if (desiredThrottleValue < oldThrottleValue)
            {
                ifDecreaseSpeed = true;
                ifIncreaseSpeed = false;
            }
            TimeToTopSpeed(0f, 0f, moveForce);



            /*pos = player.transform.position;
            pos.y = newThrottleValue * moveForce;
            player.transform.position = pos;
            */
        }



        public void TurnRight()
        {
            isTurnLeft = false;
            isTurnRight = true;
        }

        public void StopTurnRight()
        {
            isTurnRight = false;
            turnRight = 0;
        }

        public void TurnLeft()
        {
            isTurnLeft = true;
            isTurnRight = false;
        }

        public void StopTurnLeft()
        {
            isTurnLeft = false;
            turnLeft = 0;
        }

        public void TurnUp()
        {
            isTurnUp = true;
            isTurnDown = false;
        }

        public void StopTurnUp()
        {
            isTurnUp = false;
            turnUp = 0;
        }

        public void TurnDown()
        {
            isTurnDown = true;
            isTurnUp = false;
        }

        public void StopTurnDown()
        {
            isTurnDown = false;
            turnDown = 0;
        }

        public void Turning()
        {

            if (isTurnRight)
            {
                turnRight += .1f;
                if (turnRight > maxTurnRight)
                {
                    turnRight = maxTurnRight;
                }
                transform.Rotate(0, turnRight, 0);
            }

            if (isTurnLeft)
            {
                turnLeft += .1f;
                if (turnLeft > maxTurnLeft)
                {
                    turnLeft = maxTurnLeft;
                }
                transform.Rotate(0, -turnLeft, 0);
            }


            if (isTurnUp)
            {
                turnUp += .1f;
                if (turnUp > maxTurnUp)
                {
                    turnUp = maxTurnUp;
                }
                transform.Rotate(turnUp, 0, 0);
            }

            if (isTurnDown)
            {
                turnDown += .1f;
                if (turnDown > maxTurnDown)
                {
                    turnDown = maxTurnDown;
                }
                transform.Rotate(-turnDown, 0, 0);
            }
        }
    }
}

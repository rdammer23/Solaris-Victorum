using Assets.Scripts.Attributes;
using Assets.Scripts.Ship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


namespace Assets.Scripts.Player
{
    class PlayerMovement : MonoBehaviour
    {
        Rigidbody myBody;
        ShipPlayer shipStats;
        AttributeStatModPlayer attributeMods;

        static float turnForce; //Retrieved from ShipPlayer

        static float cyclesToTopSpeed;
        static float timeToSpeed;

        static float moveForce; //Retrieved from ShipPlayer
        static float throttleValue;
        static float desiredThrottleValue;
        static float oldThrottleValue = 0f;
        static float throttleChange;
        private float oldThrottleChange;

        //static bool ifX = false;
        //static int x = 0;


        float maxTurnRightLeft; //Retrieved from ShipPlayer
        static float turnRight = 0;
        static float turnLeft = 0;
        
        float maxTurnUpDown;  //Retrieved from ShipPlayer
        static float turnUp = 0;
        static float turnDown = 0;

        //static float turnSpeed = .01f;

        static bool ifIncreaseSpeed = false;
        static bool ifDecreaseSpeed = false;

        static bool isTurnRight = false;
        static bool isTurnLeft = false;
        static bool isTurnUp = false;
        static bool isTurnDown = false;

        static int shipWeight; //retrieved from ShipPlayer
        static int cargoWeight = 1; //TODO Current not used, but should be and will need to be calculated


        void Start()
        {
            myBody = GetComponentInChildren<Rigidbody>();
            shipStats = new ShipPlayer();
            attributeMods = new AttributeStatModPlayer();

            turnForce = shipStats.TurnForce(GameData.ShipID);
            moveForce = shipStats.MoveForce(GameData.ShipID);
            //Debug.Log(moveForce);

            moveForce += moveForce * attributeMods.SpeedShipSpeedIncrease(GameData.Speed);
            //Debug.Log(moveForce + " " + GameData.Speed);
            maxTurnRightLeft = shipStats.MaxTurnRightLeft(GameData.ShipID);
            maxTurnUpDown = shipStats.MaxTurnUpDown(GameData.ShipID);
            shipWeight = shipStats.ShipWeight(GameData.ShipID);

            //Debug.Log(turnForce);
            //Debug.Log(moveForce);
            //Debug.Log(maxTurnRightLeft);
            //Debug.Log(maxTurnUpDown);
            //Debug.Log(shipWeight);
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

        private void TurnShip(float turn, float pitch)
        {
            transform.Rotate(-pitch, turn, 0); //Remove - if I want flight joystick
        }

        private void IncreaseSpeed()
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
            if (throttleChange == 0)
            {
                throttleChange = oldThrottleChange;
            }
            oldThrottleChange = throttleChange;
            return cyclesToTopSpeed * throttleChange;
        }

        public void MoveShipForward(float throttleValue)
        {
            //Debug.Log("Throttle Value = " + throttleValue);
            //Debug.Log("Move Force = " + moveForce);
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
                if (turnRight > maxTurnRightLeft)
                {
                    turnRight = maxTurnRightLeft;
                }
                transform.Rotate(0, turnRight, 0);
            }

            if (isTurnLeft)
            {
                turnLeft += .1f;
                if (turnLeft > maxTurnRightLeft)
                {
                    turnLeft = maxTurnRightLeft;
                }
                transform.Rotate(0, -turnLeft, 0);
            }


            if (isTurnUp)
            {
                turnUp += .1f;
                if (turnUp > maxTurnUpDown)
                {
                    turnUp = maxTurnUpDown;
                }
                transform.Rotate(turnUp, 0, 0);
            }

            if (isTurnDown)
            {
                turnDown += .1f;
                if (turnDown > maxTurnUpDown)
                {
                    turnDown = maxTurnUpDown;
                }
                transform.Rotate(-turnDown, 0, 0);
            }
        }
    }
}

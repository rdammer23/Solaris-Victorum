/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player {
    class CollisionAndTriggerManager:MonoBehaviour {
        string message;
        int messageTypeID;

        TakeDamage _takeDamage;
        Explosions _explosion;

        AlertMessages _alertMessage;

        void Start()
        {
            _explosion = new Explosions();
        }

        void OnTriggerEnter(Collider other) {
            Debug.Log("Hit a trigger and it was " + other.gameObject.name);
            if (other.gameObject.tag == "LocalStar") {
                message = "You are going to burn";
                messageTypeID = 2;
                _alertMessage = new AlertMessages();
                _alertMessage.MessageReceiver(messageTypeID, message);
            }
            if (other.gameObject.tag == "Planet") {
                message = "You Are Crashing Into The Planet";
                messageTypeID = 3;
                _alertMessage = new AlertMessages();
                _alertMessage.MessageReceiver(messageTypeID, message);
            }
            if (other.gameObject.tag == "PlanetAtmosphere") {
                /*TODO Add Checks
                1. If Owned by player
                2. If Allied to Player
                3. If Neutral
                4. If Enemy
                
                message = "You Are Entering Orbit";
                Debug.Log(message);
                messageTypeID = 1;
                _alertMessage = new AlertMessages();
                _alertMessage.MessageReceiver(messageTypeID, message);
            }
            if(other.gameObject.tag == "Player")
            {
                message = "I am colliding with a player";
                _takeDamage = new TakeDamage();
                _takeDamage.ShipCollision();
            }
            if (other.gameObject.HasTag("YellowLaser"))
            {
                Debug.Log("OUCH!!!!  HIT BY A LASER BEAM!!!!" + " "+other.transform.parent.transform.name);
                message = "Laser Impact";
                other.gameObject.transform.parent.gameObject.SetActive(false);
                _takeDamage = new TakeDamage();
                _takeDamage.ShipCollision();
                _explosion.LaserExplosion(this.transform);

            }
        }

        void OnTriggerExit(Collider other) {
            if (other.gameObject.tag == "LocalStar") {
                message = "";
                messageTypeID = 2;
                _alertMessage = new AlertMessages();
                _alertMessage.MessageReceiver(messageTypeID, message);
            }
            if (other.gameObject.tag == "Planet") {
                message = "";
                Debug.Log(message);
                messageTypeID = 3;
                _alertMessage = new AlertMessages();
                _alertMessage.MessageReceiver(messageTypeID, message);
            }
            if (other.gameObject.tag == "PlanetAtmosphere") {
                /*TODO Add Checks
                1. If Owned by player
                2. If Allied to Player
                3. If Neutral
                4. If Enemy
                
                message = "";
                Debug.Log(message);
                messageTypeID = 1;
                _alertMessage = new AlertMessages();
                _alertMessage.MessageReceiver(messageTypeID, message);
            }
        }

        /*        void OnTriggerStay(Collider other) {
                    message = ("You are burning");
                    messageTypeID = 3;
                    _alertMessage = new AlertMessages();
                    _alertMessage.MessageReceiver(messageTypeID, message);
                }
                
    }
}
*/
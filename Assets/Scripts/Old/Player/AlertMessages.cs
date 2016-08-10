using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Player {
    class AlertMessages: MonoBehaviour {

        static string message;
        static int messageTypeID;
        public float scrollSpeed = 50;
        Rect messageRect;

        void OnGUI() {
            // Set up the message's rect if we haven't already
            if (messageRect.width == 0) {
                Vector2 dimensions = GUI.skin.label.CalcSize(new GUIContent(message));

                // Start the message past the left side of the screen
                messageRect.x = dimensions.x;
                messageRect.width = dimensions.x;
                messageRect.height = dimensions.y;
            }

            messageRect.x -= Time.deltaTime * scrollSpeed;

            // If the message has moved past the right side, move it back to the left
            if (messageRect.x < Screen.width) {
                messageRect.x = messageRect.width;
            }

            switch (messageTypeID) {
                case 1:
                    GUI.color = Color.white;
                    break;
                case 2:
                    GUI.color = Color.yellow;
                    break;
                case 3:
                    GUI.color = Color.red;
                    break;
                case 4:
                    GUI.color = Color.green;
                    break;
                default:
                    GUI.color = Color.white;
                    break;
            }

            GUI.Label(messageRect, message );
        }

        public void MessageReceiver(int messageType, string messageReceived) {
            message = messageReceived;
            messageTypeID = messageType;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Menu
{
    class AlertMessageManager:MonoBehaviour
    {
        static Text textToDisplay;
        static GameObject textGO;

        void Start()
        {
            textGO = GameObject.FindWithTag("AlertSystem");
            textToDisplay = textGO.GetComponent<Text>();
            textToDisplay.color = Color.green;
            textToDisplay.text = "Message System";
        }

        public void NewAlertMessage(string msg, string color)
        {
            switch (color)
            {
                case "Black":
                    textToDisplay.color = Color.black;
                    break;
                case "Red":
                    textToDisplay.color = Color.red;
                    break;
                case "Yellow":
                    textToDisplay.color = Color.yellow;
                    break;
                case "Green":
                    textToDisplay.color = Color.green;
                    break;
                default:
                    textToDisplay.color = Color.black;
                    break;
            }
            textToDisplay.text = msg;
        }
    }
}

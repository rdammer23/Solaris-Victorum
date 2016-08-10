using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class ThrottleControl : MonoBehaviour
    {
        PlayerMovement throttleControl;

        void Start()
        {
            throttleControl = new PlayerMovement();
        }

        public void Throttle_Changed(float newThrottleValue)
        {
            throttleControl.Throttle_Changed(newThrottleValue);
        }
    }
}

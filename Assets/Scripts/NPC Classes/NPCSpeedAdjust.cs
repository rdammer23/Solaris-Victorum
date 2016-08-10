using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class NPCSpeedAdjust:MonoBehaviour
    {
        public float SpeedUp(float currentSpeed)
        {
            return (currentSpeed + .8f);
        }

        public float SlowDown(float currentSpeed)
        {
            return currentSpeed - .3f;
        }
    }
}

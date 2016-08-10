/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

using BeardedManStudios.Network;


namespace Assets.Scripts.NPC
{
    class NPCMovement:MonoBehaviour
    {
        int directionTime = 100;
        int switchDirection = 0;
        float whatDirection = -1f;

        void Update()
        {
            if (Networking.PrimarySocket.IsServer)
            {
                if (switchDirection >= directionTime)
                {
                    whatDirection = whatDirection * -1f;
                    switchDirection = 0;
                }
                this.transform.Translate((Vector3.forward) * whatDirection);
                switchDirection += 1;
            }
        }
    }
}
*/
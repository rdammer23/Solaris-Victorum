using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class NPCAvoidanceRayCast:MonoBehaviour
    {
        static private LayerMask avoidanceLayerMask = ((1 << 8) | (1 << 9) | (1 << 12) | (1 << 14));
        // 8 is player, 9 is enemy, 12 is weapon, 14 is star, planet, moon
        static private RaycastHit hitAvoidance;
        Vector3 rayAngle;
        Vector3 rayDirection;

        private int whatDirection = 0;

        public GameObject NPCAvoidance(float avoidanceDistance, Transform shipPosition, float rayCastOffset)
        {
            rayAngle = -shipPosition.right + shipPosition.forward;
            
            switch (whatDirection)
            {
                case 0:
                    rayAngle = shipPosition.forward;
                    break;
                case 1:
                    rayAngle = -shipPosition.right + shipPosition.forward;
                    break;
                case 2:
                    rayAngle = shipPosition.right + shipPosition.forward;
                    break;
                case 3:
                    rayAngle = -shipPosition.up + shipPosition.forward;
                    break;
                case 4:
                    rayAngle = shipPosition.up + shipPosition.forward;
                    break;
                default:
                    rayAngle = shipPosition.forward;
                    break;
            }
            if (whatDirection == 4)
            {
                whatDirection = 0;
            }
            else
            {
                whatDirection += 1;
            }
            Debug.DrawRay(shipPosition.position, rayAngle * rayCastOffset, Color.green);
            if (Physics.Raycast(shipPosition.position + (shipPosition.forward * rayCastOffset), rayAngle, out hitAvoidance, avoidanceDistance, avoidanceLayerMask))
            {
                return hitAvoidance.transform.gameObject;
            }
            else
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class NPCFollow:MonoBehaviour
    {
        public Vector3 FollowHeading(Transform npc, Transform attackTarget)
        {
            return (attackTarget.transform.position - npc.position);
        }

        public void FollowRotate(Transform npc, Vector3 attackDirection, float attackTurnSpeed)
        {
            npc.rotation = Quaternion.RotateTowards(npc.rotation, Quaternion.LookRotation(attackDirection), Time.deltaTime * attackTurnSpeed);
        }

        public void MoveForward(Transform npc, float attackSpeed)
        {
            npc.localPosition += npc.transform.forward * attackSpeed * Time.deltaTime;
        }
    }
}

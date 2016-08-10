using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC_Classes
{
    class NPCAttack:MonoBehaviour
    {
        public Vector3 AttackHeading(Transform npc, Transform attackTarget)
        {
            return (attackTarget.transform.position - npc.position);
        }

        public void AttackRotate(Transform npc, Vector3 attackDirection, float attackTurnSpeed)
        {
            npc.rotation = Quaternion.RotateTowards(npc.rotation, Quaternion.LookRotation(attackDirection), Time.deltaTime * attackTurnSpeed);
        }

        public void WasAttackedRotate(Transform npc, Vector3 attackDirection, float attackTurnSpeed)
        {
            npc.rotation = Quaternion.RotateTowards(npc.rotation, Quaternion.LookRotation(attackDirection), Time.deltaTime * attackTurnSpeed);
        }

        public void MoveForward(Transform npc, float attackSpeed)
        {
            npc.localPosition += npc.transform.forward * attackSpeed * Time.deltaTime;
        }

        public float AheadOrBehind(Transform npc, Transform attackTarget)
        {
            return (Vector3.Dot(attackTarget.transform.TransformDirection(Vector3.forward), (npc.transform.position - attackTarget.position)));
        }

        public float AboveOrBelow(Transform npc, Transform attackTarget)
        {
            return (Vector3.Dot(attackTarget.transform.TransformDirection(Vector3.up), (npc.transform.position - attackTarget.position)));
        }

        public float RightOrLeft(Transform npc, Transform attackTarget)
        {
            return (Vector3.Dot(attackTarget.transform.TransformDirection(Vector3.right), (npc.transform.position - attackTarget.position)));
        }
    }
}

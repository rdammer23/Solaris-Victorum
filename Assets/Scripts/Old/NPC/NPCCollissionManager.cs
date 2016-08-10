using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC
{
    class NPCCollissionManager:MonoBehaviour
    {
        BasicNPCManager _basicNPCManager;

        void Awake()
        {
            _basicNPCManager = new BasicNPCManager();
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.HasTag("YellowLaser"))
            {
                other.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
                //other.transform.parent.gameObject.SetActive(false);
                _basicNPCManager.HitByLaser(2, transform.parent.name);
            }
        }
    }
}

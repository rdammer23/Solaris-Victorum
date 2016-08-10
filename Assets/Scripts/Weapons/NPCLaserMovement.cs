using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    class NPCLaserMovement:MonoBehaviour
    {
        float laserSpeed = 750f;

        void Update()
        {
            //TODO Research why -Vector3.forward
            this.transform.Translate((-Vector3.forward * laserSpeed * Time.deltaTime));
        }
    }
}

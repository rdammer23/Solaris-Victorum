using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    class LaserMovement:MonoBehaviour
    {
        float laserSpeed = 750f;

        void Update()
        {
            this.transform.Translate((Vector3.forward * laserSpeed * Time.deltaTime));
        }
    }
}

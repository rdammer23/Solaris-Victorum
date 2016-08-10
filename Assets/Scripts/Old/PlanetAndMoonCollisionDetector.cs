using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class PlanetAndMoonCollisionDetector:MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            Debug.Log("Entered a Collission.  I am " + this.name + " and collided with " + other.name);
        }
    }
}

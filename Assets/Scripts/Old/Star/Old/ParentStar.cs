using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Star {
    class ParentStar: MonoBehaviour {
        Transform solarSystemManager;


        void Start() {
            solarSystemManager = GameObject.Find("SolarSystemManager").transform;
            transform.parent = solarSystemManager;
        }

        void Update() {
 
        }
    }
}

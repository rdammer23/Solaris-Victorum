using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Gear.Weapons
{
    class FireRayCastLaser:MonoBehaviour
    {
        static GameObject YellowFireOnceLaser;

        static bool readyToFire = true;
        static float fireTimer = 1f;
        static float currentFireTime = 0;

        public void Start()
        {
            YellowFireOnceLaser = GameObject.Find("Yellow_OnceLaserFireBeam");
            YellowFireOnceLaser.SetActive(false);
        }

        public void Update()
        {
            if(currentFireTime >= fireTimer)
            {
                readyToFire = true;
            }
            currentFireTime += Time.deltaTime;
        }

        public void YellowOnce()
        {
            if (readyToFire)
            {
                YellowFireOnceLaser.SetActive(false);
                YellowFireOnceLaser.SetActive(true); // Need to pass endpoint to csLaser2
                currentFireTime = 0f;
                readyToFire = false;
            }
            
        }
    }
}

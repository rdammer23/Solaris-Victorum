using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class Explosions:MonoBehaviour
    {
        public Transform explosion;
        public Transform LaserHitEffect;
        Transform smallLaserHitExplosion;
        Transform largeExplosion;
        static Transform explosionLocation;

        static bool smallExplosion = false;
        static bool shipExplosion = false;

        void Start()
        {
            smallLaserHitExplosion = Instantiate(LaserHitEffect, transform.position, Quaternion.identity) as Transform; // Make Effect.
            smallLaserHitExplosion.gameObject.SetActive(false);

            largeExplosion = Instantiate(explosion, transform.position, Quaternion.identity) as Transform;
            largeExplosion.gameObject.SetActive(false);
        }

        public void Update()
        {
            if (smallExplosion)
            {
                smallLaserHitExplosion.gameObject.SetActive(false);
                smallLaserHitExplosion.transform.position = explosionLocation.position;
                smallLaserHitExplosion.gameObject.SetActive(true);
                smallExplosion = false;
            }
        }

        public void LaserExplosion(Transform playerTransofrm)
        {
            explosionLocation = playerTransofrm;
            smallExplosion = true;
        }

    }
}

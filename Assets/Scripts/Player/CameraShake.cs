using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class CameraShake:MonoBehaviour
    {
        static bool Shaking;
        static float ShakeDecay;
        static float ShakeIntensity;
        static Vector3 OriginalPos;
        private Quaternion OriginalRot;
        static GameObject shakeCamera;

        void Start()
        {
            shakeCamera = GameObject.FindWithTag("MainCamera");
            Shaking = false;
            OriginalPos = transform.localPosition;
            OriginalRot = transform.localRotation;
        }

         void Update()
        {
            if (ShakeIntensity > 0)
            {
                //Debug.Log("Shake Me");
                /* This was Original 
                transform.position = OriginalPos + UnityEngine.Random.insideUnitSphere * ShakeIntensity;
                transform.rotation = new Quaternion(OriginalRot.x + UnityEngine.Random.Range(-ShakeIntensity, ShakeIntensity) * .2f,
                                          OriginalRot.y + UnityEngine.Random.Range(-ShakeIntensity, ShakeIntensity) * .2f,
                                          OriginalRot.z + UnityEngine.Random.Range(-ShakeIntensity, ShakeIntensity) * .2f,
                                          OriginalRot.w + UnityEngine.Random.Range(-ShakeIntensity, ShakeIntensity) * .2f);
                */

                transform.localPosition = OriginalPos + UnityEngine.Random.insideUnitSphere * ShakeIntensity;
                transform.localRotation = new Quaternion(OriginalRot.x + UnityEngine.Random.Range(-ShakeIntensity, ShakeIntensity) * .2f,
                                          OriginalRot.y + UnityEngine.Random.Range(-ShakeIntensity, ShakeIntensity) * .2f,
                                          OriginalRot.z + UnityEngine.Random.Range(-ShakeIntensity, ShakeIntensity) * .2f,
                                          OriginalRot.w + UnityEngine.Random.Range(-ShakeIntensity, ShakeIntensity) * .2f);


                ShakeIntensity -= ShakeDecay;
            }
            else if (Shaking)
            {
                Shaking = false;
                shakeCamera.transform.localPosition = OriginalPos;
                shakeCamera.transform.localRotation = OriginalRot;
            }

        }

        public void DoShake(float shakeIntensity, float shakeDecay)
        {

            OriginalPos = shakeCamera.transform.localPosition;
            OriginalRot = shakeCamera.transform.localRotation;

            ShakeIntensity = shakeIntensity;
            ShakeDecay = shakeDecay;
            Shaking = true;
        }
    }
}

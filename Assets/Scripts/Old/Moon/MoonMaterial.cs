using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Moon
{
    class MoonMaterial:MonoBehaviour
    {
        GameObject currentMoon;
        public Renderer thisMoonRenderer;

        public Material mat;
        static bool isReady = false;
        static bool ifMat = false;

        public void Awake()
        {
            currentMoon = this.gameObject;
            thisMoonRenderer = this.GetComponent<Renderer>();
            isReady = true;
        }

        public void Update()
        {
            Debug.Log("in update mat = " + this.mat);
            Debug.Log("Moon renderer = " + thisMoonRenderer);
            /*           if (ifMat && isReady)
                       {
                           Debug.Log("In Update and Mat = " + this.mat);
                           isReady = false;
                       }
                       */
        }


        public void SetMaterial()
        {
            Debug.Log("In Set Material...This.mat = " + this.mat);
            this.GetComponent<Renderer>().material = this.mat;
            isReady = false;
        }

        public void SetMoonMaterial(Material moonMaterial)
        {
            Debug.Log("Can I see isReady = " + isReady);

            while (!isReady)
            {
                Debug.Log("waiting");
            }
            this.mat = moonMaterial;
            Debug.Log("In SetMoonMaterial and mat = " + mat);
            ifMat = true;

            // thisMoonRenderer = GetComponent<Renderer>();
            // Debug.Log("This renderer = " + thisMoonRenderer);
            //thisMoonRenderer.material = moonMaterial;
        }
    }
}

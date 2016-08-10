using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Planet
{
    class PlanetMaterial:MonoBehaviour
    {
        GameObject currentPlanet;
        public Renderer thisPlanetRenderer;

        public Material mat;
        static bool isReady = false;
        static bool ifMat = false;

        public void Awake()
        {
            currentPlanet = this.gameObject;
            thisPlanetRenderer = this.GetComponent<Renderer>();
            isReady = true;
        }

        public void Update()
        {
            Debug.Log("in update mat = " + this.mat);
            Debug.Log("Planet renderer = " + thisPlanetRenderer);
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

        public void SetPlanetMaterial(Material planetMaterial)
        {
            Debug.Log("Can I see isReady = " + isReady);

            while (!isReady)
            {
                Debug.Log("waiting");
            }
            this.mat = planetMaterial;
            Debug.Log("In SetPlanetMaterial and mat = " + mat);
            ifMat = true;

           // thisPlanetRenderer = GetComponent<Renderer>();
           // Debug.Log("This renderer = " + thisPlanetRenderer);
            //thisPlanetRenderer.material = planetMaterial;
        }
    }
}

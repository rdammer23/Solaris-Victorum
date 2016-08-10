/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BeardedManStudios.Network;

namespace Assets.Scripts.Player {
   // class PlayerSetup:SimpleNetworkedMonoBehavior {
     class PlayerSetup : MonoBehaviour
        {

            void Start() {
            //if (IsOwner) {
                //Debug.Log("I am owner");

                var activateLocalPlayer = GetComponentInChildren<Camera>();

                activateLocalPlayer.GetComponentInChildren<Light>().enabled = true;
                activateLocalPlayer.GetComponentInChildren<SU_SpaceParticles>().enabled = true;
                activateLocalPlayer.GetComponentInChildren<Camera>().enabled = true;

                var headLight = GameObject.FindGameObjectsWithTag("PlayerLight");
                foreach (GameObject h in headLight)//If already logged in, when a new person logs in, headlight not turned on for old clients
                {
                    h.GetComponent<Light>().enabled = true;
                }
            //}
        }
    }
}
*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BeardedManStudios.Network;

namespace Assets.Scripts.Gear.Weapons
{
    //class LaserDestroy:SimpleNetworkedMonoBehavior
    class LaserDestroy : MonoBehaviour
    {
        void OnEnable()
        {
            Invoke("Destroy", 3f);
        }

        void Destroy()
        {
            gameObject.SetActive(false);
        }

        void OnDisable()
        {
            CancelInvoke();
        }
    }
}
*/

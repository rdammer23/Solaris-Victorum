using Assets.Scripts.Ship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class WeaponFireWindow:MonoBehaviour
    {
        ShipPlayer shipStats;
        private float windowFireWidth = 100f; //Default Width
        private float windowFireHeigth = 100f; //Default Height
        public GameObject windowsFireParent;


        void Start()
        {
            shipStats = new ShipPlayer();
            windowsFireParent.GetComponent<RectTransform>().sizeDelta = new Vector2(shipStats.ShipWeaponViewWidth(GameData.ShipID), shipStats.ShipWeaponViewHeight(GameData.ShipID));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


namespace Assets.Scripts
{
    class WeaponSiteControl:MonoBehaviour
    {
        //public GameObject fireWeaponWindow;
        //public GameObject activateWeaponButton;
        private GameObject fireWeaponWindow;
        static bool activateFireWeapon;
        private void Awake()
        {
            fireWeaponWindow = GameObject.FindWithTag("FireWeaponWindow");
            //Debug.Log(fireWeaponWindow);
            fireWeaponWindow.SetActive(false);
            activateFireWeapon = false;
        }

        public void Update()
        {
            if (activateFireWeapon)
            {
                if (fireWeaponWindow.activeSelf)
                {
                    //buttonTextChange.text = "Activate Weapons";
                    fireWeaponWindow.SetActive(false);
                }
                else
                {
                    //buttonTextChange.text = "Deactivate Weapons";
                    fireWeaponWindow.SetActive(true);
                }
                activateFireWeapon = false;
            }
        }

        public void ActivateWeaponWindow()
        {
            //GameObject fireWeaponWindow = GameObject.FindWithTag("FireWeaponWindow");

            //var buttonTextChange = activateWeaponButton.GetComponentInChildren<Text>();
            activateFireWeapon = true;

        }
    }
}

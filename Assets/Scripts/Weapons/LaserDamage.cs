using Assets.Scripts.Attributes;
using Assets.Scripts.Ship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    class LaserDamage:MonoBehaviour
    {
        ShipPlayer playerShip;
        AttributeStatModPlayer attributeMod;

        public int YellowLaserMinDamage()
        {
            //This is the default Damage for Ship ID 1

            playerShip = new ShipPlayer();
            attributeMod = new AttributeStatModPlayer();
            float damage = playerShip.MinWeaponDamage(1);
            return (int)(damage + damage * attributeMod.StrengthDamage(GameData.Strength));
        }

        public int YellowLaserMaxDamage()
        {
            //This is the default Damage for Ship ID 1

            playerShip = new ShipPlayer();
            attributeMod = new AttributeStatModPlayer();
            float damage = playerShip.MaxWeaponDamage(1);
            return (int)(damage + damage * attributeMod.StrengthDamage(GameData.Strength));
        }
    }
}

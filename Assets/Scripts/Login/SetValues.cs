using Assets.Scripts.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Login
{
    class SetValues:MonoBehaviour
    {

        public void SetPlayerValues()
        {
            //TODO Change this to ready from DB as I already have the table there.
            //Damage - Strength
            //damageModifier is a % increase in damage done.
            //TODO need to modify this once gear is added to not take ship weapons into consideration if weapon equipped.
            float modifier = GameData.StrengthADJValue * GameData.Strength;
            float x = ((modifier * GameData.ShipMinDamage) + GameData.ShipMinDamage);
            GameData.MinDamage = (int)x;
            x = ((modifier * GameData.ShipMaxDamage) + GameData.ShipMaxDamage);

            GameData.MaxDamage = (int)x;
            GameData.DamageBonus = modifier * 100;

            //Ship Volume - Intelligence
            modifier = GameData.IntelligenceADJValue * GameData.Intelligence;
            x = ((modifier * GameData.ShipVolume) + GameData.ShipVolume);
            GameData.Volume = (int)x;

            //Evasion - Dexterity
            modifier = GameData.DexterityADJValue * GameData.Dexterity;
            x = ((modifier * GameData.ShipEvasion) + GameData.ShipEvasion);
            GameData.Evasion = x;

            //XP Bonus - Wisdom
            modifier = GameData.WisdomADJValue * GameData.Wisdom;
            x = modifier * 100;
            GameData.XPBonus = x;

            //Max Health - Health
            modifier = GameData.HealthADJValue * GameData.Health;
            x = ((modifier * GameData.ShipHull) + GameData.ShipHull);
            GameData.MaxHealth = (int)x;

            //Crit Hit Chance - Eagle Eyes
            modifier = GameData.EagleADJValue * GameData.EagleEyes;
            x = modifier * 100;
            GameData.CrititalHitChance = x;


            //TODO This is where I need to start Checking tonight
            
            //Weapon Cool Down Speed
            //This should decrease weapon cool down
            //TODO need to modify this to not take default ship weapon cooldown into consideration is weapon equipped
            modifier = GameData.SpeedADJValue * GameData.Speed;
            x = (GameData.ShipWeaponCoolDown - (modifier * GameData.ShipWeaponCoolDown));
            GameData.WeaponCoolDown = x/1000;

            //Ship Speed - From Endurance Attribute
            modifier = GameData.EnduranceADJValue * GameData.Endurance;
            x = ((modifier * GameData.ShipMoveForce) + GameData.ShipMoveForce);
            GameData.ShipSpeedADJ = x;

            //TO HIT from Nerves of Steel 
            modifier = GameData.NervesADJValue * GameData.NervesADJValue;
            x = modifier * 100;
            GameData.ToHit = 1 + x;

            //Buying, Selling and Happiness - From Charisma
            modifier = GameData.CharismaADJValue * GameData.Charisma;
            x = modifier * 100;
            GameData.Buying = x;
            GameData.Selling = x;
            GameData.Happiness = x;
        }

    }
}

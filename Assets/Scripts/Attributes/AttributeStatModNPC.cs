using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Attributes
{
    class AttributeStatModNPC
    {

        public float StrengthDamage(float currentStatValue)
        {
            return (.01f / 5) * currentStatValue;
        }

        public float IntelligenceShipVolume(float currentStatValue)
        {
            return (.01f / 5) * currentStatValue;
        }

        public float DexterityEvasion(float currentStatValue)
        {
            return (.0001f / 5) * currentStatValue;
        }

        public float WisdomXPBonus(float currentStatValue)
        {
            return (.01f / 5) * currentStatValue;
        }

        public float HealthHull(float currentStatValue)
        {
            return (.01f / 5) * currentStatValue;
        }

        public float EagleEyesCritHitChance(float currentStatValue)
        {
            return (.0001f / 5) * currentStatValue;
        }

        public float SpeedWeaponCoolDown(float currentStatValue)
        {
            return (.0001f / 5) * currentStatValue;
        }

        public float SpeedShipSpeedIncrease(float currentStatValue)
        {
            return (.0001f / 5) * currentStatValue;
        }

        public float EnduranceShipSpeedIncrease(float currentStatValue)
        {
            //Ship Speed Increase is only for NPC on Endurance.  
            //For players it increases planetary works efficiency
            return (.0001f / 5) * currentStatValue;
        }

        public float NervesOfSteelToHit(float currentStatValue)
        {
            return (.0001f / 5) * currentStatValue;
        }

        public float Charisma(float currentStatValue)
        {
            //Does nothing for NPC at this time
            //Added here to be consistant
            return (.0001f / 5) * currentStatValue;
        }
    }
}

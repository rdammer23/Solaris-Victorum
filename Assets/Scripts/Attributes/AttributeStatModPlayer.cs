using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Attributes
{
    class AttributeStatModPlayer
    {

        public float StrengthDamage(float currentStatValue)
        {//This is a % increase
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

        public float EndurancePlanetEfficiency(float currentStatValue)
        {
            //% increase in worker productivity
            return (.005f / 5) * currentStatValue;
        }

        public float NervesOfSteelToHit(float currentStatValue)
        {
            return (.0001f / 5) * currentStatValue;
        }

        public float Charisma(float currentStatValue)
        {
            return (.0001f / 5) * currentStatValue;
        }
    }
}
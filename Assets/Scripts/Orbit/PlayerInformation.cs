using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Orbit
{
    class PlayerInformation:MonoBehaviour
    {
        GameObject textMenuDisplayGO;

        void Awake()
        {
            textMenuDisplayGO = GameObject.Find("OrbitTextDisplay");
        }

        public void AttributeDisplay()
        {
            textMenuDisplayGO.GetComponent<Text>().text = "Player Attributes" +
                "\r\nStrength:\t\t" + GameData.Strength +
                "\r\nIntelligence:\t" + GameData.Intelligence +
                "\r\nDexterity:\t\t" + GameData.Dexterity +
                "\r\nWisdom:\t\t\t" + GameData.Wisdom +
                "\r\nHealth:\t\t\t" + GameData.Health +
                "\r\nEagle Eyes:\t\t" + GameData.EagleEyes +
                "\r\nSpeed:\t\t\t\t" + GameData.Speed +
                "\r\nEndurance:\t\t" + GameData.Endurance +
                "\r\nNerves Steel:\t" + GameData.NervesOfSteel +
                "\r\nCharisma:\t\t" + GameData.Charisma;
        }

        public void AttackDisplay()
        {
            textMenuDisplayGO.GetComponent<Text>().text = "Attack Stats" +
            "\r\nMin/Max Damage: " + GameData.MinDamage + "/" + GameData.MaxDamage +
            "\r\nDamage Bonus: " + GameData.DamageBonus + "% Already added to damage" + 
            "\r\nDamage Resist: " + GameData.DamageReduction +
            "\r\nCrit Dam Resist: " + GameData.CriticalDamageReduction +
            "\r\nTo Hit: " + GameData.ToHit + 
            "\r\nExtra Shot: " + GameData.ExtraShot + ("%") +
            "\r\nCrit Hit: " + GameData.CrititalHitChance + ("%") +
            "\r\nCrit Damage: " + GameData.CriticalDamage +
            "\r\nCrit Hit Resist: " + GameData.CriticalHitResistance + ("%") +
            "\r\nWeapon Cool Down: " + GameData.WeaponCoolDown + "seconds" +
            "\r\nInstant Kill: " + GameData.InstantKill + ("%") +
            "\r\nStun: " + GameData.Stun + ("%") +
            "\r\nStun Duration: " + GameData.StunDuration +
            "\r\nStun Resist: " + GameData.StunResistance + ("%") +
            "\r\nTractor Beam: " + GameData.TractorBeam + ("%") +
            "\r\nTrator Beam Resist: " + GameData.TractorBeamResistance + ("%") +
            "\r\nEnergy Conversion: " + GameData.EnergyConversion + ("%");
        }

        public void ShipStatsDisplay()
        {
            textMenuDisplayGO.GetComponent<Text>().text = "Ship Information" +
            "\r\n\nShip Base Hull: " + GameData.ShipHull +
            "\r\nMax Health: " + GameData.MaxHealth +
            "\r\n\nShip Base Max Speed: " + GameData.ShipMoveForce +
            "\r\nMax Speed: " + GameData.ShipSpeedADJ +
            "\r\n\nShip Base Volume: " + GameData.ShipVolume +
            "\r\nTotal Volume: " + GameData.Volume +
            "\r\n\nShip Base Evasion: " + GameData.ShipEvasion +
            "\r\nCurrent Evasion: " + GameData.Evasion +
            "\r\n\nCloak: " + GameData.Cloak;
        }

        public void MiscStatsDisplay()
        {
            textMenuDisplayGO.GetComponent<Text>().text = "Misc. Stats" +
            "\r\nMax Health: " + GameData.MaxHealth +
            "\r\nResource Harvesting: " + GameData.Resources +
            "\r\nXP Bonus: " + GameData.XPBonus + ("%") +
            "\r\nBreak Through: " + GameData.MajorBreakThrough +
            "\r\nInvention Bonus: " + GameData.InventionBonus +
            "\r\nBuying: " + GameData.Buying +
            "\r\nSelling: " + GameData.Selling +
            "\r\nPlanetary Happiness Bonus: " + GameData.Happiness;
        }
    }
}

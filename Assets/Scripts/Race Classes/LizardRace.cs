using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class LizardRace : BaseRace
    {
        public LizardRace()
        {
            RaceName = "Lizard";
            RaceID = 10;

            //Attributes
            RaceStrength = 0.7f;
            RaceIntelligence = 1f;
            RaceDexterity = 0.6f;
            RaceWisdom = 1f;
            RaceHealth = 1f;
            RaceEagleEyes = 1.4f;
            RaceSpeed = 1f;
            RaceEndurance = 1.4f;
            RaceNervesOfSteel = 0.6f;
            RaceCharisma = 1.3f;

            //Alignment
            RaceAlignmentHuman = 100;
            RaceAlignmentFeline = -100;
            RaceAlignmentBird = -100;
            RaceAlignmentMystic = -100;
            RaceAlignmentCyborgs = 0;
            RaceAlignmentInsect = -100;
            RaceAlignmentBrains = 0;
            RaceAlignmentMetal = 0;
            RaceAlignmentLizard = 500;
            RaceAlignmentTree = 100;
            RaceAlignmentGas = 0;
        }
    }
}

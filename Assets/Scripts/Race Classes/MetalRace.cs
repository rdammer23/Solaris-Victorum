using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class MetalRace : BaseRace
    {
        public MetalRace()
        {
            RaceName = "Metal Creature";
            RaceID = 11;

            //Attributes
            RaceStrength = 1.6f;
            RaceIntelligence = 0.5f;
            RaceDexterity = 1f;
            RaceWisdom = 0.7f;
            RaceHealth = 1.3f;
            RaceEagleEyes = 1f;
            RaceSpeed = 0.6f;
            RaceEndurance = 1f;
            RaceNervesOfSteel = 1.3f;
            RaceCharisma = 1f;

            //Alignment
            RaceAlignmentHuman = 0;
            RaceAlignmentFeline = 0;
            RaceAlignmentBird = -100;
            RaceAlignmentMystic = 100;
            RaceAlignmentCyborgs = -100;
            RaceAlignmentInsect = 0;
            RaceAlignmentBrains = 0;
            RaceAlignmentMetal = 500;
            RaceAlignmentLizard = 0;
            RaceAlignmentTree = 100;
            RaceAlignmentGas = 100;
        }
    }
}

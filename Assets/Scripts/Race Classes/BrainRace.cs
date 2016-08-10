using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class BrainRace : BaseRace
    {
        public BrainRace()
        {
            RaceName = "Brain";
            RaceID = 2;

            //Attributes
            RaceStrength = 1.3f;
            RaceIntelligence = 1.5f;
            RaceDexterity = 1f;
            RaceWisdom = 1.3f;
            RaceHealth = 1f;
            RaceEagleEyes = 0.7f;
            RaceSpeed = 1f;
            RaceEndurance = 0.5f;
            RaceNervesOfSteel = 1f;
            RaceCharisma = 0.7f;

            //Alignment
            RaceAlignmentHuman = 100;
            RaceAlignmentFeline = 100;
            RaceAlignmentBird = 100;
            RaceAlignmentMystic = -100;
            RaceAlignmentCyborgs = -100;
            RaceAlignmentInsect = 100;
            RaceAlignmentBrains = 500;
            RaceAlignmentMetal = 0;
            RaceAlignmentLizard = 0;
            RaceAlignmentTree = 0;
            RaceAlignmentGas = -100;
        }
    }
}

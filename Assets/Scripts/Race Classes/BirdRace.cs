using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class BirdRace:BaseRace
    {
        public BirdRace()
        {
            RaceName = "Bird Person";
            RaceID = 3;

            //Attributes
            RaceStrength = 0.7f;
            RaceIntelligence = 1f;
            RaceDexterity = 1.5f;
            RaceWisdom = 1f;
            RaceHealth = 0.7f;
            RaceEagleEyes = 1.3f;
            RaceSpeed = 1.3f;
            RaceEndurance = 1f;
            RaceNervesOfSteel = 0.5f;
            RaceCharisma = 1f;

            //Alignment
            RaceAlignmentHuman = 100;
            RaceAlignmentFeline = -100;
            RaceAlignmentBird = 500;
            RaceAlignmentMystic = 100;
            RaceAlignmentCyborgs = 100;
            RaceAlignmentInsect = -100;
            RaceAlignmentBrains = 100;
            RaceAlignmentMetal = -100;
            RaceAlignmentLizard = -100;
            RaceAlignmentTree = 100;
            RaceAlignmentGas = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class HumanRace:BaseRace
    {
        public HumanRace()
        {
            RaceName = "Human";
            RaceID = 1;

            //Attributes
            RaceStrength = 1f;
            RaceIntelligence = 1f;
            RaceDexterity = 1f;
            RaceWisdom = 1f;
            RaceHealth = 1f;
            RaceEagleEyes = 1f;
            RaceSpeed = 1f;
            RaceEndurance = 1f;
            RaceNervesOfSteel = 1f;
            RaceCharisma = 1f;

            //Alignment
            RaceAlignmentHuman = 500;
            RaceAlignmentFeline = -100;
            RaceAlignmentBird = 100;
            RaceAlignmentMystic = -100;
            RaceAlignmentCyborgs = -100;
            RaceAlignmentInsect = -100;
            RaceAlignmentBrains = 100;
            RaceAlignmentMetal = 0;
            RaceAlignmentLizard = 100;
            RaceAlignmentTree = -100;
            RaceAlignmentGas = 0;
        }
    }
}

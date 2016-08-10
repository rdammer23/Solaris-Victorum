using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class InsectRace : BaseRace
    {
        public InsectRace()
        {
            RaceName = "Insect";
            RaceID = 5;

            //Attributes
            RaceStrength = 1f;
            RaceIntelligence = 1.3f;
            RaceDexterity = 1.5f;
            RaceWisdom = 1f;
            RaceHealth = 0.5f;
            RaceEagleEyes = 1f;
            RaceSpeed = 0.7f;
            RaceEndurance = 0.7f;
            RaceNervesOfSteel = 1.3f;
            RaceCharisma = 1f;

            //Alignment
            RaceAlignmentHuman = -100;
            RaceAlignmentFeline = -100;
            RaceAlignmentBird = -100;
            RaceAlignmentMystic = 0;
            RaceAlignmentCyborgs = 0;
            RaceAlignmentInsect = 500;
            RaceAlignmentBrains = 100;
            RaceAlignmentMetal = 0;
            RaceAlignmentLizard = -100;
            RaceAlignmentTree = 100;
            RaceAlignmentGas = 0;
        }
    }
}

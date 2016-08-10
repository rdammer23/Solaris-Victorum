using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class GasRace: BaseRace
    {
        public GasRace()
        {
            RaceName = "Gas Blob";
            RaceID = 6;

            //Attributes
            RaceStrength = 1f;
            RaceIntelligence = 1f;
            RaceDexterity = 1.5f;
            RaceWisdom = 1f;
            RaceHealth = 0.5f;
            RaceEagleEyes = 1.3f;
            RaceSpeed = 1f;
            RaceEndurance = 1.3f;
            RaceNervesOfSteel = 0.7f;
            RaceCharisma = 0.7f;

            //Alignment
            RaceAlignmentHuman = 0;
            RaceAlignmentFeline = 0;
            RaceAlignmentBird = 0;
            RaceAlignmentMystic = -100;
            RaceAlignmentCyborgs = -100;
            RaceAlignmentInsect = 0;
            RaceAlignmentBrains = -100;
            RaceAlignmentMetal = 100;
            RaceAlignmentLizard = 0;
            RaceAlignmentTree = -100;
            RaceAlignmentGas = 500;
        }

    }
}

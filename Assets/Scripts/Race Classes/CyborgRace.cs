using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class CyborgRace: BaseRace
    {
        public CyborgRace()
        {
            RaceName = "Cyborg";
            RaceID = 8;

            //Attributes
            RaceStrength = 1.5f;
            RaceIntelligence = 0.5f;
            RaceDexterity = 1f;
            RaceWisdom = 0.7f;
            RaceHealth = 1f;
            RaceEagleEyes = 1f;
            RaceSpeed = 1.3f;
            RaceEndurance = 1.3f;
            RaceNervesOfSteel = 1f;
            RaceCharisma = 0.7f;

            //Alignment
            RaceAlignmentHuman = -100;
            RaceAlignmentFeline = 100;
            RaceAlignmentBird = 100;
            RaceAlignmentMystic = 100;
            RaceAlignmentCyborgs = 500;
            RaceAlignmentInsect = 0;
            RaceAlignmentBrains = -100;
            RaceAlignmentMetal = -100;
            RaceAlignmentLizard = 0;
            RaceAlignmentTree = 0;
            RaceAlignmentGas = -100;
        }
    }
}

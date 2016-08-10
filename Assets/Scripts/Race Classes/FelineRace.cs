using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class FelineRace:BaseRace
    {
        public FelineRace()
        {

            RaceName = "Feline";
            RaceID = 9;

            //Attributes
            RaceStrength = 0.9f;
            RaceIntelligence = 1.5f;
            RaceDexterity = 0.7f;
            RaceWisdom = 0.8f;
            RaceHealth = 1f;
            RaceEagleEyes = 0.5f;
            RaceSpeed = 1.3f;
            RaceEndurance = 1f;
            RaceNervesOfSteel = 1.3f;
            RaceCharisma = 1f;


            //Alignment
            RaceAlignmentHuman = -100;
            RaceAlignmentFeline = 500;
            RaceAlignmentBird = -100;
            RaceAlignmentMystic = 100;
            RaceAlignmentCyborgs = 100;
            RaceAlignmentInsect = -100;
            RaceAlignmentBrains = 100;
            RaceAlignmentMetal = 0;
            RaceAlignmentLizard = -100;
            RaceAlignmentTree = 0;
            RaceAlignmentGas = 0;
        }
    }
}

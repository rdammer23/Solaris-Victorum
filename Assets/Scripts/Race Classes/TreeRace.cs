using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class TreeRace : BaseRace
    {
        public TreeRace()
        {
            RaceName = "Tree Person";
            RaceID = 4;

            //Attributes
            RaceStrength = 1f;
            RaceIntelligence = 0.7f;
            RaceDexterity = 0.5f;
            RaceWisdom = 1.5f;
            RaceHealth = 1.5f;
            RaceEagleEyes = 0.9f;
            RaceSpeed = 0.6f;
            RaceEndurance = 1f;
            RaceNervesOfSteel = 1f;
            RaceCharisma = 1.3f;

            //Alignment
            RaceAlignmentHuman = -100;
            RaceAlignmentFeline = 0;
            RaceAlignmentBird = 100;
            RaceAlignmentMystic = -100;
            RaceAlignmentCyborgs = 0;
            RaceAlignmentInsect = 100;
            RaceAlignmentBrains = 0;
            RaceAlignmentMetal = 100;
            RaceAlignmentLizard = 100;
            RaceAlignmentTree = 500;
            RaceAlignmentGas = -100;
        }
    }
}

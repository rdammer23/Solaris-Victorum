using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class MysticRace:BaseRace
    {
        public MysticRace()
        {
            RaceName = "Mystic";
            RaceID = 7;

            //Attributes
            RaceStrength = 0.7f;
            RaceIntelligence = 1f;
            RaceDexterity = 1f;
            RaceWisdom = 1.5f;
            RaceHealth = 1.3f;
            RaceEagleEyes = 0.7f;
            RaceSpeed = 1f;
            RaceEndurance = 0.5f;
            RaceNervesOfSteel = 1f;
            RaceCharisma = 1.3f;

            //Alignment
            RaceAlignmentHuman = -100;
            RaceAlignmentFeline = 100;
            RaceAlignmentBird = 100;
            RaceAlignmentMystic = 500;
            RaceAlignmentCyborgs = 100;
            RaceAlignmentInsect = 0;
            RaceAlignmentBrains = -100;
            RaceAlignmentMetal = 100;
            RaceAlignmentLizard = -100;
            RaceAlignmentTree = -100;
            RaceAlignmentGas = -100;
        }
    }
}

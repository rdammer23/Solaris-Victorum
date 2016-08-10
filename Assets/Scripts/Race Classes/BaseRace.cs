using System;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Scripts.Race_Classes
{
    [System.Serializable]
    class BaseRace
    {
        private string raceName;
        private int raceID;

        //Attributes
        private float raceStrength;
        private float raceIntelligence;
        private float raceDexterity;
        private float raceWisdom;
        private float raceHealth;
        private float raceEagleEyes;
        private float raceSpeed;
        private float raceEndurance;
        private float raceNervesOfSteel;
        private float raceCharisma;

        //Alignment Modification
        private int raceAlignmentHuman;
        private int raceAlignmentFeline;
        private int raceAlignmentBird;
        private int raceAlignmentMystic;
        private int raceAlignmentCyborgs;
        private int raceAlignmentInsect;
        private int raceAlignmentBrains;
        private int raceAlignmentMetal;
        private int raceAlignmentLizard;
        private int raceAlignmentTree;
        private int raceAlignmentGas;

        #region Get and Set
        public string RaceName
        {
            get
            {
                return raceName;
            }

            set
            {
                raceName = value;
            }
        }

        public int RaceID
        {
            get
            {
                return raceID;
            }

            set
            {
                raceID = value;
            }
        }

        public float RaceStrength
        {
            get
            {
                return raceStrength;
            }

            set
            {
                raceStrength = value;
            }
        }

        public float RaceIntelligence
        {
            get
            {
                return raceIntelligence;
            }

            set
            {
                raceIntelligence = value;
            }
        }

        public float RaceDexterity
        {
            get
            {
                return raceDexterity;
            }

            set
            {
                raceDexterity = value;
            }
        }

        public float RaceWisdom
        {
            get
            {
                return raceWisdom;
            }

            set
            {
                raceWisdom = value;
            }
        }

        public float RaceHealth
        {
            get
            {
                return raceHealth;
            }

            set
            {
                raceHealth = value;
            }
        }

        public float RaceEagleEyes
        {
            get
            {
                return raceEagleEyes;
            }

            set
            {
                raceEagleEyes = value;
            }
        }

        public float RaceSpeed
        {
            get
            {
                return raceSpeed;
            }

            set
            {
                raceSpeed = value;
            }
        }

        public float RaceEndurance
        {
            get
            {
                return raceEndurance;
            }

            set
            {
                raceEndurance = value;
            }
        }

        public float RaceNervesOfSteel
        {
            get
            {
                return raceNervesOfSteel;
            }

            set
            {
                raceNervesOfSteel = value;
            }
        }

        public float RaceCharisma
        {
            get
            {
                return raceCharisma;
            }

            set
            {
                raceCharisma = value;
            }
        }

        public int RaceAlignmentHuman
        {
            get
            {
                return raceAlignmentHuman;
            }

            set
            {
                raceAlignmentHuman = value;
            }
        }

        public int RaceAlignmentFeline
        {
            get
            {
                return raceAlignmentFeline;
            }

            set
            {
                raceAlignmentFeline = value;
            }
        }

        public int RaceAlignmentBird
        {
            get
            {
                return raceAlignmentBird;
            }

            set
            {
                raceAlignmentBird = value;
            }
        }

        public int RaceAlignmentMystic
        {
            get
            {
                return raceAlignmentMystic;
            }

            set
            {
                raceAlignmentMystic = value;
            }
        }

        public int RaceAlignmentCyborgs
        {
            get
            {
                return raceAlignmentCyborgs;
            }

            set
            {
                raceAlignmentCyborgs = value;
            }
        }

        public int RaceAlignmentInsect
        {
            get
            {
                return raceAlignmentInsect;
            }

            set
            {
                raceAlignmentInsect = value;
            }
        }

        public int RaceAlignmentBrains
        {
            get
            {
                return raceAlignmentBrains;
            }

            set
            {
                raceAlignmentBrains = value;
            }
        }

        public int RaceAlignmentMetal
        {
            get
            {
                return raceAlignmentMetal;
            }

            set
            {
                raceAlignmentMetal = value;
            }
        }

        public int RaceAlignmentLizard
        {
            get
            {
                return raceAlignmentLizard;
            }

            set
            {
                raceAlignmentLizard = value;
            }
        }

        public int RaceAlignmentTree
        {
            get
            {
                return raceAlignmentTree;
            }

            set
            {
                raceAlignmentTree = value;
            }
        }

        public int RaceAlignmentGas
        {
            get
            {
                return raceAlignmentGas;
            }

            set
            {
                raceAlignmentGas = value;
            }
        }
        #endregion
    }
}

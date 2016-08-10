using Assets.Scripts.Race_Classes;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Base_Player
{
    class BasePlayer
    {
        private string playerName;
        private int playerLevel;
        private int currentXPLevel;
        private int shipID;
        private int maxHealth;
        private int currentHealth;
        private BaseRace playerRace;

        private float strength;
        private float intelligence;
        private float dexterity;
        private float wisdom;
        private float health;
        private float eagleEyes;
        private float speed;
        private float endurance;
        private float nervesOfSteel;
        private float charisma;

        private int alignmentHuman;
        private int alignmentFeline;
        private int alignmentBird;
        private int alignmentMystic;
        private int alignmentCyborgs;
        private int alignmentInsect;
        private int alignmentBrains;
        private int alignmentMetal;
        private int alignmentLizard;
        private int alignmentTree;
        private int alignmentGas;

        #region Get and Sets

        public string PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }

        public int PlayerLevel
        {
            get
            {
                return playerLevel;
            }

            set
            {
                playerLevel = value;
            }
        }

        public int CurrentXPLevel
        {
            get
            {
                return currentXPLevel;
            }

            set
            {
                currentXPLevel = value;
            }
        }

        public int ShipID
        {
            get
            {
                return shipID;
            }

            set
            {
                shipID = value;
            }
        }

        public int MaxHealth
        {
            get
            {
                return maxHealth;
            }

            set
            {
                maxHealth = value;
            }
        }

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }

            set
            {
                currentHealth = value;
            }
        }

        internal BaseRace PlayerRace
        {
            get
            {
                return playerRace;
            }

            set
            {
                playerRace = value;
            }
        }

        public float Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        public float Intelligence
        {
            get
            {
                return intelligence;
            }

            set
            {
                intelligence = value;
            }
        }

        public float Dexterity
        {
            get
            {
                return dexterity;
            }

            set
            {
                dexterity = value;
            }
        }

        public float Wisdom
        {
            get
            {
                return wisdom;
            }

            set
            {
                wisdom = value;
            }
        }

        public float Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }

        public float EagleEyes
        {
            get
            {
                return eagleEyes;
            }

            set
            {
                eagleEyes = value;
            }
        }

        public float Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public float Endurance
        {
            get
            {
                return endurance;
            }

            set
            {
                endurance = value;
            }
        }

        public float NervesOfSteel
        {
            get
            {
                return nervesOfSteel;
            }

            set
            {
                nervesOfSteel = value;
            }
        }

        public float Charisma
        {
            get
            {
                return charisma;
            }

            set
            {
                charisma = value;
            }
        }

        public int AlignmentHuman
        {
            get
            {
                return alignmentHuman;
            }

            set
            {
                alignmentHuman = value;
            }
        }

        public int AlignmentFeline
        {
            get
            {
                return alignmentFeline;
            }

            set
            {
                alignmentFeline = value;
            }
        }

        public int AlignmentBird
        {
            get
            {
                return alignmentBird;
            }

            set
            {
                alignmentBird = value;
            }
        }

        public int AlignmentMystic
        {
            get
            {
                return alignmentMystic;
            }

            set
            {
                alignmentMystic = value;
            }
        }

        public int AlignmentCyborgs
        {
            get
            {
                return alignmentCyborgs;
            }

            set
            {
                alignmentCyborgs = value;
            }
        }

        public int AlignmentInsect
        {
            get
            {
                return alignmentInsect;
            }

            set
            {
                alignmentInsect = value;
            }
        }

        public int AlignmentBrains
        {
            get
            {
                return alignmentBrains;
            }

            set
            {
                alignmentBrains = value;
            }
        }

        public int AlignmentMetal
        {
            get
            {
                return alignmentMetal;
            }

            set
            {
                alignmentMetal = value;
            }
        }

        public int AlignmentLizard
        {
            get
            {
                return alignmentLizard;
            }

            set
            {
                alignmentLizard = value;
            }
        }

        public int AlignmentTree
        {
            get
            {
                return alignmentTree;
            }

            set
            {
                alignmentTree = value;
            }
        }

        public int AlignmentGas
        {
            get
            {
                return alignmentGas;
            }

            set
            {
                alignmentGas = value;
            }
        }
        #endregion
    }
}

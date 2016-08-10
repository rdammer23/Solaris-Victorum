using Assets.Scripts.NPC_Classes.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes
{
    class BaseNPC
    {
        private string npcName;
        private int npcRaceID;
        private int npcLevel;
        private int npcTypeID;

        private int maxHealth;
        private int currentHealth;

        private BaseNPCRace baseNPCRace;
        private BaseNPCHobby baseNPCHobby;
        private BaseNPCShip baseNPCShip;
        private BaseNPCType baseNPCType;

        //Attributes
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

        #region GETs and SETs
        public string NpcName
        {
            get
            {
                return npcName;
            }

            set
            {
                npcName = value;
            }
        }

        public int NpcRaceID
        {
            get
            {
                return npcRaceID;
            }

            set
            {
                npcRaceID = value;
            }
        }

        public int NpcLevel
        {
            get
            {
                return npcLevel;
            }

            set
            {
                npcLevel = value;
            }
        }

        public int NpcTypeID
        {
            get
            {
                return npcTypeID;
            }

            set
            {
                npcTypeID = value;
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

        internal BaseNPCRace BaseNPCRace
        {
            get
            {
                return baseNPCRace;
            }

            set
            {
                baseNPCRace = value;
            }
        }

        internal BaseNPCHobby BaseNPCHobby
        {
            get
            {
                return baseNPCHobby;
            }

            set
            {
                baseNPCHobby = value;
            }
        }

        internal BaseNPCShip BaseNPCShip
        {
            get
            {
                return baseNPCShip;
            }

            set
            {
                baseNPCShip = value;
            }
        }

        internal BaseNPCType BaseNPCType
        {
            get
            {
                return baseNPCType;
            }

            set
            {
                baseNPCType = value;
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
        #endregion
    }
}

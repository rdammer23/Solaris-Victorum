using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes
{
    class BaseNPCRace
    {
        private string npcRaceName;
        private int npcRaceId;

        //Get these values from the Base Race Classes
        //Add the 10 additional attribute points for a level 1 
        //Add to the stats that get the best benefit from them
        //With some randomness
        //Then when a NPC is created will need to adjust these if
        //the NPC is greater than level 1.  
        //Just not sure how many attibute points you get when you level.

        private float npcRaceStrength;
        private float npcRaceIntelligence;
        private float npcRaceDexterity;
        private float npcRaceWisdom;
        private float npcRaceHealth;
        private float npcRaceEagleEyes;
        private float npcRaceSpeed;
        private float npcRaceEndurance;
        private float npcRaceNervesOfSteel;
        private float npcRaceCharisma;

        #region GETS and SETS
        public string NpcRaceName
        {
            get
            {
                return npcRaceName;
            }

            set
            {
                npcRaceName = value;
            }
        }

        public int NpcRaceId
        {
            get
            {
                return npcRaceId;
            }

            set
            {
                npcRaceId = value;
            }
        }

        public float NpcRaceStrength
        {
            get
            {
                return npcRaceStrength;
            }

            set
            {
                npcRaceStrength = value;
            }
        }

        public float NpcRaceIntelligence
        {
            get
            {
                return npcRaceIntelligence;
            }

            set
            {
                npcRaceIntelligence = value;
            }
        }

        public float NpcRaceDexterity
        {
            get
            {
                return npcRaceDexterity;
            }

            set
            {
                npcRaceDexterity = value;
            }
        }

        public float NpcRaceWisdom
        {
            get
            {
                return npcRaceWisdom;
            }

            set
            {
                npcRaceWisdom = value;
            }
        }

        public float NpcRaceHealth
        {
            get
            {
                return npcRaceHealth;
            }

            set
            {
                npcRaceHealth = value;
            }
        }

        public float NpcRaceEagleEyes
        {
            get
            {
                return npcRaceEagleEyes;
            }

            set
            {
                npcRaceEagleEyes = value;
            }
        }

        public float NpcRaceSpeed
        {
            get
            {
                return npcRaceSpeed;
            }

            set
            {
                npcRaceSpeed = value;
            }
        }

        public float NpcRaceEndurance
        {
            get
            {
                return npcRaceEndurance;
            }

            set
            {
                npcRaceEndurance = value;
            }
        }

        public float NpcRaceNervesOfSteel
        {
            get
            {
                return npcRaceNervesOfSteel;
            }

            set
            {
                npcRaceNervesOfSteel = value;
            }
        }

        public float NpcRaceCharisma
        {
            get
            {
                return npcRaceCharisma;
            }

            set
            {
                npcRaceCharisma = value;
            }
        }
        #endregion
    }
}

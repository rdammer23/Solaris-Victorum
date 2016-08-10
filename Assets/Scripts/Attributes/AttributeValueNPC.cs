using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Attributes
{
    class AttributeValueNPC
    {
        public float NPCStrength(int raceID)
        {
            switch (raceID)
            {
                case 2:
                    return .9f;
                case 3:
                    return .7f;
                case 4:
                    return .7f;
                case 5:
                    return 1.5f;
                case 7:
                    return 1.3f;
                case 8:
                    return 1.6f;
                case 9:
                    return .7f;
                default:
                    return 1f;
            }
        }

        public float NPCIntelligence(int raceID)
        {
            switch (raceID)
            {
                case 2:
                    return 1.5f;
                case 5:
                    return .5f;
                case 6:
                    return 1.3f;
                case 7:
                    return 1.5f;
                case 8:
                    return .5f;
                case 10:
                    return .7f;
                default:
                    return 1f;
            }
        }

        public float NPCDexterity(int raceID)
        {
            switch (raceID)
            {
                case 2:
                    return .7f;
                case 3:
                    return 1.5f;
                case 6:
                    return 1.5f;
                case 9:
                    return .6f;
                case 10:
                    return .5f;
                case 11:
                    return 1.5f;
                default:
                    return 1f;
            }
        }

        public float NPCWisdom(int raceID)
        {
            switch (raceID)
            {
                case 2:
                    return .8f;
                case 4:
                    return 1.5f;
                case 5:
                    return .7f;
                case 7:
                    return 1.3f;
                case 8:
                    return .7f;
                case 10:
                    return 1.5f;
                default:
                    return 1f;
            }
        }

        public float NPCHealth(int raceID)
        {
            switch (raceID)
            {
                case 3:
                    return .7f;
                case 4:
                    return 1.3f;
                case 6:
                    return .5f;
                case 8:
                    return 1.3f;
                case 10:
                    return .7f;
                case 11:
                    return 1.5f;
                default:
                    return 1f;
            }
        }

        public float NPCEagleEyes(int raceID)
        {
            switch (raceID)
            {
                case 2:
                    return .5f;
                case 3:
                    return 1.3f;
                case 4:
                    return .7f;
                case 7:
                    return .7f;
                case 9:
                    return 1.4f;
                case 10:
                    return .9f;
                case 11:
                    return 1.3f;
                default:
                    return 1f;
            }
        }

        public float NPCSpeed(int raceID)
        {
            switch (raceID)
            {
                case 2:
                    return 1.3f;
                case 3:
                    return 1.3f;
                case 5:
                    return 1.3f;
                case 6:
                    return .7f;
                case 8:
                    return .6f;
                case 10:
                    return .6f;
                default:
                    return 1f;
            }
        }

        public float NPCEndurance(int raceID)
        {
            switch (raceID)
            {
                case 4:
                    return .5f;
                case 5:
                    return 1.3f;
                case 6:
                    return .7f;
                case 7:
                    return .5f;
                case 9:
                    return 1.4f;
                case 11:
                    return 1.3f;
                default:
                    return 1f;
            }
        }

        public float NPCNervesOfSteel(int raceID)
        {
            switch (raceID)
            {
                case 2:
                    return 1.3f;
                case 3:
                    return .5f;
                case 6:
                    return 1.3f;
                case 8:
                    return 1.3f;
                case 9:
                    return .6f;
                case 11:
                    return .7f;
                default:
                    return 1f;
            }
        }

        public float NPCCharisma(int raceID)
        {
            switch (raceID)
            {
                case 4:
                    return 1.3f;
                case 5:
                    return .7f;
                case 7:
                    return .7f;
                case 9:
                    return 1.3f;
                case 10:
                    return 1.3f;
                case 11:
                    return .7f;
                default:
                    return 1f;
            }
        }
    }
}

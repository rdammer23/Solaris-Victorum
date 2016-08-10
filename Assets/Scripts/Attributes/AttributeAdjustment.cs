using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Attributes
{
    //These adjustments have been modified to be per level, not per 5 levels.
    //This is all wrong and needs to be redone.  Follow the spreadsheet
    class AttributeAdjustment
    {
        public float Strength()
        {//Damage
            return .004f;
        }

        public float Intelligence()
        {//Ship Size
            return .004f;
        }

        public float Dexterity()
        {//Evasion
            return .002f;
        }

        public float Wisdom()
        {//XP Bonus
            return .004f;
        }

        public float Health()
        {//Health
            return .025f;
        }

        public float EagleEyes()
        {//To Hit
            return .1f;
        }

        public float Speed()
        {//Weapons Cooldown
            return .0005f;
        }

        public float Endurance()
        {//Ship Speed
            return .01f;
        }

        public float NervesOfSteel()
        {//Critical Hit
            return .05f;
        }

        public float Charisma()
        {//Buy, Sell and Happiness
            return .05f;
        }
    }
}

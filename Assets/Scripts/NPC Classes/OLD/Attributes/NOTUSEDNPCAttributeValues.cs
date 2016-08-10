using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC_Classes.Attributes
{
    class NOTUSEDNPCAttributeValues
    {
        private int startingAttributeValue = 10;

        public float InitialAttributes(float raceModifier)
        {
            return (raceModifier * startingAttributeValue);
        }

        public float AttributeIncrease(float raceModifier, float currentAttributeValue, int numberPtsAllocate)
        {
            return (raceModifier * numberPtsAllocate + currentAttributeValue);
        }
    }
}

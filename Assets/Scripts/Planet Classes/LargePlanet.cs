using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class LargePlanet : BasePlanet
    {
        public LargePlanet()
        {
            PlanetSizeHarvestRateAdjustment = 1.0f;
        }

        public float HarvestRate()
        {
            return 1.0f;
        }
    }
}

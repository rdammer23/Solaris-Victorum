using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class ExtraLargePlanet : BasePlanet
    {
        public ExtraLargePlanet()
        {
            PlanetSizeHarvestRateAdjustment = 1.25f;
        }

        public float HarvestRate()
        {
            return 1.25f;
        }
    }
}

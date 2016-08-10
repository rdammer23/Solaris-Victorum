using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class GiantPlanet : BasePlanet
    {
        public GiantPlanet()
        {
            PlanetSizeHarvestRateAdjustment = 1.5f;
        }

        public float HarvestRate()
        {
            return 1.5f;
        }
    }
}

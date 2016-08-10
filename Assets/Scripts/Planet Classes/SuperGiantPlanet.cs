using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class SuperGiantPlanet : BasePlanet
    {
        public SuperGiantPlanet()
        {
            PlanetSizeHarvestRateAdjustment = 1.75f;
        }

        public float HarvestRate()
        {
            return 1.75f;
        }
    }
}

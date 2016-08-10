using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class SmallPlanet : BasePlanet
    {
        public SmallPlanet()
        {
            PlanetSizeHarvestRateAdjustment = .75f;
        }

        public float HarvestRate()
        {
            return .75f;
        }
    }
}

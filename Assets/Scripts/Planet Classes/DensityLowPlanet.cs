using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class DensityLowPlanet : BasePlanet
    {
        public DensityLowPlanet()
        {
            PlanetDensityHarvestRateAdjustment = .75f;
        }

        public float PlanetDensityHR()
        {
            return .75f;
        }
    }
}

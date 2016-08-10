using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class DensityHighPlanet : BasePlanet
    {
        public DensityHighPlanet()
        {
            PlanetDensityHarvestRateAdjustment = 1.5f;
        }

        public float PlanetDensityHR()
        {
            return 1.5f;
        }
    }
}

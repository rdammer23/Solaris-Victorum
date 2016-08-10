using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class DensityMedPlanet : BasePlanet
    {
        public DensityMedPlanet()
        {
            PlanetDensityHarvestRateAdjustment = 1.0f;
        }

        public float PlanetDensityHR()
        {
            return 1.0f;
        }
    }
}

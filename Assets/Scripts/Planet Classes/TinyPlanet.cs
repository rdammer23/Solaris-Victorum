using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]

    class TinyPlanet:BasePlanet
    {
        public TinyPlanet()
        {
            PlanetSizeHarvestRateAdjustment = .5f;
        }
        public float HarvestRate()
        {
            return .5f;
        }
    }
}

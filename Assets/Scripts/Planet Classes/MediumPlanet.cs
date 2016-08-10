using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class MediumPlanet : BasePlanet
    {
        public MediumPlanet()
        {
            PlanetSizeHarvestRateAdjustment = .90f;
        }

        public float HarvestRate()
        {
            return .90f;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet_Classes
{
    [System.Serializable]
    class MonsterPlanet : BasePlanet
    {
        public MonsterPlanet()
        {
            PlanetSizeHarvestRateAdjustment = 2.0f;
        }

        public float HarvestRate()
        {
            return 2.0f;
        }
    }
}

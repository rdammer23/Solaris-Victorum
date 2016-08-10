using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Planet {
    class PlanetLevel {
        public string GetPlanetTexture(int planetLevel) {
            switch (planetLevel) {
                case 1:
                    return "Barren";
                case 2:
                    return "Earth";
                default:
                    return "Earth";
            }
        }
    }
}

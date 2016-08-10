using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Sets the scale of the planet
1 = 10
2 = 15
3 = 20
4 = 25
5 = 30
6 = 35
7 = 40
8 = 45
*/

namespace Assets.Scripts.Planet {
    class PlanetSizes {

        public int PlanetSize(int planetSize) {
            switch (planetSize) {
                case 1:
                    return 25;
                case 2:
                    return 38;
                case 3:
                    return 50;
                case 4:
                    return 63;
                case 5:
                    return 75;
                case 6:
                    return 88;
                case 7:
                    return 100;
                case 8:
                    return 113;
                default:
                    return 50;
            }
        }
    }
}

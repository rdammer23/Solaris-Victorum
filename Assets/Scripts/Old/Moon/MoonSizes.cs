using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Sets the scale of the moon
1 = 5
2 = 7.5
3 = 10
4 = 12.5
5 = 15
6 = 17.5
7 = 20
8 = 22.5
*/

namespace Assets.Scripts.Moon {
    class MoonSizes {

        public float MoonSize(int moonSize) {
            switch (moonSize) {
                case 1:
                    return .5f;
                case 2:
                    return .55f;
                case 3:
                    return .60f;
                case 4:
                    return .65f;
                case 5:
                    return .70f;
                case 6:
                    return .75f;
                case 7:
                    return .80f;
                case 8:
                    return .85f;
                default:
                    return .5f;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Moon {
    class MoonLevel {
        public string GetMoonTexture(int moonLevel) {
            switch (moonLevel) {
                case 1:
                    return "Moon1";
                case 2:
                    return "Moon2";
                default:
                    return "Moon1";
            }
        }
    }
}

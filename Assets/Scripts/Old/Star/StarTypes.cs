using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Star {
    class StarTypes {

        public string StarTypeLookup(int starType) {
            switch (starType) {
                case 10:
                    return "BlueStarSmall";
                case 11:
                    return "BlueStarMedium";
                case 12:
                    return "BlueStarLarge";
                case 13:
                    return "BlueStarExtraLarge";
                case 14:
                    return "BlueStarGigantic";
                case 20:
                    return "OrangeStarSmall";
                case 21:
                    return "OrangeStarMedium";
                case 22:
                    return "OrangeStarLarge";
                case 23:
                    return "OrangeStarExtraLarge";
                case 24:
                    return "OrangeStarGigantic";
                case 30:
                    return "RedStarSmall";
                case 31:
                    return "RedStarMedium";
                case 32:
                    return "RedStarLarge";
                case 33:
                    return "RedStarExtraLarge";
                case 34:
                    return "RedStarGigantic";
                case 40:
                    return "YellowStarSmall";
                case 41:
                    return "YellowStarMedium";
                case 42:
                    return "YellowStarLarge";
                case 43:
                    return "YellowStarExtraLarge";
                case 44:
                    return "YellowStarGigantic";
                default:
                    return "YellowStarMedium";
            }
        }
    }
}

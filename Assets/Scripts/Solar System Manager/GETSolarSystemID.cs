using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Solar_System_Manager
{
    class GETSolarSystemID:MonoBehaviour
    {
        public int GetSolarSystemID()
        {
            switch (GameData.CurrentScene)
            {
                case "SolarSystem1":
                    return 1001;
                case "SolarSystem2":
                    return 1002;
                case "SolarSystem3":
                    return 1003;
                case "SolarSystem4":
                    return 1004;
                case "SolarSystem5":
                    return 1005;
                case "SolarSystem6":
                    return 1006;
                case "SolarSystem7":
                    return 1007;
                case "SolarSystem8":
                    return 1008;
                case "SolarSystem9":
                    return 1009;
                case "SolarSystem10":
                    return 1010;
                case "SolarSystem11":
                    return 1011;
                default:
                    return 1001;
            }
        }
    }
}

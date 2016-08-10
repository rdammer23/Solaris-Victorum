using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts {
    class RandomNumber:MonoBehaviour {
        System.Random rnd = new System.Random();

        public int RandomNumberInt(int min, int max)
        {
            return rnd.Next(min, max+1);
        }

        public int Sign()
        {
            if (RandomNumberInt(1, 2) == 1)
            {
                return 1;
            }
            return -1;
        }
    }
}

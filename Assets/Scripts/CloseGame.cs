using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class CloseGame:MonoBehaviour
    {
        public void QuitGame()
        {
            //TODO Need to save all data before quitting.
            Application.Quit();
        }
    }
}

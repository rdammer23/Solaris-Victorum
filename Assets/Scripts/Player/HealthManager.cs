using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class HealthManager:MonoBehaviour
    {
        private UpdateDisplay updateHealth;

        public void ReduceHealth(int healthChange)
        {
            updateHealth = new UpdateDisplay();
            GameData.CurrentHealth -= healthChange;
            updateHealth.HealthUpdate(GameData.CurrentHealth);
        }

        public void IncreaseHealth(int healthChange)
        {
            updateHealth = new UpdateDisplay();
            GameData.CurrentHealth += healthChange;
            if(GameData.CurrentHealth > GameData.MaxHealth)
            {
                GameData.CurrentHealth = GameData.MaxHealth;
            }
            updateHealth.HealthUpdate(GameData.CurrentHealth);
        }
    }
}

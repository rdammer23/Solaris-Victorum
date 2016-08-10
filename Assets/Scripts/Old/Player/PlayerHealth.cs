/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BeardedManStudios.Network;

namespace Assets.Scripts.Player
{
    class PlayerHealth:MonoBehaviour
    {
        int maxHealth = 2000;
        static int currentHealth = 1000;

        UpdateDisplay _newHealth;

        public void Awake()
        {
            _newHealth = new UpdateDisplay();
            _newHealth.HealthUpdate(currentHealth);
        }

        public void Update()
        {
            if(currentHealth <= 0)
            {
                //TODO DIE
            }
        }

        public void HealthChange(int healthChange)
        {
            currentHealth = currentHealth + healthChange;

            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
            _newHealth = new UpdateDisplay();
            _newHealth.HealthUpdate(currentHealth);
        }
    }
}
*/
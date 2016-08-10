using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class UpdateDisplay:MonoBehaviour
    {
        static Text healthText;
        int displayHealth;

        void Start()
        {
            displayHealth = GameData.CurrentHealth;
            HealthUpdate(displayHealth);
        }

        public void HealthUpdate(int currentHealth)
        {
            healthText = GameObject.Find("Health").GetComponentInChildren<Text>();
            this.displayHealth = currentHealth;
            healthText.color = Color.red;
            healthText.text = this.displayHealth.ToString();
        }
    }
}

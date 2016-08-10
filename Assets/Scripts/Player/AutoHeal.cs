using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class AutoHeal:MonoBehaviour
    {
        float autoHealTimer = 0f;
        float timeToAutoHeal = 10f;
        float healHowMuch = .1f;

        HealthManager autoHeal;

        void Start()
        {
            autoHeal = new HealthManager();
        }

        void Update()
        {
            if(GameData.CurrentHealth < GameData.MaxHealth)
            {
                if(autoHealTimer >= timeToAutoHeal)
                {
                    autoHeal.IncreaseHealth((int)(GameData.MaxHealth * healHowMuch));
                    autoHealTimer = 0;
                }
                else
                {
                    autoHealTimer += Time.deltaTime;
                }
            }
        }
    }
}

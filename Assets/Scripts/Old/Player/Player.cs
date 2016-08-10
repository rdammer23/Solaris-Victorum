using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Player
{
    class Player
    {
        private string playerName;
        private int race;
        private int level;
        private int maxHealth;
        private int currentHealth;

        public Player(string playerName, int race, int level)
        {
            this.PlayerName = playerName;
            this.Race = race;
            this.Level = level;
        }

        #region Get and Set
        public string PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }

        public int Race
        {
            get
            {
                return race;
            }

            set
            {
                race = value;
            }
        }

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public int MaxHealth
        {
            get
            {
                return maxHealth;
            }

            set
            {
                maxHealth = value;
            }
        }

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }

            set
            {
                currentHealth = value;
            }
        }
        #endregion
    }
}

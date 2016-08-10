using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPC
{
    class NPC
    {
        private string npcName;
        private int race;
        private int level;
        private int hitPoints;
        private float maxMoveSpeed;
        private float standardMoveSpeedRatio;
        private float maxTurnSpeed;
        private float standardTurnSpeed;
        private int alignment;

        public NPC(int race, int level, int hitPoints, float maxMoveSpeed, float standardMoveSpeedRatio, 
            float maxTurnSpeed, float standardTurnSpeed)
        {
            this.race = race;
            this.level = level;
            this.hitPoints = hitPoints;
            this.maxMoveSpeed = maxMoveSpeed;
            this.standardMoveSpeedRatio = standardMoveSpeedRatio;
            this.maxTurnSpeed = maxTurnSpeed;
            this.standardTurnSpeed = standardTurnSpeed;
        }

        public NPC(string npcName, int hitPoints)
        {
            this.npcName = npcName;
            this.hitPoints = hitPoints;
        }

        public NPC(int race, int alignment)
        {
            this.race = race;
            this.alignment = alignment;
        }


        //There will be a lot more as I build out the NPC





        #region Get and Set
         public string NpcName
        {
            get
            {
                return npcName;
            }

            set
            {
                npcName = value;
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

        public int HitPoints
        {
            get
            {
                return hitPoints;
            }

            set
            {
                hitPoints = value;
            }
        }

        public float MaxMoveSpeed
        {
            get
            {
                return maxMoveSpeed;
            }

            set
            {
                maxMoveSpeed = value;
            }
        }

        public float StandardMoveSpeedRatio
        {
            get
            {
                return standardMoveSpeedRatio;
            }

            set
            {
                standardMoveSpeedRatio = value;
            }
        }

        public float MaxTurnSpeed
        {
            get
            {
                return maxTurnSpeed;
            }

            set
            {
                maxTurnSpeed = value;
            }
        }

        public float StandardTurnSpeed
        {
            get
            {
                return standardTurnSpeed;
            }

            set
            {
                standardTurnSpeed = value;
            }
        }
        public int Alignment
        {
            get
            {
                return alignment;
            }

            set
            {
                alignment = value;
            }
        }

        #endregion
    }
}

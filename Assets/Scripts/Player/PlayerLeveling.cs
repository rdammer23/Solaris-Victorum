using Assets.Scripts.SavingAndLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    class PlayerLeveling:MonoBehaviour
    {
        /*
        * Get Current Level D
        * Get Current XP - GameData.CurrentLevelXP
        * Determine XP needed to next level (current level * 1000)
        * When NPC killed, determine XP Value
            - NPC Level * 40
            - NPC Hobby ID
            - NPC Hobby Level
            - NPC Type ID
            - NPC Type Level
        * Add to current XP
        * if current XP >= xp needed to level save difference
        * level Player
        * Provide new attribute points (need to create a GameData and save for Attribute points not used
        * Get new xp needed to level
        * reset current XP to 0
        * add difference from above to current XP
        - Add Save Functions
        */
        

        static int xpNeeded;
        static int xpNeededPerLevel = 1000;

        static int baseNPCXP = 40;
        static int baseXPEarned;
        static int totalXPEarned;
        static int excessXP; //This is XP greater than what was needed to level and should be applied to next level
        int numberAttributePointsEarned = 10;

        void Start()
        {
            xpNeeded = XPNeededToLevel();

        }

        public void DetermineXPEarned(int npcLevel, int typeID, int typeLevel, int hobbyID, int hobbyLevel)
        {
            baseXPEarned = npcLevel * baseNPCXP;
            totalXPEarned = (int)(baseXPEarned + (baseXPEarned * (TypeXPModifier(typeID) * typeLevel)) + 
                (baseXPEarned * (HobbyXPModifier(hobbyID) * hobbyLevel)));
            IncreasePlayerXP();
            DetermineIfPlayerLeveled();
            //TODO Need to update to use DB and not local save
            //SaveData.SaveXP();
        }

        void IncreasePlayerXP()
        {
            GameData.CurrentLevelXP += totalXPEarned;
            Debug.Log("XP After Kill = " + GameData.CurrentLevelXP);
        }

        void DetermineIfPlayerLeveled()
        {
            if (GameData.CurrentLevelXP >= xpNeeded)
            {
                
                excessXP = GameData.CurrentLevelXP - xpNeeded;

                GameData.PlayerLevel += 1;
                
                //TODO Update to save to DB and not local
                //SaveData.SaveLevel();

                xpNeeded = XPNeededToLevel();
                GameData.CurrentLevelXP = 0 + excessXP;
                GameData.UnUsedAttributePoints += numberAttributePointsEarned;
                //TODO Update to save to DB and not local                
                //SaveData.SaveUnUsedAttributePoints();

            }
        }

        int XPNeededToLevel()
        {
           return (GameData.PlayerLevel * xpNeededPerLevel);
        }

        public float TypeXPModifier(int typeID)
        {
            switch (typeID)
            {
                case 1:
                    return .02f;
                case 2:
                    return 0;
                case 3:
                    return .02f;
                case 4:
                    return .02f;
                case 5:
                    return .1f;
                case 6:
                    return .04f;
                case 7:
                    return .05f;
                case 8:
                    return .04f;
                case 9:
                    return .07f;
                case 10:
                    return .09f;
                case 11:
                    return .05f;
                case 12:
                    return 0;
                case 13:
                    return 0;
                case 14:
                    return .06f;
                case 15:
                    return .095f;
                case 16:
                    return .097f;
                case 17:
                    return .098f;
                case 18:
                    return 0;
                case 19:
                    return .07f;
                case 20:
                    return .1f;
                default:
                    return 0;
            }
        }

        public float HobbyXPModifier(int hobbyID)
        {
            switch (hobbyID)
            {
                case 1:
                    return 0;
                case 2:
                    return .02f;
                case 3:
                    return .02f;
                case 4:
                    return .02f;
                case 5:
                    return .02f;
                case 6:
                    return .02f;
                case 7:
                    return .02f;
                case 8:
                    return .02f;
                case 9:
                    return .02f;
                case 10:
                    return .02f;
                case 11:
                    return .02f;
                case 12:
                    return .05f;
                case 13:
                    return .05f;
                case 14:
                    return .07f;
                case 15:
                    return 0;
                case 16:
                    return 0;
                case 17:
                    return 0;
                case 18:
                    return .02f;
                case 19:
                    return .09f;
                case 20:
                    return .1f;
                default:
                    return 0;
            }
        }
    }
}

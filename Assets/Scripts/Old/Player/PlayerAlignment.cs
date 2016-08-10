using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.NPC;

namespace Assets.Scripts.Player
{
    class PlayerAlignment:MonoBehaviour
    {
        //This will hold the alignment of each race towards this player
        //Once Clans are added, this will also be held here for reference by the NPC

        //Everytime a player engages a NPC, alignment should change
        //Everytime a player kills an NPC, alignment changes more
        //Once quests are added, alignment can go up also

        //TODO Saved File: These valued will need to be read from a saved file eventually

            /// <summary>
            /// NPC.NPC
            /// race ID
            /// Alignment
            /// </summary>
        static public List<NPC.NPC> _alignment;

        public void Awake()
        {
            _alignment = new List<NPC.NPC>();
            _alignment.Add(new NPC.NPC(1, -100));
        }

        public void UpdateAlignment(int race, int alignmentChange)
        {

        }


        public int GetAlignment(int race)
        {
            foreach (NPC.NPC alignment in _alignment)
            {
                if (alignment.Race == race)
                    return alignment.Alignment;
            }
            return 0;
        }
    }
}

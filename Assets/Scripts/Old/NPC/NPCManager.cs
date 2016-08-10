using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.NPC
{
    class NPCManager:MonoBehaviour
    {
        /*
        1. One Manager for all NPCs regardless of Level or Race
        2. Create A List for each NPC Race
            a. List should be called by Race
            b. Need following information minimally
                1. Race
                2. Level
                3. Max Health
                4. Min Health
                5. Current Health
                6. Max Speed
                7. Max Turn Speed
                8. Attack Speed Factors (Min and Max) I think
                9. Patrol Speed Factors
                10. Wander Speed
                11. Avoidance Speed
                12. Flee Speed
                13. Follow Distance (Min and Max)
                14. Attack Min Distance
                15. Weapon Max Range
                16. Bools for all States
                17. Wander Turn Time Min and Max
                18. Find Players Max Distance
                19. Attack Alignment
                20. Follow Alignment????
                21. Laser Mount Locations
        3. Will Instantiate and Pool NPC by Race
            a. Pool Name should be NPC Race Name
            b. Set Current Health based off Level and other modifiers
            c. Set Max Speed based off Level and other modifiers
        4. 
        */
    }
}

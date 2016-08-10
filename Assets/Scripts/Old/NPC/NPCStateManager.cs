using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assets.Scripts.NPC
{
    public static class NPCStateManager
    {
        enum NPCState
        {
            Idle,
            Follow,
            Patrol,
            Wander,
            Attack,
            Avoidance,
            Assist,
            ifAttacked,
            Flee,
            Dead,
            Spawning
        }
    }
}

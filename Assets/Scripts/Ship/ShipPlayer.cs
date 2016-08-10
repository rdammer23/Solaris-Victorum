using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Ship
{
    class ShipPlayer
    {
        public string ShipName(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return "Shuttle";
                case 2:
                    return "Tiny";
                case 3:
                    return "Small";
                default:
                    return "ErrorGettingShipName";
            }
        }

        public float MoveForce(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 25f;
                default:
                    return 0f;
            }
        }

        public float TurnForce(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return .5f;
                default:
                    return 0f;
            }
        }

        public float MaxTurnRightLeft(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 10f;
                default:
                    return 0f;
            }
        }

        public float MaxTurnUpDown(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 10f;
                default:
                    return 0f;
            }
        }

        public int ShipWeight(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 1000; //This will be trail and error to figure out right values
                default:
                    return 0;
            }
        }

        public int ShipHull(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 800;
                case 2:
                    return 1000;
                case 3:
                    return 1200;
                default:
                    return 15;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public int ShipWeaponViewWidth(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 150;
                case 2:
                    return 175;
                case 3:
                    return 190;
                default:
                    return 15;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public int ShipWeaponViewHeight(int shipID)
        {
            switch (shipID)
            {
                case 1:
                    return 150;
                case 2:
                    return 175;
                case 3:
                    return 190;
                default:
                    return 15;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float MaxWeaponDamage(int shipID)
        {
            //This is without a Weapon Installed.  If Weapon Installed, then use that instead
            switch (shipID)
            {
                case 1:
                    return 50f;
                case 2:
                    return 60f;
                case 3:
                    return 70f;
                default:
                    return 15f;  //If I ever see a NPC with 15 I know it errored out.
            }
        }

        public float MinWeaponDamage(int shipID)
        {
            //This is without a Weapon Installed.  If Weapon Installed, then use that instead
            switch (shipID)
            {
                case 1:
                    return 25f;
                case 2:
                    return 30f;
                case 3:
                    return 35f;
                default:
                    return 5f;  //If I ever see a NPC with 5 I know it errored out.
            }
        }
    }
}

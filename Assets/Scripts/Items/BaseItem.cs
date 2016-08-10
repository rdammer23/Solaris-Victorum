using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Items
{
    [System.Serializable]
    class BaseItem
    {
        private string itemName;
        private string itemDescription;
        private int itemID;
        public enum ItemType
        {
            PLAYEREQUIPMENT,

            SHIPEQUIPMENT,
            SHIPWEAPON

            
            /*HEAD,
            FACE,
            EARS,
            EYES,

            ARMS,
            HAND,
            FINGER,

            CHEST,
            FULLBODY,
            TAIL,

            LEGS,
            FEET,

            SHIPENGINE,
            SHIPARMOR,
            SHIPGUN,
            SHIPCOMPUTER,
            SHIPSHIELD,
            SHIPSTORAGE,
            SHIPSPECIAL
                */
        }
        private ItemType itemType;

        #region Get and Sets
        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public string ItemDescription
        {
            get
            {
                return itemDescription;
            }

            set
            {
                itemDescription = value;
            }
        }

        public int ItemID
        {
            get
            {
                return itemID;
            }

            set
            {
                itemID = value;
            }
        }

        internal ItemType ItemType1
        {
            get
            {
                return itemType;
            }

            set
            {
                itemType = value;
            }
        }
        #endregion
    }
}

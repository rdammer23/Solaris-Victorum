using Assets.Scripts.Attributes;
using Assets.Scripts.NPC_Classes.NPC_Hobby;
using Assets.Scripts.NPC_Classes.Ships;
using Assets.Scripts.NPC_Classes.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.PoolManagers
{
    class InitializePoolManagers:MonoBehaviour
    {
        static RandomNumber randNum;
        static AttributeAdjustment _attributeAdj;
        static ShipStatAdj _shipStat;
        static TypeStatAdj _typeAdj;
        static HobbyStatAdj _hobbyAdj;

        static NPCShuttleShipClass _shuttleShip;
        static NPCTinyShipClass _tinyShip;
        static NPCSmallShipClass _smallShip;

        List<BaseNPCShip> _ship;

        int numberHobbies = 20;
        int numberTypes = 20;
        int startingAttributePoints = 10;

        public void Start()
        {
            randNum = new RandomNumber();
            _attributeAdj = new AttributeAdjustment();
            _typeAdj = new TypeStatAdj();
            _hobbyAdj = new HobbyStatAdj();

            _shipStat = new ShipStatAdj();

            _shuttleShip = new NPCShuttleShipClass();
            _tinyShip = new NPCTinyShipClass();
            _smallShip = new NPCSmallShipClass();

        }

        public string RenameNPC(Transform oldName, int npcNumber)
        {
            return oldName.name = (oldName.name + npcNumber);
        }

        public void AddToCorrectPooler(GameObject g, GameObject pooler)
        {
            g.transform.parent = pooler.transform;
        }

        public int SetType()
        {
            int npcType = randNum.RandomNumberInt(1, numberTypes);
            if (npcType == 5)
            {
                SetType();
                return npcType;
            }
            return npcType;
        }

        public int SetHobby()
        {
            return randNum.RandomNumberInt(1, numberHobbies);
        }

        public int SetShipID(GameObject g)
        {
            if (g.transform.gameObject.HasTag("Ship1"))
            {
                return 1;
            }
            else if (g.transform.gameObject.HasTag("Ship2"))
            {
                return 2;
            }
            else if (g.transform.gameObject.HasTag("Ship3"))
            {
                return 3;
            }
            return 1;
        }

        public int SetNPCLevel()
        {
            //Should base it off the player level
            //Go 2 levels below and 10 levels above

            /*TODO Uncomment this once I am running from begining
            if (GameData.PlayerLevel < 5)
            {
                return randNum.RandomNumberInt(1, 10);
            }
            else
            {
                return randNum.RandomNumberInt(GameData.PlayerLevel - 2, GameData.PlayerLevel + 10);
            }
            */

            //Comment this out once I uncomment the above
            return randNum.RandomNumberInt(1, 10);
        }

        public int SetNPCHobbyLevel(int npcLevel)
        {
            //To make sure Hobby Level does not exceed 500
            if(npcLevel > 250)
            {
                npcLevel = 250;
            }
            return randNum.RandomNumberInt(npcLevel, npcLevel * 2);
        }

        public float SetAttributeValues(float raceModifier, int npcLevel)
        {
            return ((startingAttributePoints + (npcLevel - 1)) * raceModifier);
        }

        public float ToHit(float attributeValue, int typeID, int hobbyID, int hobbyLevel)
        {
            return ((attributeValue * _attributeAdj.EagleEyes()) + _hobbyAdj.HobbyAdjToHit(hobbyID) * hobbyLevel + _typeAdj.TypeAdjToHit(typeID));
        }

        public float Evasion(float attributeValue, int typeID, int hobbyID, int hobbyLevel)
        {
            return ((attributeValue * _attributeAdj.Dexterity()) + _hobbyAdj.HobbyAdjEvasion(hobbyID) * hobbyLevel + _typeAdj.TypeAdjEvasion(typeID));
        }

        public float HullIncrease(float attributeValue, int typeID, int hobbyID, int hobbyLevel)
        {
            return ((attributeValue * _attributeAdj.Health()) + _hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel + _typeAdj.TypeAdjHull(typeID));
        }

        public float DamageIncrease(float attributeValue, int typeID, int hobbyID, int hobbyLevel)
        {
            Debug.Log("strength adj: " + attributeValue * _attributeAdj.Strength());
            Debug.Log("hobby adj: " + _hobbyAdj.HobbyAdjDamage(hobbyID) * hobbyLevel + " HI:"+hobbyID + " HL:" + hobbyLevel);
            Debug.Log("Type adj: " + _typeAdj.TypeAdjDamage(typeID));
            return ((attributeValue * _attributeAdj.Strength()) + (_hobbyAdj.HobbyAdjDamage(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
        }

        public float ShipSpeedIncrease(float attributeValue, int typeID, int hobbyID, int hobbyLevel)
        {
            return ((attributeValue * _attributeAdj.Endurance()) + (_hobbyAdj.HobbyAdjSpeed(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjSpeed(typeID));
        }

        public float WeaponCoolDownDecrease(float attributeValue, int typeID, int hobbyID, int hobbyLevel)
        {
            return ((attributeValue * _attributeAdj.Speed()) + (_hobbyAdj.HobbyAdjWeaponCooldown(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjWeaponCooldown(typeID));
        }

        public float ShipVolumeIncrease(float attributeValue, int typeID, int hobbyID, int hobbyLevel)
        {
            return ((attributeValue * _attributeAdj.Intelligence()) + (_hobbyAdj.HobbyAdjShipVolume(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjShipVolume(typeID));
        }

        public float CritChanceIncrease(float attributeValue, int typeID, int hobbyID, int hobbyLevel)
        {
            return ((attributeValue * _attributeAdj.NervesOfSteel()) + (_hobbyAdj.HobbyAdjCritHit(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjCritHit(typeID));
        }

        public float CritDamageIncrease(int typeID, int hobbyID, int hobbyLevel)
        {
            return ((_hobbyAdj.HobbyAdjCritDamageIncrease(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjCritDamageIncrease(typeID));
        }

        public float ExtraShotChance(int typeID, int hobbyID, int hobbyLevel)
        {
            return ((_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
        }

        public float StunChanceIncrease(int typeID, int hobbyID, int hobbyLevel)
        {
            return ((_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
        }

        public float StunDurationIncrease(int typeID, int hobbyID, int hobbyLevel)
        {
            return ((_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
        }

        public float TractorBeamChanceIncrease(int typeID, int hobbyID, int hobbyLevel)
        {
            return ((_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
        }

        public float EnergyConversion(int typeID, int hobbyID, int hobbyLevel)
        {
            return ((_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
        }

        public float CloakChanceIncrease(int typeID, int hobbyID, int hobbyLevel)
        {
            return ((_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
        }

        public float CloakAllChanceIncrease(int typeID, int hobbyID, int hobbyLevel)
        {
            return ((_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
        }

        public float InstantKillChanceIncrease(int typeID, int hobbyID, int hobbyLevel)
        {
            return ((_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID));
        }

        public List<BaseNPCShip> SetShipStats(GameObject g)
        {
            List<BaseNPCShip> _ship = new List<BaseNPCShip>();

            if (g.transform.gameObject.HasTag("Ship1"))
            {
                //_shuttleShip = new NPCShuttleShipClass();
                _ship.Add(new BaseNPCShip(_shuttleShip.NpcShipName,
                                            _shuttleShip.NpcShipID,
                                            _shuttleShip.FindPlayerMaxDistance,
                                            _shuttleShip.WanderSpeed,
                                            _shuttleShip.WanderSpeedTurnSpeedFactor,
                                            _shuttleShip.PatrolSpeed,
                                            _shuttleShip.PatrolSpeedTurnFactor,
                                            _shuttleShip.FollowMaxSpeed,
                                            _shuttleShip.FollowTurnSpeedFactor,
                                            _shuttleShip.FollowMaxDistance,
                                            _shuttleShip.FollowMinDistance,
                                            _shuttleShip.AttackSpeed,
                                            _shuttleShip.AttackTurnSpeedFactor,
                                            _shuttleShip.AttackTurnDistance,
                                            _shuttleShip.AttackMaxDistance,
                                            _shuttleShip.AttackMinDistance,
                                            _shuttleShip.AvoidanceDistance,
                                            _shuttleShip.AvoidanceSpeed,
                                            _shuttleShip.AvoidanceTurnSpeedFactor,
                                            _shuttleShip.Hull,
                                            _shuttleShip.MaxWeaponDamage,
                                            _shuttleShip.MinWeaponDamage,
                                            _shuttleShip.WeaponCoolDown,
                                            _shuttleShip.MaxShipVolume,
                                            _shuttleShip.EvasionModifier));
                return _ship;
            }
            else if (g.transform.gameObject.HasTag("Ship2"))
            {
                //_tinyShip = new NPCTinyShipClass();
                _ship.Add(new BaseNPCShip(_tinyShip.NpcShipName,
                                            _tinyShip.NpcShipID,
                                            _tinyShip.FindPlayerMaxDistance,
                                            _tinyShip.WanderSpeed,
                                            _tinyShip.WanderSpeedTurnSpeedFactor,
                                            _tinyShip.PatrolSpeed,
                                            _tinyShip.PatrolSpeedTurnFactor,
                                            _tinyShip.FollowMaxSpeed,
                                            _tinyShip.FollowTurnSpeedFactor,
                                            _tinyShip.FollowMaxDistance,
                                            _tinyShip.FollowMinDistance,
                                            _tinyShip.AttackSpeed,
                                            _tinyShip.AttackTurnSpeedFactor,
                                            _tinyShip.AttackTurnDistance,
                                            _tinyShip.AttackMaxDistance,
                                            _tinyShip.AttackMinDistance,
                                            _tinyShip.AvoidanceDistance,
                                            _tinyShip.AvoidanceSpeed,
                                            _tinyShip.AvoidanceTurnSpeedFactor,
                                            _tinyShip.Hull,
                                            _tinyShip.MaxWeaponDamage,
                                            _tinyShip.MinWeaponDamage,
                                            _tinyShip.WeaponCoolDown,
                                            _tinyShip.MaxShipVolume,
                                            _tinyShip.EvasionModifier));
                return _ship;
            }
            else if (g.transform.gameObject.HasTag("Ship3"))
            {
                //_smallShip = new NPCSmallShipClass();
                _ship.Add(new BaseNPCShip(_smallShip.NpcShipName,
                                            _smallShip.NpcShipID,
                                            _smallShip.FindPlayerMaxDistance,
                                            _smallShip.WanderSpeed,
                                            _smallShip.WanderSpeedTurnSpeedFactor,
                                            _smallShip.PatrolSpeed,
                                            _smallShip.PatrolSpeedTurnFactor,
                                            _smallShip.FollowMaxSpeed,
                                            _smallShip.FollowTurnSpeedFactor,
                                            _smallShip.FollowMaxDistance,
                                            _smallShip.FollowMinDistance,
                                            _smallShip.AttackSpeed,
                                            _smallShip.AttackTurnSpeedFactor,
                                            _smallShip.AttackTurnDistance,
                                            _smallShip.AttackMaxDistance,
                                            _smallShip.AttackMinDistance,
                                            _smallShip.AvoidanceDistance,
                                            _smallShip.AvoidanceSpeed,
                                            _smallShip.AvoidanceTurnSpeedFactor,
                                            _smallShip.Hull,
                                            _smallShip.MaxWeaponDamage,
                                            _smallShip.MinWeaponDamage,
                                            _smallShip.WeaponCoolDown,
                                            _smallShip.MaxShipVolume,
                                            _smallShip.EvasionModifier));
                return _ship;
            }

            _ship.Add(_smallShip);
            return _ship;
        }

        public float MaxHealth(float maxHullModifier, float shipHull)
        {
            return maxHullModifier * shipHull + shipHull;
        }

        public float SpeedAdjustment(float speedModifier, float shipBaseSpeed)
        {
            return shipBaseSpeed + shipBaseSpeed * speedModifier;
        }

        public float TurnSpeedAdjustment(float turnSpeedFactor, float standardSpeed)
        {
            return standardSpeed / turnSpeedFactor;
        }

        public float ShipVolume(float attributeValue, int typeID, int hobbyID, int hobbyLevel, float standardVolume)
        {
            return standardVolume + standardVolume * (((attributeValue * _attributeAdj.Intelligence()) + (_hobbyAdj.HobbyAdjHull(hobbyID) * hobbyLevel) + _typeAdj.TypeAdjDamage(typeID)));
        }

        public float MaxDamage(float damageModifier, float standardMaxDamage)
        {
            Debug.Log("Damage Modifier" + damageModifier);
            return standardMaxDamage + standardMaxDamage * damageModifier;
        }
    }
}

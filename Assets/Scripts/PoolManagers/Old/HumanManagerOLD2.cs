using Assets.Scripts.Attributes;
using Assets.Scripts.NPC_Classes.Attributes;
using Assets.Scripts.NPC_Classes.NPC_Hobby;
using Assets.Scripts.NPC_Classes.Ships;
using Assets.Scripts.NPC_Classes.Types;
using Assets.Scripts.Race_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.PoolManagers
{
    /*
    This will not activate until ALL NPC Have been instantiated
    Find ALL NPC of given race
    For Each NPC, set the values of the NPC Class
    Add to Pool
    Start runs to initialize everything
    Upate will be used to actually manage the NPCs

    Need to figure out what planet this race owns
    */

        
    class HumanManagerOLD2 :MonoBehaviour
    {
        RandomNumber randNum;
        NOTUSEDNPCAttributeValues _npcAttribute;

        HumanRace _humanRace;

        ShipStatAdj _shipStat;
        TypeStatAdj _typeAdj;
        HobbyStatAdj _hobbyAdj;

        NPCShuttleShipClass _shuttleShip;
        NPCTinyShipClass _tinyShip;
        NPCSmallShipClass _smallShip;

        AttributeAdjustment attributeAdjustment;

        NPC_Classes.NPC newNPC;

        public List<GameObject> humanNPC;

        public GameObject humanNPCPooler;

        private int numberOfDefenders = 5;
        private int attributePointsPerLevel = 10;
        private int startingAttributeValue = 10;
        /*
        private void Start()
        {
            GameObject[] gos = MultiTags.FindGameObjectsWithMultiTag("NPCHuman");
            randNum = new RandomNumber();

            _npcAttribute = new NOTUSEDNPCAttributeValues();

            _humanRace = new HumanRace();

            _shipStat = new ShipStatAdj();
            _typeAdj = new TypeStatAdj();
            _hobbyAdj = new HobbyStatAdj();

            attributeAdjustment = new AttributeAdjustment();

            int x = 1; //This is to make sure the first X NPCs of a given race are Defenders - Type 5
            int numberHobbies = 19; //I have excluded Assassin as a possible choice.


            foreach (GameObject g in gos)
            {
                newNPC = new NPC_Classes.NPC(0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                    0, 0, 0);

                g.transform.name = g.transform.name + x;
                g.transform.parent = humanNPCPooler.transform;

                //Set Race ID
                newNPC.RaceID = 1;

                //Set NPC Level  
                //Should base it off the player level
                //Go 2 levels below and 10 levels above

                /*TODO Uncomment this once I am running from begining
                if (GameData.PlayerLevel < 5)
                {
                    newNPC.NpcLevel = randNum.RandomNumberInt(1, 10);
                }
                else
                {
                    newNPC.NpcLevel = randNum.RandomNumberInt(GameData.PlayerLevel - 2, GameData.PlayerLevel + 10);
                }
                */
                /*
                //Comment this out once I uncomment the above
                newNPC.NpcLevel = randNum.RandomNumberInt(1, 10);


                //Set Hobby Level
                newNPC.HobbyLevel = randNum.RandomNumberInt(newNPC.NpcLevel, newNPC.NpcLevel + 10);

                //Set Type ID
                if(x <= numberOfDefenders)
                {
                    newNPC.TypeID = 5;
                }
                else
                {
                    newNPC.TypeID = SetType();
                }

                //Set Hobby ID
                newNPC.HobbyID = randNum.RandomNumberInt(1, numberHobbies);


                //Ship Values
                if (g.transform.gameObject.HasTag("Ship1"))
                {
                    ShuttleShip();
                }
                else if(g.transform.gameObject.HasTag("Ship2"))
                {
                    TinyShip();
                }
                else if (g.transform.gameObject.HasTag("Ship3"))
                {
                    SmallShip();
                }

                //Set Initial Attribute Values
                InitialAttributeValues();

                //Incrase Attributes Based on NPC Level
                IncreaseAttributes();

                MaxHealth();

                SpeedAdjustments();

                WeaponDamageAdjustment();

                WeaponCoolDownAdjustment();

                ShipVolumeAdjustment();

                NPCEnergyConversion();

                NPCToHit();

                NPCCritHitChance();

                newNPC.NpcHullIncrease = 1;//currently not used and may not need

                NPCTractorBeamChance();

                newNPC.NpcShipSpeedIncrease = 1; //Currently not used and may not need

                NPCEvasion();

                newNPC.NpcDamageIncrease = 1; //Currently not used and may not need

                NPCCritDamageIncrease();

                x++;
                
            }
        }
        */
        /*
        public void NPCCritDamageIncrease()
        {
            Debug.Log("Original To crit damage: " + newNPC.NpcCriticalDamageIncrease);
            //newNPC.NpcCriticalDamageIncrease += ((newNPC.Dexterity * attributeAdjustment.Dexterity()));
            newNPC.NpcCriticalDamageIncrease += (((_hobbyAdj.HobbyAdjCritDamageIncrease(newNPC.HobbyID)) * newNPC.HobbyLevel));
            newNPC.NpcCriticalDamageIncrease += _typeAdj.TypeAdjCritDamageIncrease(newNPC.TypeID) - 1;
            //Debug.Log((newNPC.Dexterity * attributeAdjustment.Dexterity()));
            Debug.Log("Hobby ID = " + newNPC.HobbyID + " Hobby Level: " + newNPC.HobbyLevel + " " + (((_hobbyAdj.HobbyAdjEvasion(newNPC.HobbyID)) * newNPC.HobbyLevel)));
            Debug.Log("Type ID: " + newNPC.TypeID + " " + _typeAdj.TypeAdjCritDamageIncrease(newNPC.TypeID));
            Debug.Log("New To Hit: " + newNPC.NpcCriticalDamageIncrease);
            Debug.Log("*********************************");
        }

        public void NPCEvasion()
        {
            newNPC.NpcEvasionIncrease += ((newNPC.Dexterity * attributeAdjustment.Dexterity()));
            newNPC.NpcEvasionIncrease += (((_hobbyAdj.HobbyAdjEvasion(newNPC.HobbyID)) * newNPC.HobbyLevel));
            newNPC.NpcEvasionIncrease += _typeAdj.TypeAdjEvasion(newNPC.TypeID) - 1;
        }

        public void NPCTractorBeamChance()
        {
            newNPC.NpcTractorBeamIncreaseChance += (((_hobbyAdj.HobbyAdjTractorBeamChance(newNPC.HobbyID)) * newNPC.HobbyLevel));
            newNPC.NpcTractorBeamIncreaseChance += _typeAdj.TypeAdjTractorBeamChance(newNPC.TypeID) - 1;
        }

        public void NPCCritHitChance()
        {
            newNPC.NpcCritHitChance += ((newNPC.EagleEyes * attributeAdjustment.NervesOfSteel()));
            newNPC.NpcCritHitChance += (((_hobbyAdj.HobbyAdjCritHit(newNPC.HobbyID)) * newNPC.HobbyLevel));
            newNPC.NpcCritHitChance += _typeAdj.TypeAdjCritHit(newNPC.TypeID) - 1;
        }

        public void NPCToHit()
        {
            newNPC.NpcToHit += ((newNPC.EagleEyes * attributeAdjustment.EagleEyes()));
            newNPC.NpcToHit += (((_hobbyAdj.HobbyAdjToHit(newNPC.HobbyID)) * newNPC.HobbyLevel));
            newNPC.NpcToHit += _typeAdj.TypeAdjToHit(newNPC.TypeID)-1;
        }

        public void NPCEnergyConversion()
        {
            newNPC.NpcEnergyConversion += (((_hobbyAdj.HobbyAdjEnergyConversion(newNPC.HobbyID)) * newNPC.HobbyLevel));
            newNPC.NpcEnergyConversion += _typeAdj.TypeAdjEnergyConversion(newNPC.TypeID) - 1;
        }

        public void ShipVolumeAdjustment()
        {
            newNPC.MaxShipVolume = newNPC.MaxShipVolume * ((newNPC.Intelligence * attributeAdjustment.Intelligence())/10 + 1);
            newNPC.MaxShipVolume = newNPC.MaxShipVolume * (((_hobbyAdj.HobbyAdjShipVolume(newNPC.HobbyID)) * newNPC.HobbyLevel) + 1);
            newNPC.MaxShipVolume = newNPC.MaxShipVolume * _typeAdj.TypeAdjShipVolume(newNPC.TypeID);
        }

        public void WeaponCoolDownAdjustment()
        {
            //This is stored with the ship and can probably be removed.
            newNPC.WeaponCoolDown = newNPC.WeaponCoolDown * (1 - (newNPC.Speed * attributeAdjustment.Speed()));
            newNPC.WeaponCoolDown = newNPC.WeaponCoolDown * ((1 - ((_hobbyAdj.HobbyAdjWeaponCooldown(newNPC.HobbyID)) * newNPC.HobbyLevel)));
            newNPC.WeaponCoolDown = newNPC.WeaponCoolDown * _typeAdj.TypeAdjWeaponCooldown(newNPC.TypeID);

            //This is the main weapon cooldown.
            newNPC.NpcWeaponCoolDown = newNPC.NpcWeaponCoolDown * (1 - (newNPC.Speed * attributeAdjustment.Speed()));
            newNPC.NpcWeaponCoolDown = newNPC.NpcWeaponCoolDown * ((1 - ((_hobbyAdj.HobbyAdjWeaponCooldown(newNPC.HobbyID)) * newNPC.HobbyLevel)));
            newNPC.NpcWeaponCoolDown = newNPC.NpcWeaponCoolDown * _typeAdj.TypeAdjWeaponCooldown(newNPC.TypeID);

        }

        public void WeaponDamageAdjustment()
        {
            newNPC.MaxWeaponDamage = newNPC.MaxWeaponDamage * newNPC.Strength * attributeAdjustment.Strength();
            newNPC.MaxWeaponDamage = newNPC.MaxWeaponDamage * (((_hobbyAdj.HobbyAdjDamage(newNPC.HobbyID)) * newNPC.HobbyLevel) + 1);
            newNPC.MaxWeaponDamage = newNPC.MaxWeaponDamage * _typeAdj.TypeAdjSpeed(newNPC.TypeID);

            newNPC.MinWeaponDamage = newNPC.MaxWeaponDamage / 2;
        }

        public void SpeedAdjustments()
        {
            //Speeds are stored in the Ship Variables
            newNPC.WanderSpeed = newNPC.WanderSpeed * newNPC.Endurance * attributeAdjustment.Endurance();
            newNPC.WanderSpeed = newNPC.WanderSpeed * (((_hobbyAdj.HobbyAdjSpeed(newNPC.HobbyID)) * newNPC.HobbyLevel) + 1);
            newNPC.WanderSpeed = newNPC.WanderSpeed * _typeAdj.TypeAdjSpeed(newNPC.TypeID);

            newNPC.PatrolSpeed = newNPC.PatrolSpeed * newNPC.Endurance * attributeAdjustment.Endurance();
            newNPC.PatrolSpeed = newNPC.PatrolSpeed * (((_hobbyAdj.HobbyAdjSpeed(newNPC.HobbyID)) * newNPC.HobbyLevel) + 1);
            newNPC.PatrolSpeed = newNPC.PatrolSpeed * _typeAdj.TypeAdjSpeed(newNPC.TypeID);

            newNPC.FollowMaxSpeed = newNPC.FollowMaxSpeed * newNPC.Endurance * attributeAdjustment.Endurance();
            newNPC.FollowMaxSpeed = newNPC.FollowMaxSpeed * (((_hobbyAdj.HobbyAdjSpeed(newNPC.HobbyID)) * newNPC.HobbyLevel) + 1);
            newNPC.FollowMaxSpeed = newNPC.FollowMaxSpeed * _typeAdj.TypeAdjSpeed(newNPC.TypeID);

            newNPC.AttackSpeed = newNPC.AttackSpeed * newNPC.Endurance * attributeAdjustment.Endurance();
            newNPC.AttackSpeed = newNPC.AttackSpeed * (((_hobbyAdj.HobbyAdjSpeed(newNPC.HobbyID)) * newNPC.HobbyLevel) + 1);
            newNPC.AttackSpeed = newNPC.AttackSpeed * _typeAdj.TypeAdjSpeed(newNPC.TypeID);

            newNPC.AvoidanceSpeed = newNPC.AvoidanceSpeed * newNPC.Endurance * attributeAdjustment.Endurance();
            newNPC.AvoidanceSpeed = newNPC.AvoidanceSpeed * (((_hobbyAdj.HobbyAdjSpeed(newNPC.HobbyID)) * newNPC.HobbyLevel) + 1);
            newNPC.AvoidanceSpeed = newNPC.AvoidanceSpeed * _typeAdj.TypeAdjSpeed(newNPC.TypeID);

        }

        public void MaxHealth()
        {
            //NPC Health * Health Attribute Adjustment + Ship base hull
            newNPC.MaxHealth = newNPC.Health * attributeAdjustment.Health() + newNPC.ShipHull;

            //Current Max Hull * Type ADJ
            newNPC.MaxHealth *= _typeAdj.TypeAdjHull(newNPC.TypeID);

            //Current Max Hull *(Hobbyadj/100 * hobby Level)
            newNPC.MaxHealth += (newNPC.MaxHealth * (_hobbyAdj.HobbyAdjHull(newNPC.HobbyID) / 100) * newNPC.HobbyLevel);

            newNPC.CurrentHealth = newNPC.MaxHealth;
        }

        public void InitialAttributeValues()
        {
            newNPC.Strength = _npcAttribute.InitialAttributes(_humanRace.RaceStrength);
            newNPC.Intelligence = _npcAttribute.InitialAttributes(_humanRace.RaceIntelligence);
            newNPC.Dexterity = _npcAttribute.InitialAttributes(_humanRace.RaceDexterity);
            newNPC.Wisdom = _npcAttribute.InitialAttributes(_humanRace.RaceWisdom);
            newNPC.Health = _npcAttribute.InitialAttributes(_humanRace.RaceHealth);
            newNPC.EagleEyes = _npcAttribute.InitialAttributes(_humanRace.RaceEagleEyes);
            newNPC.Speed = _npcAttribute.InitialAttributes(_humanRace.RaceSpeed);
            newNPC.Endurance = _npcAttribute.InitialAttributes(_humanRace.RaceEndurance);
            newNPC.NervesOfSteel = _npcAttribute.InitialAttributes(_humanRace.RaceNervesOfSteel);
            newNPC.Charisma = _npcAttribute.InitialAttributes(_humanRace.RaceCharisma);
        }

        public void ShuttleShip()
        {
            newNPC.ShipHull = (int)_shipStat.Shuttle("Hull");

            newNPC.FindPlayerMaxDistance = _shipStat.Shuttle("FindPlayerMaxDistance");

            newNPC.WanderSpeed = _shipStat.Shuttle("WanderSpeed");
            newNPC.WanderSpeedTurnSpeedFactor = _shipStat.Shuttle("WanderSpeedTurnSpeedFactor");

            newNPC.PatrolSpeed = _shipStat.Shuttle("PatrolSpeed");
            newNPC.PatrolSpeedTurnFactor = _shipStat.Shuttle("PatrolSpeedTurnFactor");

            newNPC.FollowMaxSpeed = _shipStat.Shuttle("FollowMaxSpeed");
            newNPC.FollowTurnSpeedFactor = _shipStat.Shuttle("FollowTurnSpeedFactor");
            newNPC.FollowMaxDistance = _shipStat.Shuttle("FollowMaxDistance");
            newNPC.FollowMinDistance = _shipStat.Shuttle("FollowMinDistance");

            newNPC.AttackSpeed = _shipStat.Shuttle("AttackSpeed");
            newNPC.AttackTurnSpeedFactor = _shipStat.Shuttle("AttackTurnSpeedFactor");
            newNPC.AttackTurnDistance = _shipStat.Shuttle("AttackTurnDistance");
            newNPC.AttackMaxDistance = _shipStat.Shuttle("AttackMaxDistance");
            newNPC.AttackMinDistance = _shipStat.Shuttle("AttackMinDistance");

            newNPC.AvoidanceDistance = _shipStat.Shuttle("AvoidanceDistance");
            newNPC.AvoidanceSpeed = _shipStat.Shuttle("AvoidanceSpeed");
            newNPC.AvoidanceTurnSpeedFactor = _shipStat.Shuttle("AvoidanceTurnSpeedFactor");

            newNPC.MaxWeaponDamage = _shipStat.Shuttle("MaxWeaponDamage");
            newNPC.MinWeaponDamage = _shipStat.Shuttle("MinWeaponDamage");
            newNPC.WeaponCoolDown = _shipStat.Shuttle("WeaponCoolDown");

            newNPC.MaxShipVolume = _shipStat.Shuttle("MaxShipVolume");
        }

        public void TinyShip()
        {
            newNPC.ShipHull = (int)_shipStat.Tiny("Hull");

            newNPC.FindPlayerMaxDistance = _shipStat.Tiny("FindPlayerMaxDistance");

            newNPC.WanderSpeed = _shipStat.Tiny("WanderSpeed");
            newNPC.WanderSpeedTurnSpeedFactor = _shipStat.Tiny("WanderSpeedTurnSpeedFactor");

            newNPC.PatrolSpeed = _shipStat.Tiny("PatrolSpeed");
            newNPC.PatrolSpeedTurnFactor = _shipStat.Tiny("PatrolSpeedTurnFactor");

            newNPC.FollowMaxSpeed = _shipStat.Tiny("FollowMaxSpeed");
            newNPC.FollowTurnSpeedFactor = _shipStat.Tiny("FollowTurnSpeedFactor");
            newNPC.FollowMaxDistance = _shipStat.Tiny("FollowMaxDistance");
            newNPC.FollowMinDistance = _shipStat.Tiny("FollowMinDistance");

            newNPC.AttackSpeed = _shipStat.Tiny("AttackSpeed");
            newNPC.AttackTurnSpeedFactor = _shipStat.Tiny("AttackTurnSpeedFactor");
            newNPC.AttackTurnDistance = _shipStat.Tiny("AttackTurnDistance");
            newNPC.AttackMaxDistance = _shipStat.Tiny("AttackMaxDistance");
            newNPC.AttackMinDistance = _shipStat.Tiny("AttackMinDistance");

            newNPC.AvoidanceDistance = _shipStat.Tiny("AvoidanceDistance");
            newNPC.AvoidanceSpeed = _shipStat.Tiny("AvoidanceSpeed");
            newNPC.AvoidanceTurnSpeedFactor = _shipStat.Tiny("AvoidanceTurnSpeedFactor");

            newNPC.MaxWeaponDamage = _shipStat.Tiny("MaxWeaponDamage");
            newNPC.MinWeaponDamage = _shipStat.Tiny("MinWeaponDamage");
            newNPC.WeaponCoolDown = _shipStat.Tiny("WeaponCoolDown");

            newNPC.MaxShipVolume = _shipStat.Tiny("MaxShipVolume");

        }

        public void SmallShip()
        {
            newNPC.ShipHull = (int)_shipStat.Small("Hull");

            newNPC.FindPlayerMaxDistance = _shipStat.Small("FindPlayerMaxDistance");

            newNPC.WanderSpeed = _shipStat.Small("WanderSpeed");
            newNPC.WanderSpeedTurnSpeedFactor = _shipStat.Small("WanderSpeedTurnSpeedFactor");

            newNPC.PatrolSpeed = _shipStat.Small("PatrolSpeed");
            newNPC.PatrolSpeedTurnFactor = _shipStat.Small("PatrolSpeedTurnFactor");

            newNPC.FollowMaxSpeed = _shipStat.Small("FollowMaxSpeed");
            newNPC.FollowTurnSpeedFactor = _shipStat.Small("FollowTurnSpeedFactor");
            newNPC.FollowMaxDistance = _shipStat.Small("FollowMaxDistance");
            newNPC.FollowMinDistance = _shipStat.Small("FollowMinDistance");

            newNPC.AttackSpeed = _shipStat.Small("AttackSpeed");
            newNPC.AttackTurnSpeedFactor = _shipStat.Small("AttackTurnSpeedFactor");
            newNPC.AttackTurnDistance = _shipStat.Small("AttackTurnDistance");
            newNPC.AttackMaxDistance = _shipStat.Small("AttackMaxDistance");
            newNPC.AttackMinDistance = _shipStat.Small("AttackMinDistance");

            newNPC.AvoidanceDistance = _shipStat.Small("AvoidanceDistance");
            newNPC.AvoidanceSpeed = _shipStat.Small("AvoidanceSpeed");
            newNPC.AvoidanceTurnSpeedFactor = _shipStat.Small("AvoidanceTurnSpeedFactor");

            newNPC.MaxWeaponDamage = _shipStat.Small("MaxWeaponDamage");
            newNPC.MinWeaponDamage = _shipStat.Small("MinWeaponDamage");
            newNPC.WeaponCoolDown = _shipStat.Small("WeaponCoolDown");

            newNPC.MaxShipVolume = _shipStat.Small("MaxShipVolume");

        }

        public void IncreaseAttributes()
        {
            //This increaes is based on the NPC Level
            //NPC Gets 10 attribute points per Level

            int numPointsAllocatePerAttribute = ((newNPC.NpcLevel - 1) * attributePointsPerLevel)/10;

            newNPC.Strength = _npcAttribute.AttributeIncrease(_humanRace.RaceStrength, newNPC.Strength, numPointsAllocatePerAttribute);
            newNPC.Intelligence = _npcAttribute.AttributeIncrease(_humanRace.RaceIntelligence, newNPC.Intelligence, numPointsAllocatePerAttribute);
            newNPC.Dexterity = _npcAttribute.AttributeIncrease(_humanRace.RaceDexterity, newNPC.Dexterity, numPointsAllocatePerAttribute);
            newNPC.Wisdom = _npcAttribute.AttributeIncrease(_humanRace.RaceWisdom, newNPC.Wisdom, numPointsAllocatePerAttribute);
            newNPC.Health = _npcAttribute.AttributeIncrease(_humanRace.RaceHealth, newNPC.Health, numPointsAllocatePerAttribute);
            newNPC.EagleEyes = _npcAttribute.AttributeIncrease(_humanRace.RaceEagleEyes, newNPC.EagleEyes, numPointsAllocatePerAttribute);
            newNPC.Speed = _npcAttribute.AttributeIncrease(_humanRace.RaceSpeed, newNPC.Speed, numPointsAllocatePerAttribute);
            newNPC.Endurance = _npcAttribute.AttributeIncrease(_humanRace.RaceEndurance, newNPC.Endurance, numPointsAllocatePerAttribute);
            newNPC.NervesOfSteel = _npcAttribute.AttributeIncrease(_humanRace.RaceNervesOfSteel, newNPC.NervesOfSteel, numPointsAllocatePerAttribute);
            newNPC.Charisma = _npcAttribute.AttributeIncrease(_humanRace.RaceCharisma, newNPC.Charisma, numPointsAllocatePerAttribute);

        }

        public int SetType()
        {
            int npcType = randNum.RandomNumberInt(1, 20);
            if(npcType == 5)
            {
                SetType();
            }
            return npcType;             
        }
        */
    }
}

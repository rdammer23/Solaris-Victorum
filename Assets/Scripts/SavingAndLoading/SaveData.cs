using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Security.Cryptography;

namespace Assets.Scripts.SavingAndLoading
{
    class SaveData:MonoBehaviour
    {
        public string addNewAccount = "http://solarisvictorum.space/solarisvictorum/php/AddNewAccount.php?"; //be sure to add a ? to your url

        public void SaveNewAccount(string password)
        {
            GetSaveNewAccount(password);
        }

        public WWW GetSaveNewAccount(string password)
        {
            string post_url = addNewAccount + "name=" + WWW.EscapeURL(GameData.PlayerName) + "&password=" + (password) + "&race=" + (GameData.RaceID);
            WWW addAccount = new WWW(post_url);

            StartCoroutine(WaitForRequest(addAccount));
            return (addAccount);
        }

        private IEnumerator WaitForRequest(WWW addAccount)
        {
            yield return addAccount;

            // check for errors
            if (addAccount.error == null)
            {
                Debug.Log("Save Successful");
            }
            else
            {
                Debug.Log(addAccount.error);
            }
        }


        //TODO Everything Below this can be removed once updated to write to DB
        /*
        public static void SaveAll()
        {
            if(GameData.PlayerName != null)
            {
                PPSerialization.Save("PLAYERNAME", GameData.PlayerName);
            }
            else
            {
                Debug.Log("name is null");
            }
            PPSerialization.Save("PLAYERLEVEL", GameData.PlayerLevel);
            PPSerialization.Save("CURRENTLEVELXP", GameData.CurrentLevelXP);
            PPSerialization.Save("PLAYERSHIPID", GameData.ShipID);
            PPSerialization.Save("PLAYERMAXHEALTH", GameData.MaxHealth);
            PPSerialization.Save("PLAYERCURRENTHEALTH", GameData.CurrentHealth);
            PPSerialization.Save("UNUSEDATTRIBUTEPOINTS", GameData.UnUsedAttributePoints);

            if (GameData.PlayerRace != null)
            {
                PPSerialization.Save("PLAYERRACE", GameData.PlayerRace);
            }
            else
            {
                Debug.Log("Race is Null");
            }

            PPSerialization.Save("PLAYERSTRENGTH", GameData.Strength);
            PPSerialization.Save("PLAYERINTELLIGENCE", GameData.Intelligence);
            PPSerialization.Save("PLAYERDEXTERITY", GameData.Dexterity);
            PPSerialization.Save("PLAYERWISDOM", GameData.Wisdom);
            PPSerialization.Save("PLAYERHEALTH", GameData.Health);
            PPSerialization.Save("PLAYEREAGLEEYES", GameData.EagleEyes);
            PPSerialization.Save("PLAYERSPEED", GameData.Speed);
            PPSerialization.Save("PLAYERENDURANCE", GameData.Endurance);
            PPSerialization.Save("PLAYERNERVESOFSTEEL", GameData.NervesOfSteel);
            PPSerialization.Save("PLAYERCHARISMA", GameData.Charisma);

            PPSerialization.Save("PLAYERALIGNMENTHUMAN", GameData.AlignmentHuman);
            PPSerialization.Save("PLAYERALIGNMENTFELINE", GameData.AlignmentFeline);
            PPSerialization.Save("PLAYERALIGNMENTBIRD", GameData.AlignmentBird);
            PPSerialization.Save("PLAYERALIGNMENTMYSTIC", GameData.AlignmentMystic);
            PPSerialization.Save("PLAYERALIGNMENTCYBORG", GameData.AlignmentCyborgs);
            PPSerialization.Save("PLAYERALIGNMENTINSECT", GameData.AlignmentInsect);
            PPSerialization.Save("PLAYERALIGNMENTBRAINS", GameData.AlignmentBrains);
            PPSerialization.Save("PLAYERALIGNMENTMETAL", GameData.AlignmentMetal);
            PPSerialization.Save("PLAYERALIGNMENTLIZARD", GameData.AlignmentLizard);
            PPSerialization.Save("PLAYERALIGNMENTTREE", GameData.AlignmentTree);
            PPSerialization.Save("PLAYERALIGNMENTGAS", GameData.AlignmentGas);

            if (GameData.EquipmentOne != null)
            {
                PPSerialization.Save("EQUIPMENTITEM1", GameData.EquipmentOne);
            }
            
        }
        
        public static void SaveXP()
        {
            //PPSerialization.Save("CURRENTLEVELXP", GameData.CurrentLevelXP);
        }

        public static void SaveLevel()
        {
            //PPSerialization.Save("PLAYERLEVEL", GameData.PlayerLevel);
        }

        public static void SaveUnUsedAttributePoints()
        {
            //PPSerialization.Save("UNUSEDATTRIBUTEPOINTS", GameData.UnUsedAttributePoints);
        }
        */

        /*
        public static void SaveStar()
        {
            if(GameData.StarName == null)
            {
                GameData.StarName = GameData.StarColor + " Temp Name";
            }
            PPSerialization.Save("STARNAME", GameData.StarName);
            PPSerialization.Save("STARCOLOR", GameData.StarColor);
            PPSerialization.Save("STARCOLORID", GameData.StarColorID);
            PPSerialization.Save("STARHRADJGAS", GameData.HarvestRateStarGas);
            PPSerialization.Save("STARHRADJCARBON", GameData.HarvestRateStarCarbon);
            PPSerialization.Save("STARHRADJWATER", GameData.HarvestRateStarWater);
            PPSerialization.Save("STARHRADJORGANIC", GameData.HarvestRateStarOrganic);
            PPSerialization.Save("STARHRADJROCK", GameData.HarvestRateStarRock);
            PPSerialization.Save("STARHRADJWOOD", GameData.HarvestRateStarWood);
            PPSerialization.Save("STARHRADJIRON", GameData.HarvestRateStarIron);
            PPSerialization.Save("STARHRADJSILVER", GameData.HarvestRateStarSilver);
            PPSerialization.Save("STARHRADJGOLD", GameData.HarvestRateStarGold);
            PPSerialization.Save("STARHRADJRUBY", GameData.HarvestRateStarRuby);
            PPSerialization.Save("STARHRADJEMERALD", GameData.HarvestRateStarEmerald);
            PPSerialization.Save("STARHRADJTITANIUM", GameData.HarvestRateStarTitanium);
            PPSerialization.Save("STARHRADJMITHRIL", GameData.HarvestRateStarMithril);
            PPSerialization.Save("STARHRADJLIQUIDHYDROGEN", GameData.HarvestRateStarLiquidHydrogen);
            PPSerialization.Save("STARHRADJLIQUIDOXYGEN", GameData.HarvestRateStarLiquidOxygen);
            PPSerialization.Save("STARHRADJLIQUIDNITROGEN", GameData.HarvestRateStarLiquidNitrogen);
            PPSerialization.Save("STARHRADJPLATINUM", GameData.HarvestRateStarPlatinum);
            PPSerialization.Save("STARHRADJDIAMOND", GameData.HarvestRateStarDiamond);
            PPSerialization.Save("STARHRADJRADIOACTIVE", GameData.HarvestRateStarRadioactive);
            PPSerialization.Save("STARHRADJBLACKMATTER", GameData.HarvestRateStarBlackMatter);
            PPSerialization.Save("STARHRADJREDMATTER", GameData.HarvestRateStarRedMatter);
            PPSerialization.Save("STARHRADJGREYMATTER", GameData.HarvestRateStarGreyMatter);
            PPSerialization.Save("STARHRADJWHITEMATTER", GameData.HarvestRateStarWhiteMatter);
            PPSerialization.Save("STARHRADJMANA", GameData.HarvestRateStarMana);
        }

        public static void SavePlanet1()
        {
            // if (GameData.StarName == null)
            // {
            //     GameData.StarName = GameData.StarColor + " Temp Name";
            // }
            PPSerialization.Save("PLANET1PLANETLEVEL", GameData.Planet1PlanetLevel);
            PPSerialization.Save("PLANET1PLANETCURRENTTFVALUE", GameData.Planet1PlanetCurrentTFValue);
            PPSerialization.Save("PLANET1PLANETTFVALUENEEDED", GameData.Planet1PlanetTFValueNeeded);
            PPSerialization.Save("PLANET1PLANETPLAYEROWNED", GameData.Planet1PlanetPlayerOwned);
            PPSerialization.Save("PLANET1PLANETPOPULATION", GameData.Planet1PlanetPopulation);
            PPSerialization.Save("PLANET1POPULATIONINCREASERATE", GameData.Planet1PopulationIncreaseRate);
            PPSerialization.Save("PLANET1PLANETID", GameData.Planet1PlanetID);
            PPSerialization.Save("PLANET1PLANETSIZE", GameData.Planet1PlanetSize);
            PPSerialization.Save("PLANET1MAXPOPULATION", GameData.Planet1MaxPopulation);
            PPSerialization.Save("PLANET1PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet1PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET1PLANETDENSITY", GameData.Planet1PlanetDensity);
            PPSerialization.Save("PLANET1PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet1PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET1PLANETSTARTLOCATIONX", GameData.Planet1PlanetStartLocationX);
            PPSerialization.Save("PLANET1PLANETSTARTLOCATIONY", GameData.Planet1PlanetStartLocationY);
            PPSerialization.Save("PLANET1PLANETSTARTLOCATIONZ", GameData.Planet1PlanetStartLocationZ);
            PPSerialization.Save("PLANET1PLANETORIGINALOWNERRACE", GameData.Planet1PlanetOriginalOwnerRace);
        }

        public static void SavePlanet2()
        {
            // if (GameData.StarName == null)
            // {
            //     GameData.StarName = GameData.StarColor + " Temp Name";
            // }
            PPSerialization.Save("PLANET2PLANETLEVEL", GameData.Planet2PlanetLevel);
            PPSerialization.Save("PLANET2PLANETCURRENTTFVALUE", GameData.Planet2PlanetCurrentTFValue);
            PPSerialization.Save("PLANET2PLANETTFVALUENEEDED", GameData.Planet2PlanetTFValueNeeded);
            PPSerialization.Save("PLANET2PLANETPLAYEROWNED", GameData.Planet2PlanetPlayerOwned);
            PPSerialization.Save("PLANET2PLANETPOPULATION", GameData.Planet2PlanetPopulation);
            PPSerialization.Save("PLANET2POPULATIONINCREASERATE", GameData.Planet2PopulationIncreaseRate);
            PPSerialization.Save("PLANET2PLANETID", GameData.Planet2PlanetID);
            PPSerialization.Save("PLANET2PLANETSIZE", GameData.Planet2PlanetSize);
            PPSerialization.Save("PLANET2MAXPOPULATION", GameData.Planet2MaxPopulation);
            PPSerialization.Save("PLANET2PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet2PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET2PLANETDENSITY", GameData.Planet2PlanetDensity);
            PPSerialization.Save("PLANET2PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet2PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET2PLANETSTARTLOCATIONX", GameData.Planet2PlanetStartLocationX);
            PPSerialization.Save("PLANET2PLANETSTARTLOCATIONY", GameData.Planet2PlanetStartLocationY);
            PPSerialization.Save("PLANET2PLANETSTARTLOCATIONZ", GameData.Planet2PlanetStartLocationZ);
            PPSerialization.Save("PLANET2PLANETORIGINALOWNERRACE", GameData.Planet2PlanetOriginalOwnerRace);

        }

        public static void SavePlanet3()
        {
            PPSerialization.Save("PLANET3PLANETLEVEL", GameData.Planet3PlanetLevel);
            PPSerialization.Save("PLANET3PLANETCURRENTTFVALUE", GameData.Planet3PlanetCurrentTFValue);
            PPSerialization.Save("PLANET3PLANETTFVALUENEEDED", GameData.Planet3PlanetTFValueNeeded);
            PPSerialization.Save("PLANET3PLANETPLAYEROWNED", GameData.Planet3PlanetPlayerOwned);
            PPSerialization.Save("PLANET3PLANETPOPULATION", GameData.Planet3PlanetPopulation);
            PPSerialization.Save("PLANET3POPULATIONINCREASERATE", GameData.Planet3PopulationIncreaseRate);
            PPSerialization.Save("PLANET3PLANETID", GameData.Planet3PlanetID);
            PPSerialization.Save("PLANET3PLANETSIZE", GameData.Planet3PlanetSize);
            PPSerialization.Save("PLANET3MAXPOPULATION", GameData.Planet3MaxPopulation);
            PPSerialization.Save("PLANET3PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet3PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET3PLANETDENSITY", GameData.Planet3PlanetDensity);
            PPSerialization.Save("PLANET3PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet3PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET3PLANETSTARTLOCATIONX", GameData.Planet3PlanetStartLocationX);
            PPSerialization.Save("PLANET3PLANETSTARTLOCATIONY", GameData.Planet3PlanetStartLocationY);
            PPSerialization.Save("PLANET3PLANETSTARTLOCATIONZ", GameData.Planet3PlanetStartLocationZ);
            PPSerialization.Save("PLANET3PLANETORIGINALOWNERRACE", GameData.Planet3PlanetOriginalOwnerRace);

        }

        public static void SavePlanet4()
        {
            PPSerialization.Save("PLANET4PLANETLEVEL", GameData.Planet4PlanetLevel);
            PPSerialization.Save("PLANET4PLANETCURRENTTFVALUE", GameData.Planet4PlanetCurrentTFValue);
            PPSerialization.Save("PLANET4PLANETTFVALUENEEDED", GameData.Planet4PlanetTFValueNeeded);
            PPSerialization.Save("PLANET4PLANETPLAYEROWNED", GameData.Planet4PlanetPlayerOwned);
            PPSerialization.Save("PLANET4PLANETPOPULATION", GameData.Planet4PlanetPopulation);
            PPSerialization.Save("PLANET4POPULATIONINCREASERATE", GameData.Planet4PopulationIncreaseRate);
            PPSerialization.Save("PLANET4PLANETID", GameData.Planet4PlanetID);
            PPSerialization.Save("PLANET4PLANETSIZE", GameData.Planet4PlanetSize);
            PPSerialization.Save("PLANET4MAXPOPULATION", GameData.Planet4MaxPopulation);
            PPSerialization.Save("PLANET4PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet4PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET4PLANETDENSITY", GameData.Planet4PlanetDensity);
            PPSerialization.Save("PLANET4PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet4PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET4PLANETSTARTLOCATIONX", GameData.Planet4PlanetStartLocationX);
            PPSerialization.Save("PLANET4PLANETSTARTLOCATIONY", GameData.Planet4PlanetStartLocationY);
            PPSerialization.Save("PLANET4PLANETSTARTLOCATIONZ", GameData.Planet4PlanetStartLocationZ);
            PPSerialization.Save("PLANET4PLANETORIGINALOWNERRACE", GameData.Planet4PlanetOriginalOwnerRace);

        }

        public static void SavePlanet5()
        {
            PPSerialization.Save("PLANET5PLANETLEVEL", GameData.Planet5PlanetLevel);
            PPSerialization.Save("PLANET5PLANETCURRENTTFVALUE", GameData.Planet5PlanetCurrentTFValue);
            PPSerialization.Save("PLANET5PLANETTFVALUENEEDED", GameData.Planet5PlanetTFValueNeeded);
            PPSerialization.Save("PLANET5PLANETPLAYEROWNED", GameData.Planet5PlanetPlayerOwned);
            PPSerialization.Save("PLANET5PLANETPOPULATION", GameData.Planet5PlanetPopulation);
            PPSerialization.Save("PLANET5POPULATIONINCREASERATE", GameData.Planet5PopulationIncreaseRate);
            PPSerialization.Save("PLANET5PLANETID", GameData.Planet5PlanetID);
            PPSerialization.Save("PLANET5PLANETSIZE", GameData.Planet5PlanetSize);
            PPSerialization.Save("PLANET5MAXPOPULATION", GameData.Planet5MaxPopulation);
            PPSerialization.Save("PLANET5PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet5PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET5PLANETDENSITY", GameData.Planet5PlanetDensity);
            PPSerialization.Save("PLANET5PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet5PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET5PLANETSTARTLOCATIONX", GameData.Planet5PlanetStartLocationX);
            PPSerialization.Save("PLANET5PLANETSTARTLOCATIONY", GameData.Planet5PlanetStartLocationY);
            PPSerialization.Save("PLANET5PLANETSTARTLOCATIONZ", GameData.Planet5PlanetStartLocationZ);
            PPSerialization.Save("PLANET5PLANETORIGINALOWNERRACE", GameData.Planet5PlanetOriginalOwnerRace);

        }

        public static void SavePlanet6()
        {
            PPSerialization.Save("PLANET6PLANETLEVEL", GameData.Planet6PlanetLevel);
            PPSerialization.Save("PLANET6PLANETCURRENTTFVALUE", GameData.Planet6PlanetCurrentTFValue);
            PPSerialization.Save("PLANET6PLANETTFVALUENEEDED", GameData.Planet6PlanetTFValueNeeded);
            PPSerialization.Save("PLANET6PLANETPLAYEROWNED", GameData.Planet6PlanetPlayerOwned);
            PPSerialization.Save("PLANET6PLANETPOPULATION", GameData.Planet6PlanetPopulation);
            PPSerialization.Save("PLANET6POPULATIONINCREASERATE", GameData.Planet6PopulationIncreaseRate);
            PPSerialization.Save("PLANET6PLANETID", GameData.Planet6PlanetID);
            PPSerialization.Save("PLANET6PLANETSIZE", GameData.Planet6PlanetSize);
            PPSerialization.Save("PLANET6MAXPOPULATION", GameData.Planet6MaxPopulation);
            PPSerialization.Save("PLANET6PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet6PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET6PLANETDENSITY", GameData.Planet6PlanetDensity);
            PPSerialization.Save("PLANET6PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet6PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET6PLANETSTARTLOCATIONX", GameData.Planet6PlanetStartLocationX);
            PPSerialization.Save("PLANET6PLANETSTARTLOCATIONY", GameData.Planet6PlanetStartLocationY);
            PPSerialization.Save("PLANET6PLANETSTARTLOCATIONZ", GameData.Planet6PlanetStartLocationZ);
            PPSerialization.Save("PLANET6PLANETORIGINALOWNERRACE", GameData.Planet6PlanetOriginalOwnerRace);

        }

        public static void SavePlanet7()
        {
            PPSerialization.Save("PLANET7PLANETLEVEL", GameData.Planet7PlanetLevel);
            PPSerialization.Save("PLANET7PLANETCURRENTTFVALUE", GameData.Planet7PlanetCurrentTFValue);
            PPSerialization.Save("PLANET7PLANETTFVALUENEEDED", GameData.Planet7PlanetTFValueNeeded);
            PPSerialization.Save("PLANET7PLANETPLAYEROWNED", GameData.Planet7PlanetPlayerOwned);
            PPSerialization.Save("PLANET7PLANETPOPULATION", GameData.Planet7PlanetPopulation);
            PPSerialization.Save("PLANET7POPULATIONINCREASERATE", GameData.Planet7PopulationIncreaseRate);
            PPSerialization.Save("PLANET7PLANETID", GameData.Planet7PlanetID);
            PPSerialization.Save("PLANET7PLANETSIZE", GameData.Planet7PlanetSize);
            PPSerialization.Save("PLANET7MAXPOPULATION", GameData.Planet7MaxPopulation);
            PPSerialization.Save("PLANET7PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet7PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET7PLANETDENSITY", GameData.Planet7PlanetDensity);
            PPSerialization.Save("PLANET7PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet7PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET7PLANETSTARTLOCATIONX", GameData.Planet7PlanetStartLocationX);
            PPSerialization.Save("PLANET7PLANETSTARTLOCATIONY", GameData.Planet7PlanetStartLocationY);
            PPSerialization.Save("PLANET7PLANETSTARTLOCATIONZ", GameData.Planet7PlanetStartLocationZ);
            PPSerialization.Save("PLANET7PLANETORIGINALOWNERRACE", GameData.Planet7PlanetOriginalOwnerRace);
        }

        public static void SavePlanet8()
        {
            PPSerialization.Save("PLANET8PLANETLEVEL", GameData.Planet8PlanetLevel);
            PPSerialization.Save("PLANET8PLANETCURRENTTFVALUE", GameData.Planet8PlanetCurrentTFValue);
            PPSerialization.Save("PLANET8PLANETTFVALUENEEDED", GameData.Planet8PlanetTFValueNeeded);
            PPSerialization.Save("PLANET8PLANETPLAYEROWNED", GameData.Planet8PlanetPlayerOwned);
            PPSerialization.Save("PLANET8PLANETPOPULATION", GameData.Planet8PlanetPopulation);
            PPSerialization.Save("PLANET8POPULATIONINCREASERATE", GameData.Planet8PopulationIncreaseRate);
            PPSerialization.Save("PLANET8PLANETID", GameData.Planet8PlanetID);
            PPSerialization.Save("PLANET8PLANETSIZE", GameData.Planet8PlanetSize);
            PPSerialization.Save("PLANET8MAXPOPULATION", GameData.Planet8MaxPopulation);
            PPSerialization.Save("PLANET8PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet8PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET8PLANETDENSITY", GameData.Planet8PlanetDensity);
            PPSerialization.Save("PLANET8PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet8PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET8PLANETSTARTLOCATIONX", GameData.Planet8PlanetStartLocationX);
            PPSerialization.Save("PLANET8PLANETSTARTLOCATIONY", GameData.Planet8PlanetStartLocationY);
            PPSerialization.Save("PLANET8PLANETSTARTLOCATIONZ", GameData.Planet8PlanetStartLocationZ);
            PPSerialization.Save("PLANET8PLANETORIGINALOWNERRACE", GameData.Planet8PlanetOriginalOwnerRace);

        }

        public static void SavePlanet9()
        {
            PPSerialization.Save("PLANET9PLANETLEVEL", GameData.Planet9PlanetLevel);
            PPSerialization.Save("PLANET9PLANETCURRENTTFVALUE", GameData.Planet9PlanetCurrentTFValue);
            PPSerialization.Save("PLANET9PLANETTFVALUENEEDED", GameData.Planet9PlanetTFValueNeeded);
            PPSerialization.Save("PLANET9PLANETPLAYEROWNED", GameData.Planet9PlanetPlayerOwned);
            PPSerialization.Save("PLANET9PLANETPOPULATION", GameData.Planet9PlanetPopulation);
            PPSerialization.Save("PLANET9POPULATIONINCREASERATE", GameData.Planet9PopulationIncreaseRate);
            PPSerialization.Save("PLANET9PLANETID", GameData.Planet9PlanetID);
            PPSerialization.Save("PLANET9PLANETSIZE", GameData.Planet9PlanetSize);
            PPSerialization.Save("PLANET9MAXPOPULATION", GameData.Planet9MaxPopulation);
            PPSerialization.Save("PLANET9PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet9PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET9PLANETDENSITY", GameData.Planet9PlanetDensity);
            PPSerialization.Save("PLANET9PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet9PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET9PLANETSTARTLOCATIONX", GameData.Planet9PlanetStartLocationX);
            PPSerialization.Save("PLANET9PLANETSTARTLOCATIONY", GameData.Planet9PlanetStartLocationY);
            PPSerialization.Save("PLANET9PLANETSTARTLOCATIONZ", GameData.Planet9PlanetStartLocationZ);
            PPSerialization.Save("PLANET9PLANETORIGINALOWNERRACE", GameData.Planet9PlanetOriginalOwnerRace);
        }

        public static void SavePlanet10()
        {
            PPSerialization.Save("PLANET10PLANETLEVEL", GameData.Planet10PlanetLevel);
            PPSerialization.Save("PLANET10PLANETCURRENTTFVALUE", GameData.Planet10PlanetCurrentTFValue);
            PPSerialization.Save("PLANET10PLANETTFVALUENEEDED", GameData.Planet10PlanetTFValueNeeded);
            PPSerialization.Save("PLANET10PLANETPLAYEROWNED", GameData.Planet10PlanetPlayerOwned);
            PPSerialization.Save("PLANET10PLANETPOPULATION", GameData.Planet10PlanetPopulation);
            PPSerialization.Save("PLANET10POPULATIONINCREASERATE", GameData.Planet10PopulationIncreaseRate);
            PPSerialization.Save("PLANET10PLANETID", GameData.Planet10PlanetID);
            PPSerialization.Save("PLANET10PLANETSIZE", GameData.Planet10PlanetSize);
            PPSerialization.Save("PLANET10MAXPOPULATION", GameData.Planet10MaxPopulation);
            PPSerialization.Save("PLANET10PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet10PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET10PLANETDENSITY", GameData.Planet10PlanetDensity);
            PPSerialization.Save("PLANET10PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet10PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET10PLANETSTARTLOCATIONX", GameData.Planet10PlanetStartLocationX);
            PPSerialization.Save("PLANET10PLANETSTARTLOCATIONY", GameData.Planet10PlanetStartLocationY);
            PPSerialization.Save("PLANET10PLANETSTARTLOCATIONZ", GameData.Planet10PlanetStartLocationZ);
            PPSerialization.Save("PLANET10PLANETORIGINALOWNERRACE", GameData.Planet10PlanetOriginalOwnerRace);

        }

        public static void SavePlanet11()
        {
            PPSerialization.Save("PLANET11PLANETLEVEL", GameData.Planet11PlanetLevel);
            PPSerialization.Save("PLANET11PLANETCURRENTTFVALUE", GameData.Planet11PlanetCurrentTFValue);
            PPSerialization.Save("PLANET11PLANETTFVALUENEEDED", GameData.Planet11PlanetTFValueNeeded);
            PPSerialization.Save("PLANET11PLANETPLAYEROWNED", GameData.Planet11PlanetPlayerOwned);
            PPSerialization.Save("PLANET11PLANETPOPULATION", GameData.Planet11PlanetPopulation);
            PPSerialization.Save("PLANET11POPULATIONINCREASERATE", GameData.Planet11PopulationIncreaseRate);
            PPSerialization.Save("PLANET11PLANETID", GameData.Planet11PlanetID);
            PPSerialization.Save("PLANET11PLANETSIZE", GameData.Planet11PlanetSize);
            PPSerialization.Save("PLANET11MAXPOPULATION", GameData.Planet11MaxPopulation);
            PPSerialization.Save("PLANET11PLANETSIZEHARVESTRATEADJUSTMENT", GameData.Planet11PlanetSizeHarvestRateAdjustment);
            PPSerialization.Save("PLANET11PLANETDENSITY", GameData.Planet11PlanetDensity);
            PPSerialization.Save("PLANET11PLANETDENSITYHARVESTRATEADJUSTMENT", GameData.Planet11PlanetDensityHarvestRateAdjustment);
            PPSerialization.Save("PLANET11PLANETSTARTLOCATIONX", GameData.Planet11PlanetStartLocationX);
            PPSerialization.Save("PLANET11PLANETSTARTLOCATIONY", GameData.Planet11PlanetStartLocationY);
            PPSerialization.Save("PLANET11PLANETSTARTLOCATIONZ", GameData.Planet11PlanetStartLocationZ);
            PPSerialization.Save("PLANET11PLANETORIGINALOWNERRACE", GameData.Planet11PlanetOriginalOwnerRace);
        }
        public static void SaveMoon1()
        {
            PPSerialization.Save("MOON1MOONID", GameData.Moon1MoonID);
            PPSerialization.Save("MOON1MOONPLANETID", GameData.Moon1MoonPlanetID);
            PPSerialization.Save("MOON1MOONSIZE", GameData.Moon1MoonSize);
            PPSerialization.Save("MOON1MOONSTARTLOCATIONX", GameData.Moon1MoonStartLocationX);
            PPSerialization.Save("MOON1MOONSTARTLOCATIONY", GameData.Moon1MoonStartLocationY);
            PPSerialization.Save("MOON1MOONSTARTLOCATIONZ", GameData.Moon1MoonStartLocationZ);
        }

        public static void SaveMoon2()
        {
            PPSerialization.Save("MOON2MOONID", GameData.Moon2MoonID);
            PPSerialization.Save("MOON2MOONPLANETID", GameData.Moon2MoonPlanetID);
            PPSerialization.Save("MOON2MOONSIZE", GameData.Moon2MoonSize);
            PPSerialization.Save("MOON2MOONSTARTLOCATIONX", GameData.Moon2MoonStartLocationX);
            PPSerialization.Save("MOON2MOONSTARTLOCATIONY", GameData.Moon2MoonStartLocationY);
            PPSerialization.Save("MOON2MOONSTARTLOCATIONZ", GameData.Moon2MoonStartLocationZ);
        }

        public static void SaveMoon3()
        {
            PPSerialization.Save("MOON3MOONID", GameData.Moon3MoonID);
            PPSerialization.Save("MOON3MOONPLANETID", GameData.Moon3MoonPlanetID);
            PPSerialization.Save("MOON3MOONSIZE", GameData.Moon3MoonSize);
            PPSerialization.Save("MOON3MOONSTARTLOCATIONX", GameData.Moon3MoonStartLocationX);
            PPSerialization.Save("MOON3MOONSTARTLOCATIONY", GameData.Moon3MoonStartLocationY);
            PPSerialization.Save("MOON3MOONSTARTLOCATIONZ", GameData.Moon3MoonStartLocationZ);
        }

        public static void SaveMoon4()
        {
            PPSerialization.Save("MOON4MOONID", GameData.Moon4MoonID);
            PPSerialization.Save("MOON4MOONPLANETID", GameData.Moon4MoonPlanetID);
            PPSerialization.Save("MOON4MOONSIZE", GameData.Moon4MoonSize);
            PPSerialization.Save("MOON4MOONSTARTLOCATIONX", GameData.Moon4MoonStartLocationX);
            PPSerialization.Save("MOON4MOONSTARTLOCATIONY", GameData.Moon4MoonStartLocationY);
            PPSerialization.Save("MOON4MOONSTARTLOCATIONZ", GameData.Moon4MoonStartLocationZ);
        }

        public static void SaveMoon5()
        {
            PPSerialization.Save("MOON5MOONID", GameData.Moon5MoonID);
            PPSerialization.Save("MOON5MOONPLANETID", GameData.Moon5MoonPlanetID);
            PPSerialization.Save("MOON5MOONSIZE", GameData.Moon5MoonSize);
            PPSerialization.Save("MOON5MOONSTARTLOCATIONX", GameData.Moon5MoonStartLocationX);
            PPSerialization.Save("MOON5MOONSTARTLOCATIONY", GameData.Moon5MoonStartLocationY);
            PPSerialization.Save("MOON5MOONSTARTLOCATIONZ", GameData.Moon5MoonStartLocationZ);
        }

        public static void SaveMoon6()
        {
            PPSerialization.Save("MOON6MOONID", GameData.Moon6MoonID);
            PPSerialization.Save("MOON6MOONPLANETID", GameData.Moon6MoonPlanetID);
            PPSerialization.Save("MOON6MOONSIZE", GameData.Moon6MoonSize);
            PPSerialization.Save("MOON6MOONSTARTLOCATIONX", GameData.Moon6MoonStartLocationX);
            PPSerialization.Save("MOON6MOONSTARTLOCATIONY", GameData.Moon6MoonStartLocationY);
            PPSerialization.Save("MOON6MOONSTARTLOCATIONZ", GameData.Moon6MoonStartLocationZ);
        }

        public static void SaveMoon7()
        {
            PPSerialization.Save("MOON7MOONID", GameData.Moon7MoonID);
            PPSerialization.Save("MOON7MOONPLANETID", GameData.Moon7MoonPlanetID);
            PPSerialization.Save("MOON7MOONSIZE", GameData.Moon7MoonSize);
            PPSerialization.Save("MOON7MOONSTARTLOCATIONX", GameData.Moon7MoonStartLocationX);
            PPSerialization.Save("MOON7MOONSTARTLOCATIONY", GameData.Moon7MoonStartLocationY);
            PPSerialization.Save("MOON7MOONSTARTLOCATIONZ", GameData.Moon7MoonStartLocationZ);
        }

        public static void SaveMoon8()
        {
            PPSerialization.Save("MOON8MOONID", GameData.Moon8MoonID);
            PPSerialization.Save("MOON8MOONPLANETID", GameData.Moon8MoonPlanetID);
            PPSerialization.Save("MOON8MOONSIZE", GameData.Moon8MoonSize);
            PPSerialization.Save("MOON8MOONSTARTLOCATIONX", GameData.Moon8MoonStartLocationX);
            PPSerialization.Save("MOON8MOONSTARTLOCATIONY", GameData.Moon8MoonStartLocationY);
            PPSerialization.Save("MOON8MOONSTARTLOCATIONZ", GameData.Moon8MoonStartLocationZ);
        }

        public static void SaveMoon9()
        {
            PPSerialization.Save("MOON9MOONID", GameData.Moon9MoonID);
            PPSerialization.Save("MOON9MOONPLANETID", GameData.Moon9MoonPlanetID);
            PPSerialization.Save("MOON9MOONSIZE", GameData.Moon9MoonSize);
            PPSerialization.Save("MOON9MOONSTARTLOCATIONX", GameData.Moon9MoonStartLocationX);
            PPSerialization.Save("MOON9MOONSTARTLOCATIONY", GameData.Moon9MoonStartLocationY);
            PPSerialization.Save("MOON9MOONSTARTLOCATIONZ", GameData.Moon9MoonStartLocationZ);
        }

        public static void SaveMoon10()
        {
            PPSerialization.Save("MOON10MOONID", GameData.Moon10MoonID);
            PPSerialization.Save("MOON10MOONPLANETID", GameData.Moon10MoonPlanetID);
            PPSerialization.Save("MOON10MOONSIZE", GameData.Moon10MoonSize);
            PPSerialization.Save("MOON10MOONSTARTLOCATIONX", GameData.Moon10MoonStartLocationX);
            PPSerialization.Save("MOON10MOONSTARTLOCATIONY", GameData.Moon10MoonStartLocationY);
            PPSerialization.Save("MOON10MOONSTARTLOCATIONZ", GameData.Moon10MoonStartLocationZ);
        }

        public static void SaveMoon11()
        {
            PPSerialization.Save("MOON11MOONID", GameData.Moon11MoonID);
            PPSerialization.Save("MOON11MOONPLANETID", GameData.Moon11MoonPlanetID);
            PPSerialization.Save("MOON11MOONSIZE", GameData.Moon11MoonSize);
            PPSerialization.Save("MOON11MOONSTARTLOCATIONX", GameData.Moon11MoonStartLocationX);
            PPSerialization.Save("MOON11MOONSTARTLOCATIONY", GameData.Moon11MoonStartLocationY);
            PPSerialization.Save("MOON11MOONSTARTLOCATIONZ", GameData.Moon11MoonStartLocationZ);
        }

        public static void SaveMoon12()
        {
            PPSerialization.Save("MOON12MOONID", GameData.Moon12MoonID);
            PPSerialization.Save("MOON12MOONPLANETID", GameData.Moon12MoonPlanetID);
            PPSerialization.Save("MOON12MOONSIZE", GameData.Moon12MoonSize);
            PPSerialization.Save("MOON12MOONSTARTLOCATIONX", GameData.Moon12MoonStartLocationX);
            PPSerialization.Save("MOON12MOONSTARTLOCATIONY", GameData.Moon12MoonStartLocationY);
            PPSerialization.Save("MOON12MOONSTARTLOCATIONZ", GameData.Moon12MoonStartLocationZ);
        }

        public static void SaveMoon13()
        {
            PPSerialization.Save("MOON13MOONID", GameData.Moon13MoonID);
            PPSerialization.Save("MOON13MOONPLANETID", GameData.Moon13MoonPlanetID);
            PPSerialization.Save("MOON13MOONSIZE", GameData.Moon13MoonSize);
            PPSerialization.Save("MOON13MOONSTARTLOCATIONX", GameData.Moon13MoonStartLocationX);
            PPSerialization.Save("MOON13MOONSTARTLOCATIONY", GameData.Moon13MoonStartLocationY);
            PPSerialization.Save("MOON13MOONSTARTLOCATIONZ", GameData.Moon13MoonStartLocationZ);
        }

        public static void SaveMoon14()
        {
            PPSerialization.Save("MOON14MOONID", GameData.Moon14MoonID);
            PPSerialization.Save("MOON14MOONPLANETID", GameData.Moon14MoonPlanetID);
            PPSerialization.Save("MOON14MOONSIZE", GameData.Moon14MoonSize);
            PPSerialization.Save("MOON14MOONSTARTLOCATIONX", GameData.Moon14MoonStartLocationX);
            PPSerialization.Save("MOON14MOONSTARTLOCATIONY", GameData.Moon14MoonStartLocationY);
            PPSerialization.Save("MOON14MOONSTARTLOCATIONZ", GameData.Moon14MoonStartLocationZ);
        }

        public static void SaveMoon15()
        {
            PPSerialization.Save("MOON15MOONID", GameData.Moon15MoonID);
            PPSerialization.Save("MOON15MOONPLANETID", GameData.Moon15MoonPlanetID);
            PPSerialization.Save("MOON15MOONSIZE", GameData.Moon15MoonSize);
            PPSerialization.Save("MOON15MOONSTARTLOCATIONX", GameData.Moon15MoonStartLocationX);
            PPSerialization.Save("MOON15MOONSTARTLOCATIONY", GameData.Moon15MoonStartLocationY);
            PPSerialization.Save("MOON15MOONSTARTLOCATIONZ", GameData.Moon15MoonStartLocationZ);
        }

        public static void SaveMoon16()
        {
            PPSerialization.Save("MOON16MOONID", GameData.Moon16MoonID);
            PPSerialization.Save("MOON16MOONPLANETID", GameData.Moon16MoonPlanetID);
            PPSerialization.Save("MOON16MOONSIZE", GameData.Moon16MoonSize);
            PPSerialization.Save("MOON16MOONSTARTLOCATIONX", GameData.Moon16MoonStartLocationX);
            PPSerialization.Save("MOON16MOONSTARTLOCATIONY", GameData.Moon16MoonStartLocationY);
            PPSerialization.Save("MOON16MOONSTARTLOCATIONZ", GameData.Moon16MoonStartLocationZ);
        }

        public static void SaveMoon17()
        {
            PPSerialization.Save("MOON17MOONID", GameData.Moon17MoonID);
            PPSerialization.Save("MOON17MOONPLANETID", GameData.Moon17MoonPlanetID);
            PPSerialization.Save("MOON17MOONSIZE", GameData.Moon17MoonSize);
            PPSerialization.Save("MOON17MOONSTARTLOCATIONX", GameData.Moon17MoonStartLocationX);
            PPSerialization.Save("MOON17MOONSTARTLOCATIONY", GameData.Moon17MoonStartLocationY);
            PPSerialization.Save("MOON17MOONSTARTLOCATIONZ", GameData.Moon17MoonStartLocationZ);
        }

        public static void SaveMoon18()
        {
            PPSerialization.Save("MOON18MOONID", GameData.Moon18MoonID);
            PPSerialization.Save("MOON18MOONPLANETID", GameData.Moon18MoonPlanetID);
            PPSerialization.Save("MOON18MOONSIZE", GameData.Moon18MoonSize);
            PPSerialization.Save("MOON18MOONSTARTLOCATIONX", GameData.Moon18MoonStartLocationX);
            PPSerialization.Save("MOON18MOONSTARTLOCATIONY", GameData.Moon18MoonStartLocationY);
            PPSerialization.Save("MOON18MOONSTARTLOCATIONZ", GameData.Moon18MoonStartLocationZ);
        }

        public static void SaveMoon19()
        {
            PPSerialization.Save("MOON19MOONID", GameData.Moon19MoonID);
            PPSerialization.Save("MOON19MOONPLANETID", GameData.Moon19MoonPlanetID);
            PPSerialization.Save("MOON19MOONSIZE", GameData.Moon19MoonSize);
            PPSerialization.Save("MOON19MOONSTARTLOCATIONX", GameData.Moon19MoonStartLocationX);
            PPSerialization.Save("MOON19MOONSTARTLOCATIONY", GameData.Moon19MoonStartLocationY);
            PPSerialization.Save("MOON19MOONSTARTLOCATIONZ", GameData.Moon19MoonStartLocationZ);
        }

        public static void SaveMoon20()
        {
            PPSerialization.Save("MOON20MOONID", GameData.Moon20MoonID);
            PPSerialization.Save("MOON20MOONPLANETID", GameData.Moon20MoonPlanetID);
            PPSerialization.Save("MOON20MOONSIZE", GameData.Moon20MoonSize);
            PPSerialization.Save("MOON20MOONSTARTLOCATIONX", GameData.Moon20MoonStartLocationX);
            PPSerialization.Save("MOON20MOONSTARTLOCATIONY", GameData.Moon20MoonStartLocationY);
            PPSerialization.Save("MOON20MOONSTARTLOCATIONZ", GameData.Moon20MoonStartLocationZ);
        }

        public static void SaveMoon21()
        {
            PPSerialization.Save("MOON21MOONID", GameData.Moon21MoonID);
            PPSerialization.Save("MOON21MOONPLANETID", GameData.Moon21MoonPlanetID);
            PPSerialization.Save("MOON21MOONSIZE", GameData.Moon21MoonSize);
            PPSerialization.Save("MOON21MOONSTARTLOCATIONX", GameData.Moon21MoonStartLocationX);
            PPSerialization.Save("MOON21MOONSTARTLOCATIONY", GameData.Moon21MoonStartLocationY);
            PPSerialization.Save("MOON21MOONSTARTLOCATIONZ", GameData.Moon21MoonStartLocationZ);
        }

        public static void SaveMoon22()
        { 
            PPSerialization.Save("MOON22MOONID", GameData.Moon22MoonID);
            PPSerialization.Save("MOON22MOONPLANETID", GameData.Moon22MoonPlanetID);
            PPSerialization.Save("MOON22MOONSIZE", GameData.Moon22MoonSize);
            PPSerialization.Save("MOON22MOONSTARTLOCATIONX", GameData.Moon22MoonStartLocationX);
            PPSerialization.Save("MOON22MOONSTARTLOCATIONY", GameData.Moon22MoonStartLocationY);
            PPSerialization.Save("MOON22MOONSTARTLOCATIONZ", GameData.Moon22MoonStartLocationZ);
        }
        */
    }
}

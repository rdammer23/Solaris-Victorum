using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts.Login
{
    class LoginPlayer:MonoBehaviour
    {
        public string svURL = "http://solarisvictorum.space/solarisvictorum/php/SVFunctions.php?whichfunction="; //be sure to add a ? to your url
        private string post_url;

        public WWW AttemptLogin(string playerName, string playerPassword)
        {
            GameData.PlayerName = playerName;
            GameData.PlayerID = 0;
            var loginTextGO = GameObject.FindWithTag("LoginText");
            loginTextGO.GetComponentInChildren<Text>().text = "Logging In";
            post_url = svURL +"PL" + "&name=" + WWW.EscapeURL(playerName) + "&password=" + (playerPassword);
            //Debug.Log(post_url);
            WWW loginInformation = new WWW(post_url);
            StartCoroutine(WaitForRequest(loginInformation));

            //TODO there is a timing issue where i need to login 2 times in order to connect

            /* Need to show on Orbit Screen  ALSO need to calculate a lot of them
            strength;
            intelligence;
            dexterity;
            wisdom;
            health;
            eagleEyes;
            speed;
            endurance;
            nervesOfSteel;
            charisma;
            damage;
            damageReduction;
            resources;
            toHit;
            evasion;
            crititalHitChance;
            criticalDamage;
            criticalHitResistance;
            criticalDamageReduction;
            shipSpeed;
            hull;
            shipVolume;
            weaponCoolDown;
            extraShot;
            stun;
            stunDuration;
            stunResistance;
            tractorBeam;
            tractorBeamResistance;
            majorBreakThrough;
            inventionBonus;
            cloak;
            cloakAll;
            instantKill;
            energyConversion;
            xpBonus;
            buying;
            selling;
            happiness;
            */
            return (loginInformation);
        }

        private IEnumerator WaitForRequest(WWW loginInformation)
        {
            yield return loginInformation;

            // check for errors
            if (loginInformation.error == null)
            {
                if (loginInformation.text != "0")
                {
                    var loginTextGO = GameObject.FindWithTag("LoginText");
                    loginTextGO.GetComponentInChildren<Text>().text = "Login Successful";
                    string returnedString = loginInformation.text;
                    Char delimiter = ';';
                    String[] substrings = returnedString.Split(delimiter);

                    GameData.PlayerID = int.Parse(substrings[0]);
                    GameData.RaceID = int.Parse(substrings[1]);
                    //Debug.Log(GameData.PlayerID);

                    //Getting Real Time Data
                    post_url = svURL + "PD" + "&playerID=" + (GameData.PlayerID);
                    WWW realTimeDataInformation = new WWW(post_url);
                    StartCoroutine(WaitForRealTimeData(realTimeDataInformation));
                }
                else
                {
                    var loginTextGO = GameObject.FindWithTag("LoginText");
                    loginTextGO.GetComponentInChildren<Text>().text = "Invlid Name or Password.";
                }
            }
            else
            {
                var loginTextGO = GameObject.FindWithTag("LoginText");
                loginTextGO.GetComponentInChildren<Text>().text = "System Under Maintenance.  Please Try Later";
            }
        }

        private IEnumerator WaitForRealTimeData(WWW realTimeDataInformation)
        {
            yield return realTimeDataInformation;

            if (realTimeDataInformation.error == null)
            {
                if (realTimeDataInformation.text != "0")
                {
                    string returnedString = realTimeDataInformation.text;
                    Char delimiter = ';';
                    String[] substrings = returnedString.Split(delimiter);

                    GameData.PlayerLevel = int.Parse(substrings[0]);
                    GameData.CurrentHealth = int.Parse(substrings[1]);
                    GameData.CurrentLevelXP = int.Parse(substrings[2]);
                    /*
                    Debug.Log("Player Data");
                    Debug.Log(GameData.PlayerLevel);
                    Debug.Log(GameData.CurrentHealth);
                    Debug.Log(GameData.CurrentLevelXP);
                    */
                    //Getting Attributes

                    post_url = svURL + "Attributes" + "&playerID=" + (GameData.PlayerID);
                    WWW attributeInformation = new WWW(post_url);
                    //Debug.Log(post_url);
                    StartCoroutine(WaitForAttributes(attributeInformation));
                }
                else
                {
                    Debug.Log("Error");
                }
            }

        }

        private IEnumerator WaitForAttributes(WWW attributeInformation)
        {
            yield return attributeInformation;

            if (attributeInformation.error == null)
            {
                if (attributeInformation.text != "0")
                {
                    string returnedString = attributeInformation.text;

                    Char delimiter = ';';
                    String[] substrings = returnedString.Split(delimiter);

                    GameData.Strength = int.Parse(substrings[0]);
                    GameData.Intelligence = int.Parse(substrings[1]);
                    GameData.Dexterity = int.Parse(substrings[2]);
                    GameData.Wisdom = int.Parse(substrings[3]);
                    GameData.Health = int.Parse(substrings[4]);
                    GameData.EagleEyes = int.Parse(substrings[5]);
                    GameData.Speed = int.Parse(substrings[6]);
                    GameData.Endurance = int.Parse(substrings[7]);
                    GameData.NervesOfSteel = int.Parse(substrings[8]);
                    GameData.Charisma = int.Parse(substrings[9]);
                    /*
                    Debug.Log("Player Attributes");
                    Debug.Log(GameData.Strength);
                    Debug.Log(GameData.Intelligence);
                    Debug.Log(GameData.Dexterity);
                    Debug.Log(GameData.Wisdom);
                    Debug.Log(GameData.Health);
                    Debug.Log(GameData.EagleEyes);
                    Debug.Log(GameData.Speed);
                    Debug.Log(GameData.Endurance);
                    Debug.Log(GameData.NervesOfSteel);
                    Debug.Log(GameData.Charisma);
                    */
                    post_url = svURL + "Alignments" + "&playerID=" + (GameData.PlayerID);
                    WWW alignmentInformation = new WWW(post_url);
                    //Debug.Log(post_url);
                    StartCoroutine(WaitForAlignment(alignmentInformation));
                }
                else
                {
                    Debug.Log("Error");
                }
            }
        }

        private IEnumerator WaitForAlignment(WWW alignmentInformation)
        {
            yield return alignmentInformation;

            if (alignmentInformation.error == null)
            {
                if (alignmentInformation.text != "0")
                {
                    string returnedString = alignmentInformation.text;

                    Char delimiter = ';';
                    String[] substrings = returnedString.Split(delimiter);

                    GameData.AlignmentHuman = int.Parse(substrings[0]);
                    GameData.AlignmentFeline = int.Parse(substrings[1]);
                    GameData.AlignmentBird = int.Parse(substrings[2]);
                    GameData.AlignmentMystic = int.Parse(substrings[3]);
                    GameData.AlignmentCyborgs = int.Parse(substrings[4]);
                    GameData.AlignmentInsect = int.Parse(substrings[5]);
                    GameData.AlignmentBrains = int.Parse(substrings[6]);
                    GameData.AlignmentMetal = int.Parse(substrings[7]);
                    GameData.AlignmentLizard = int.Parse(substrings[8]);
                    GameData.AlignmentTree = int.Parse(substrings[9]);
                    GameData.AlignmentGas = int.Parse(substrings[10]);
                    /*
                    Debug.Log("Player Alignment");
                    Debug.Log(GameData.AlignmentHuman);
                    Debug.Log(GameData.AlignmentFeline);
                    Debug.Log(GameData.AlignmentBird);
                    Debug.Log(GameData.AlignmentMystic);
                    Debug.Log(GameData.AlignmentCyborgs);
                    Debug.Log(GameData.AlignmentInsect);
                    Debug.Log(GameData.AlignmentBrains);
                    Debug.Log(GameData.AlignmentMetal);
                    Debug.Log(GameData.AlignmentLizard);
                    Debug.Log(GameData.AlignmentTree);
                    Debug.Log(GameData.AlignmentGas);
                    */
                    post_url = svURL + "GetShip" + "&playerID=" + (GameData.PlayerID);
                    WWW getActiveShipInformation = new WWW(post_url);
                    //Debug.Log(post_url);
                    StartCoroutine(WaitForGetActiveShip(getActiveShipInformation));
                }
                else
                {
                    Debug.Log("Error");
                }
            }
        }

        private IEnumerator WaitForGetActiveShip(WWW getActiveShipInformation)
        {
            yield return getActiveShipInformation;

            if (getActiveShipInformation.error == null)
            {
                if (getActiveShipInformation.text != "0")
                {
                    string returnedString = getActiveShipInformation.text;

                    Char delimiter = ';';
                    String[] substrings = returnedString.Split(delimiter);

                    GameData.ShipRaceID = int.Parse(substrings[0]);
                    GameData.ShipID = int.Parse(substrings[1]);
                    /*
                    Debug.Log("Ship Information");
                    Debug.Log(GameData.ShipRaceID);
                    Debug.Log(GameData.ShipID);
                    */
                    post_url = svURL + "ShipStat" + "&raceID=" + (GameData.ShipRaceID) + "&shipID=" + (GameData.ShipID);
                    WWW getShipStats = new WWW(post_url);
                    //Debug.Log(post_url);
                    StartCoroutine(WaitForGetShipStats(getShipStats));
                }
                else
                {
                    Debug.Log("Error");
                }
            }
        }

        private IEnumerator WaitForGetShipStats(WWW getShipStats)
        {
            yield return getShipStats;

            if (getShipStats.error == null)
            {
                if (getShipStats.text != "0")
                {
                    string returnedString = getShipStats.text;

                    Char delimiter = ';';
                    String[] substrings = returnedString.Split(delimiter);

                    GameData.ShipMoveForce = float.Parse(substrings[0]);
                    GameData.ShipTurnForce = float.Parse(substrings[1]);
                    GameData.ShipTurnRL = float.Parse(substrings[2]);
                    GameData.ShipTurnUD = float.Parse(substrings[3]);
                    GameData.ShipWeight = int.Parse(substrings[4]);
                    GameData.ShipHull = int.Parse(substrings[5]);
                    GameData.ShipWeaponViewWidth = float.Parse(substrings[6]);
                    GameData.ShipWeaponViewHeight = float.Parse(substrings[7]);
                    GameData.ShipMinDamage = int.Parse(substrings[8]);
                    GameData.ShipMaxDamage = int.Parse(substrings[9]);
                    GameData.ShipEvasion = float.Parse(substrings[10]);
                    GameData.ShipVolume = int.Parse(substrings[11]);
                    GameData.ShipWeaponCoolDown = float.Parse(substrings[12]);

                    /*
                    Debug.Log("Ship Stats");
                    Debug.Log(GameData.ShipMoveForce);
                    Debug.Log(GameData.ShipTurnForce);
                    Debug.Log(GameData.ShipTurnRL);
                    Debug.Log(GameData.ShipTurnUD);
                    Debug.Log(GameData.ShipWeight);
                    Debug.Log(GameData.ShipHull);
                    Debug.Log(GameData.ShipWeaponViewWidth);
                    Debug.Log(GameData.ShipWeaponViewHeight);
                    Debug.Log(GameData.ShipMinDamage);
                    Debug.Log(GameData.ShipMaxDamage);
                    Debug.Log(GameData.ShipEvasion);
                    Debug.Log(GameData.ShipVolume);
                    */

                    post_url = svURL + "AttrMods";
                    WWW getAttrMods = new WWW(post_url);
                    //Debug.Log(post_url);
                    StartCoroutine(WaitForAttMods(getAttrMods));
                }
                else
                {
                    Debug.Log("Error");
                }
            }
        }

        private IEnumerator WaitForAttMods(WWW getAttrMods)
        {
            yield return getAttrMods;

            if (getAttrMods.error == null)
            {
                if (getAttrMods.text != "0")
                {
                    string returnedString = getAttrMods.text;

                    Char delimiter = ';';
                    String[] substrings = returnedString.Split(delimiter);

                    GameData.StrengthADJValue = float.Parse(substrings[0]);
                    GameData.IntelligenceADJValue = float.Parse(substrings[1]);
                    GameData.DexterityADJValue = float.Parse(substrings[2]);
                    GameData.WisdomADJValue = float.Parse(substrings[3]);
                    GameData.HealthADJValue = float.Parse(substrings[4]);
                    GameData.EagleADJValue = float.Parse(substrings[5]);
                    GameData.SpeedADJValue = float.Parse(substrings[6]);
                    GameData.EnduranceADJValue = float.Parse(substrings[7]);
                    GameData.NervesADJValue = float.Parse(substrings[8]);
                    GameData.CharismaADJValue = float.Parse(substrings[9]);

                    /*
                    Debug.Log("Ship Stats");
                    Debug.Log(GameData.ShipMoveForce);
                    Debug.Log(GameData.ShipTurnForce);
                    Debug.Log(GameData.ShipTurnRL);
                    Debug.Log(GameData.ShipTurnUD);
                    Debug.Log(GameData.ShipWeight);
                    Debug.Log(GameData.ShipHull);
                    Debug.Log(GameData.ShipWeaponViewWidth);
                    Debug.Log(GameData.ShipWeaponViewHeight);
                    Debug.Log(GameData.ShipMinDamage);
                    Debug.Log(GameData.ShipMaxDamage);
                    Debug.Log(GameData.ShipEvasion);
                    Debug.Log(GameData.ShipVolume);
                    */

                    //This will need to move
                    Application.LoadLevel("Orbit");
                }
                else
                {
                    Debug.Log("Error");
                }
            }
        }
    }
}

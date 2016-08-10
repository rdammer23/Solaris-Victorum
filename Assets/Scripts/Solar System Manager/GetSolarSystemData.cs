using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts.Solar_System_Manager
{
    class GetSolarSystemData:MonoBehaviour
    {
        public string svURL = "http://solarisvictorum.space/solarisvictorum/php/SVFunctions.php?whichfunction="; //be sure to add a ? to your url
        private string post_url;
        WWW planetInformation;
        WWW moonInformation;
        int ssid;

        public void GetMoonData(int ssID)
        {
            List<int> mList = new List<int>();
            ssid = ssID;
            //GameData.PlayerID = 1; //TODO This should be variable once testing is done
            post_url = svURL + "MoonL" + "&playerID=" + (GameData.PlayerID) + "&ssID=" + (ssid);
            moonInformation = new WWW(post_url);
            StartCoroutine(WaitForMoonRequest(moonInformation, mList));
            //NoDBMoon(mList);
        }

        private void NoDBMoon(List<int> mList)
        {
            mList.Add(2);
            mList.Add(1);
            mList.Add(1);
            mList.Add(1);
            mList.Add(1);
            mList.Add(2);
            mList.Add(1);
            mList.Add(1);
            mList.Add(1);
            mList.Add(1);
            mList.Add(2);
            mList.Add(1);
            mList.Add(1);
            mList.Add(1);
            mList.Add(1);
            mList.Add(2);
            mList.Add(1);
            mList.Add(1);
            mList.Add(1);
            mList.Add(1);
            GetComponent<SolarSystemInitializer>().GotMoonLevel(mList);

        }

        private IEnumerator WaitForMoonRequest(WWW moonInformation, List<int> mList)
        {
            yield return moonInformation;


            // check for errors
            if (moonInformation.error == null)
            {
                if (moonInformation.text != "0")
                {
                    string returnedString = moonInformation.text;
                    Char delimiter = ';';
                    String[] substrings = returnedString.Split(delimiter);
                    //Debug.Log("Ss length: " + substrings.Length);
                    for (int i = 0; i < substrings.Length - 1; i++)
                    {
                        int x = int.Parse(substrings[i]);
                        mList.Add(x);
                    }
                    GetComponent<SolarSystemInitializer>().GotMoonLevel(mList);
                }
            }
            else
            {
                //Debug.Log("Error" + moonInformation);
                GetMoonData(ssid);
            }
        }

        public void GetPlanetData(int ssID)
        {
            List<int> pList = new List<int>();
            ssid = ssID;
            //GameData.PlayerID = 1; //TODO This should be variable once coding done
            post_url = svURL + "PlanetL" + "&playerID=" + (GameData.PlayerID) + "&ssID=" + (ssid);
            planetInformation = new WWW(post_url);
            StartCoroutine(WaitForRequest(planetInformation, pList));
            //NoDBPlanet(pList);
        }

        private void NoDBPlanet(List<int> pList)
        {
            pList.Add(2);
            pList.Add(1);
            pList.Add(1);
            pList.Add(1);
            pList.Add(1);
            GetComponent<SolarSystemInitializer>().GotPlanetLevel(pList);

        }

        private IEnumerator WaitForRequest(WWW planetInformation, List<int> pList)
        {
            yield return planetInformation;
            

            // check for errors
            if (planetInformation.error == null)
            {
                if (planetInformation.text != "0")
                {
                    string returnedString = planetInformation.text;
                    Char delimiter = ';';
                    String[] substrings = returnedString.Split(delimiter);
                    //Debug.Log("Ss length: " + substrings.Length);
                    for (int i = 0; i < substrings.Length - 1; i++)
                    {
                        int x = int.Parse(substrings[i]);
                        pList.Add(x);
                    }
                    GetComponent<SolarSystemInitializer>().GotPlanetLevel(pList);
                }
            }
            else
            {
                Debug.Log("Error" + planetInformation);
                GetPlanetData(ssid);
            }
        }
    }
}

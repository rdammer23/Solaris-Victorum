using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.NPC_Classes.PoolManagers;
using Assets.Scripts.NPC_Classes;

namespace Assets.Scripts.Solar_System_Manager
{

    class SolarSystemInitializer:MonoBehaviour
    {
        private int ssID;
        private string pmMaterial;
        List<int> pList;
        List<int> mList;

        private GameObject star;
        private GameObject[] planet;
        private GameObject[] moon;

        Material starColor;
        Material pmLevelMaterial;
        Material moonLevel;
        //public Light starLight;
        private GameObject starPointLight;

        GETSolarSystemID getSSID;
        int currentSSID;

        public void Awake()
        {
            pList = new List<int>();
            mList = new List<int>();
            getSSID = new GETSolarSystemID();
        }

        void Start()
        {
            currentSSID = getSSID.GetSolarSystemID();

            star = GameObject.FindGameObjectWithTag("LocalStar");
            starPointLight = GameObject.Find("Point light");

            SetStarColor();
            GetAllPlanets();
            GetPlanetLevel();

            //This stuff may need to be called by the preceeding functions
            //ActivateOtherScripts();
        }

        private void ActivateOtherScripts()
        {
            GetComponent<Orbits>().enabled = true;
        }

        
        private void SetStarColor()
        {
            //Debug.Log(GameData.CurrentScene);
            
            switch (GameData.CurrentScene)
            {
                case "SolarSystem1":
                    ssID = 1001;
                    starColor = Resources.Load("Star/Materials/YellowStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(255, 255, 0, 255);
                    break;
                case "SolarSystem2":
                    ssID = 1002;
                    starColor = Resources.Load("Star/Materials/MaroonStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(255, 0, 0, 255);

                    //starLight.GetComponent<Light>().color = new Color32(255, 0, 0, 255);
                    break;
                case "SolarSystem3":
                    ssID = 1003;
                    starColor = Resources.Load("Star/Materials/OrangeStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(255, 153, 51, 255);
                    break;
                case "SolarSystem4":
                    ssID = 1004;
                    starColor = Resources.Load("Star/Materials/GreenStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(0, 255, 0, 255);
                    break;
                case "SolarSystem5":
                    ssID = 1005;
                    starColor = Resources.Load("Star/Materials/WhiteStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(0, 255, 0, 255);
                    //starLight.GetComponent<Light>().color = new Color32(255, 255, 255, 255);
                    break;
                case "SolarSystem6":
                    ssID = 1006;
                    starColor = Resources.Load("Star/Materials/BlueStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(51, 51, 255, 255);
                    break;
                case "SolarSystem7":
                    ssID = 1007;
                    starColor = Resources.Load("Star/Materials/PurpleStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(153, 51, 255, 255);
                    break;
                case "SolarSystem8":
                    ssID = 1008;
                    starColor = Resources.Load("Star/Materials/BrightRedStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(255, 0, 157, 255);
                    break;
                case "SolarSystem9":
                    ssID = 1009;
                    starColor = Resources.Load("Star/Materials/PinkStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(255, 153, 255, 255);
                    break;
                case "SolarSystem10":
                    ssID = 1010;
                    starColor = Resources.Load("Star/Materials/YellowGreenStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(204, 204, 0, 255);
                    break;
                case "SolarSystem11":
                    ssID = 1011;
                    starColor = Resources.Load("Star/Materials/LightPurpleStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(204, 153, 255, 255);
                    break;
                default:
                    ssID = 1001;
                    starColor = Resources.Load("Star/Materials/YellowStar") as Material;
                    starPointLight.GetComponent<Light>().color = new Color32(255, 255, 0, 255);
                    break;
            }
            
            star.GetComponent<Renderer>().material = starColor;
        }

        private void GetAllPlanets()
        {
            planet = GameObject.FindGameObjectsWithTag("Planet");
        }

        private void GetPlanetLevel()
        {
            GetComponent<GetSolarSystemData>().GetPlanetData(currentSSID); //TODO This needs to be a variable.
        }

        public void GotPlanetLevel(List<int> pLevel)
        {
            pList = pLevel;
        
            foreach (var p in planet)
            {
                //Debug.Log(p.transform.parent.name);
                string tempString = p.transform.parent.name;
                if (tempString.Contains(' '))
                {
                    int index = tempString.IndexOf(' ');
                    int maxLength = tempString.Length - index;
                    int planetPosition = (int.Parse)(tempString.Substring(index, maxLength));
                    //Debug.Log(planetPosition);
                    int result = pList[planetPosition - 1];

                    SetPlanetTexture(result, p);
                }
            }
            GetAllMoons();
        }

        private void SetPlanetTexture(int planetLevel, GameObject p)
        {
            switch (planetLevel)
            {
                case 1:
                    pmMaterial = "PlanetLevel" + planetLevel;
                    pmLevelMaterial = Resources.Load("Planet/Materials/" + pmMaterial) as Material;
                    p.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                case 2:
                    pmMaterial = "PlanetLevel" + planetLevel;
                    pmLevelMaterial = Resources.Load("Planet/Materials/" + pmMaterial) as Material;
                    p.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                case 3:
                    pmMaterial = "PlanetLevel" + planetLevel;
                    pmLevelMaterial = Resources.Load("Planet/Materials/" + pmMaterial) as Material;
                    p.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                case 4:
                    pmMaterial = "PlanetLevel" + planetLevel;
                    pmLevelMaterial = Resources.Load("Planet/Materials/" + pmMaterial) as Material;
                    p.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                case 5:
                    pmMaterial = "PlanetLevel" + planetLevel;
                    pmLevelMaterial = Resources.Load("Planet/Materials/" + pmMaterial) as Material;
                    p.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                default:
                    pmMaterial = "PlanetLevel" + "1";
                    pmLevelMaterial = Resources.Load("Planet/Materials/" + pmMaterial) as Material;
                    p.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
            }
        }


        private void GetAllMoons()
        {
            moon = GameObject.FindGameObjectsWithTag("MoonTexture");
            //Debug.Log("# of Moons: " + moon.Length);
            GetMoonLevel();
        }

        private void GetMoonLevel()
        {
            GetComponent<GetSolarSystemData>().GetMoonData(currentSSID); //TODO This needs to be a variable.
        }

        public void GotMoonLevel(List<int> mLevel)
        {
            mList = mLevel;

            foreach (var m in moon)
            {
                //Debug.Log(m.transform.parent.name);
                string tempString = m.transform.parent.name;
                if (tempString.Contains(' '))
                {
                    int index = tempString.IndexOf(' ');
                    int maxLength = tempString.Length - index;
                    int moonPosition = (int.Parse)(tempString.Substring(index, maxLength));
                    //Debug.Log(moonPosition);
                    //Debug.Log("mlist count: " + mList.Count);
                    //Debug.Log(mList[moonPosition - 1]);
                    int result = mList[moonPosition - 1];

                    SetMoonTexture(result, m);
                }
            }
            //Start NPC Initialize after All Moon Textures Set
            GetComponentInParent<NPCPoolManager>().InitializeNPC(ssID);
        }

        private void SetMoonTexture(int moonLevel, GameObject m)
        {
            switch (moonLevel)
            {
                case 1:
                    pmMaterial = "MoonLevel" + moonLevel;
                    pmLevelMaterial = Resources.Load("Moon/Materials/" + pmMaterial) as Material;
                    m.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                case 2:
                    pmMaterial = "MoonLevel" + moonLevel;
                    pmLevelMaterial = Resources.Load("Moon/Materials/" + pmMaterial) as Material;
                    m.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                case 3:
                    pmMaterial = "MoonLevel" + moonLevel;
                    pmLevelMaterial = Resources.Load("Moon/Materials/" + pmMaterial) as Material;
                    m.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                case 4:
                    pmMaterial = "MoonLevel" + moonLevel;
                    pmLevelMaterial = Resources.Load("Moon/Materials/" + pmMaterial) as Material;
                    m.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                case 5:
                    pmMaterial = "MoonLevel" + moonLevel;
                    pmLevelMaterial = Resources.Load("Moon/Materials/" + pmMaterial) as Material;
                    m.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
                default:
                    pmMaterial = "MoonLevel" + "1";
                    pmLevelMaterial = Resources.Load("Moon/Materials/" + pmMaterial) as Material;
                    m.GetComponent<Renderer>().material = pmLevelMaterial;
                    break;
            }
        }
    }
}

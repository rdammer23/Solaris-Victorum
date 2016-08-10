/*using System.Collections.Generic;
using Mono.Data.Sqlite;
using System.Data;
using UnityEngine;
using Assets.Scripts.Star;
using Assets.Scripts.Planet;
using Assets.Scripts.Moon;
using BeardedManStudios.Network;

namespace Assets.Scripts.SolarSystem {
    class SolarSystemManager:SimpleNetworkedMonoBehavior {

        private int sceneID = 1;
        static int planetID;
        static int planetSize;

        static int moonID;
        static float moonSize;

        static string planetMaterialWanted;
        static string moonMaterialWanted;

        static bool isStarsLoaded = false;
        static bool isPlanetsLoaded = false;
        static bool isMoonsLoaded = false;

        static Vector3 planetScale;

        StarManager _starManager;
        PlanetManager _planetManager;
        //ParentStar _parentStar;
        PlanetAttributes _planetAttributes;
        PlanetSizes _planetSize;
        PlanetLevel _planetLevel;

        

        MoonManager _moonManager;
        
        MoonAttributes _moonAttributes;
        MoonSizes _moonSize;
        MoonLevel _moonLevel;



        public List<SolarSystem> localSolarSystems;
        public List<Planet.Planet> localPlanets;
        public List<Moon.Moon> localMoons;

        static string conn;
        private SqliteConnection dbconn = null;
        private SqliteConnection dbconnWrite = null;
        private IDbCommand dbcmd;

//Loads all stars
//Loads all planets
//Load all moons

        public void Start() {
            LoadStars();
        }

        public void Update() {
            if (isStarsLoaded) {
                Debug.Log("All stars loaded");
                LoadPlanets();
                isStarsLoaded = false;
            }
            #region isPlanetsLoaded
            if (isPlanetsLoaded) {
                Debug.Log("All PLANETS loaded");
                //Need to set the textures, scale and parent the planet.
                foreach (Planet.Planet _localPlanets in localPlanets) {
                    _planetSize = new PlanetSizes();
                    _planetLevel = new PlanetLevel();

                    GameObject tempPlanetGO = GameObject.Find(_localPlanets.PlanetID.ToString());

                    PlanetAttributes _planetAttribute;
                    _planetAttribute = tempPlanetGO.GetComponentInChildren<PlanetAttributes>();

                    planetSize = _planetSize.PlanetSize(_localPlanets.PlanetSize);

                    //Set Scale of Planets
                    tempPlanetGO.transform.localScale = new Vector3(planetSize, planetSize, planetSize);

                    #region Parent the Planet to Star
                    //Parent Planets with Correct Star
                    GameObject[] starTemp = GameObject.FindGameObjectsWithTag("LocalStar");
                    foreach(GameObject _starTemp in starTemp) {
                        int planetSSID = _localPlanets.SolarSystemID;
                        int starSSID = int.Parse(_starTemp.name);
                        if (planetSSID == starSSID) {
                            Transform starTransform = _starTemp.transform;
                            tempPlanetGO.transform.parent = starTransform;
                            tempPlanetGO.transform.localPosition = new Vector3(_localPlanets.LocationX, _localPlanets.LocationY, _localPlanets.LocationZ);
                        }
                    }
                    #endregion
                    
                    //Set the Mesh of the Planet Based on Level
                    planetMaterialWanted = _planetLevel.GetPlanetTexture(_localPlanets.PlanetLevel);
               //     Material mat = (Material)Resources.Load(planetMaterialWanted, typeof(Material));
               //     _planetAttribute.SetPlanetMaterial(mat);
                }
                LoadMoons();
                isPlanetsLoaded = false;
            }
            #endregion

            #region isMoonsLoaded
            if (isMoonsLoaded) {
                Debug.Log("All Moons loaded");
                //Need to set the textures, scale and parent the moon.
                foreach (Moon.Moon _localMoons in localMoons) {
                    _moonSize = new MoonSizes();
                    _moonLevel = new MoonLevel();

                    GameObject tempMoonGO = GameObject.Find(_localMoons.MoonID.ToString());

                    MoonAttributes _moonAttribute;
                    _moonAttribute = tempMoonGO.GetComponentInChildren<MoonAttributes>();

                    moonSize = _moonSize.MoonSize(_localMoons.MoonSize);

                    //Set Scale of Moons
                    tempMoonGO.transform.localScale = new Vector3(moonSize, moonSize, moonSize);

                    #region Parent the Moon to Planet
                    //Parent Moons with Correct Planet
                    GameObject[] planetTemp = GameObject.FindGameObjectsWithTag("PlanetAtmosphere");
                    foreach (GameObject _planetTemp in planetTemp) {

                        int moonPlanetID = _localMoons.PlanetID;
                        //Debug.Log("Moon Parent Planet ID = " + moonPlanetID);
                        int planetID = int.Parse(_planetTemp.name);
                        //Debug.Log("Planet ID = " + planetID);
                        //Debug.Log(moonPlanetID + " Does it equal " + planetID);
                        if (moonPlanetID == planetID) {
                            Transform planetTransform = _planetTemp.transform;
                            tempMoonGO.transform.parent = planetTransform;
                            tempMoonGO.transform.localPosition = new Vector3(_localMoons.LocationX, _localMoons.LocationY, _localMoons.LocationZ);
                        }

                    }

                    #endregion
                    
                    //Set the Mesh of the Moon Based on Level
                  /*  moonMaterialWanted = _moonLevel.GetMoonTexture(_localMoons.MoonLevel);
                    Material matMoon = (Material)Resources.Load(moonMaterialWanted, typeof(Material));
                    _moonAttribute.SetMoonMaterial(matMoon);
                    
                    
                }

                isMoonsLoaded = false;
            }
            #endregion

        }

        public void AllMoonsLoaded() {
            isMoonsLoaded = true;
        }

        public void AllPlanetsLoaded() {
            isPlanetsLoaded = true;
        }

        public void AllStarsLoaded() {
            isStarsLoaded = true;
        }

        public void LoadMoons() {
            localMoons = new List<Moon.Moon>();
            foreach(Planet.Planet _localPlanet in localPlanets) {
                dbconn = new SqliteConnection(conn);
                dbconn.Open();

                IDbCommand dbcmdMoon = dbconn.CreateCommand();
                string sqlQueryMoon = "Select * from Moon where PlanetID = '" + _localPlanet.PlanetID + "'";
                dbcmdMoon.CommandText = sqlQueryMoon;
                IDataReader readerMoon = dbcmdMoon.ExecuteReader();

                while (readerMoon.Read()) {
                    localMoons.Add(new Moon.Moon(readerMoon.GetInt32(0),
                        readerMoon.GetInt32(1),
                        readerMoon.GetInt32(2),
                        readerMoon.GetInt32(3),
                        readerMoon.GetFloat(4),
                        readerMoon.GetFloat(5),
                        readerMoon.GetFloat(6)));
                }
                dbconn.Close();
            }
            int numMoons = localMoons.Count;
            Debug.Log("Numer of Moons in Solar System = " + numMoons);
            foreach (Moon.Moon _localMoons in localMoons) {
                /*
                0 = MoonID
                1 = Parent PlanetID
                2 = Moon Size
                3 = Moon Level
                4 = Location X
                5 = Location Y
                6 = Location Z
                

                _moonManager = new MoonManager();
                numMoons = localMoons.Count;
                _moonManager.InstantiateMoon(_localMoons.MoonSize, _localMoons.MoonLevel, _localMoons.LocationX,
                    _localMoons.LocationY, _localMoons.LocationZ, _localMoons.MoonID, numMoons);
            }
        }

        public void LoadPlanets() {
            localPlanets = new List<Planet.Planet>();
            foreach (SolarSystem _localSolarSystem in localSolarSystems) {

                dbconn = new SqliteConnection(conn);
                dbconn.Open();

                IDbCommand dbcmdPlanet = dbconn.CreateCommand();
                string sqlQueryPlanet = "Select * from Planet where SolarSystemID = '" + _localSolarSystem.SolarSystemID + "'";
                dbcmdPlanet.CommandText = sqlQueryPlanet;
                IDataReader readerPlanet = dbcmdPlanet.ExecuteReader();

                while (readerPlanet.Read()) {
                    localPlanets.Add(new Planet.Planet(readerPlanet.GetInt32(0),
                        readerPlanet.GetInt32(1),
                        readerPlanet.GetInt32(2),
                        readerPlanet.GetInt32(3),
                        readerPlanet.GetFloat(4),
                        readerPlanet.GetFloat(5),
                        readerPlanet.GetFloat(6)));
                }
                dbconn.Close();
            }
            int numPlanets = localPlanets.Count;
            Debug.Log("Numer of Planets in Solar System = " + numPlanets);
            foreach (Planet.Planet _localPlanets in localPlanets) {
                /*
                0 = PlanetID
                1 = Parent SolarSystemID (Star)
                2 = Planet Size
                3 = Planet Level
                4 = Location X
                5 = Location Y
                6 = Location Z
                

                _planetManager = new PlanetManager();
                numPlanets = localPlanets.Count; 
                _planetManager.InstantiatePlanet(_localPlanets.PlanetSize, _localPlanets.PlanetLevel, _localPlanets.LocationX,
                    _localPlanets.LocationY, _localPlanets.LocationZ, _localPlanets.PlanetID, numPlanets);
            }
        }

        public void LoadStars() {
            if (Networking.PrimarySocket.IsServer) {
                localSolarSystems = new List<SolarSystem>();
                conn = "Data Source=" + Application.dataPath + "/TAO.db";
                dbconn = new SqliteConnection(conn);
                dbconn.Open();

                IDbCommand dbcmd = dbconn.CreateCommand();
                string sqlQuery = "Select * from SolarSystem where SceneID = '" + sceneID + "'";
                dbcmd.CommandText = sqlQuery;
                IDataReader reader = dbcmd.ExecuteReader();
                while (reader.Read()) {
                    localSolarSystems.Add(new SolarSystem(reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetInt32(3),
                        reader.GetFloat(4),
                        reader.GetFloat(5),
                        reader.GetFloat(6)));
                }
                dbconn.Close();
                int numStars = localSolarSystems.Count;

                foreach (SolarSystem _localSolarSystem in localSolarSystems) {
                    /*
                    0 = starID
                    1 = SceneID
                    2 = Solar System Name
                    3 = Star Type
                    4 = Location X
                    5 = Location Y
                    6 = Location Z
                    
                    _starManager = new StarManager();
                    _starManager.InstantiateStars(_localSolarSystem.StarType, _localSolarSystem.LocationX,
                        _localSolarSystem.LocationY, _localSolarSystem.LocationZ, numStars, _localSolarSystem.SolarSystemID);
                }
            }
        }
    }
}
*/
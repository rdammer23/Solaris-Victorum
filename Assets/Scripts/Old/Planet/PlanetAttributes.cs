/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

namespace Assets.Scripts.Planet {
    class PlanetAttributes:MonoBehaviour {

        public string planetID;

        public int ssID;
        public int planetLevel;
        private int planetSize;
        private Vector3 planetLocation;
        private Vector3 planetScale;

        public string planetMaterial;

        Transform parentStar;

        PlanetLoader _planetLoader;
        PlanetLevel _planetLevel;
        PlanetMaterial _planetMaterial;
        PlanetSizes _planetSize;
        
        static string conn;
        private SqliteConnection dbconn = null;
        private IDbCommand dbcmd;

        public void Start() {
            planetID = gameObject.name;

            conn = "Data Source=" + Application.dataPath + "/TAO.db";
            dbconn = new SqliteConnection(conn);
            dbconn.Open();

            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery = "Select SolarSystemID, PlanetLevel, PlanetSize, LocationX, LocationY, LocationZ from Planet where PlanetID = '" + planetID + "'";
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            if (reader.Read())
            {
                ssID = reader.GetInt32(0);
                planetLevel = reader.GetInt32(1);
                planetSize = reader.GetInt32(2);
                planetLocation = new Vector3(reader.GetFloat(3), reader.GetFloat(4), reader.GetFloat(5));
            }
            parentStar = GameObject.Find(ssID.ToString()).transform;
            transform.parent = parentStar;

            planetMaterial = GetPlanetTexture(planetLevel);
            Material planetMat = (Material)Resources.Load(planetMaterial, typeof(Material));
            GetComponentInChildren<Renderer>().material = planetMat;

            planetScale = GetPlanetScale(planetSize);
            GetComponent<Transform>().localScale = planetScale;

            GetComponent<Transform>().localPosition = planetLocation;

        }
        

        public Vector3 GetPlanetScale(int planetSize)
        {
            _planetSize = new PlanetSizes();
           int tempSize =  _planetSize.PlanetSize(planetSize);
            planetScale = new Vector3(tempSize, tempSize, tempSize);
            return planetScale;
        }

        public string GetPlanetTexture(int planetLevel)
        {
            _planetLevel = new PlanetLevel();
            return _planetLevel.GetPlanetTexture(planetLevel);
        }
    }
}
*/
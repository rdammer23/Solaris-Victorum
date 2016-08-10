/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

namespace Assets.Scripts.Moon {
    class MoonAttributes:MonoBehaviour {

        public string moonID;

        private float planetPrefabScale = 5f;

        public int pID;
        public int moonLevel;
        private float x;
        private float y;
        private float z;
        private Vector3 moonLocation;
        private Vector3 moonScale;
        private int moonSize;

        public string moonMaterial;

        static string conn;
        private SqliteConnection dbconn = null;
        private IDbCommand dbcmd;

        MoonLoader _moonLoader;
        MoonLevel _moonLevel;
        MoonMaterial _moonMaterial;
        MoonSizes _moonSize;

        Transform parentMoon;

        public void Start()
        {
            moonID = gameObject.name;

            conn = "Data Source=" + Application.dataPath + "/TAO.db";
            dbconn = new SqliteConnection(conn);
            dbconn.Open();

            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery = "Select PlanetID, MoonLevel, MoonSize, LocationX, LocationY, LocationZ from Moon where MoonID = '" + moonID + "'";
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            if (reader.Read())
            {
                pID = reader.GetInt32(0);
                moonLevel = reader.GetInt32(1);
                moonSize = reader.GetInt32(2);
                x = reader.GetFloat(3);
                y = reader.GetFloat(4);
                z = reader.GetFloat(5);
            }
             parentMoon = GameObject.Find(pID.ToString()).transform;
            transform.parent = parentMoon;

            moonMaterial = GetMoonTexture(moonLevel);
            Material moonMat = (Material)Resources.Load(moonMaterial, typeof(Material));
            GetComponentInChildren<Renderer>().material = moonMat;

            moonScale = GetMoonScale(moonSize);
            GetComponent<Transform>().localScale = moonScale;
            //Transform planet = transform.parent;
            Vector3 planetScale = transform.parent.localScale;
            x = x / planetScale.x / planetPrefabScale;
            y = y / planetScale.y / planetPrefabScale;
            z = z / planetScale.z / planetPrefabScale;
            moonLocation = new Vector3(x, y, z);
            GetComponent<Transform>().localPosition = moonLocation;
        }

        public Vector3 GetMoonScale(int moonSize)
        {
            _moonSize = new MoonSizes();
            float tempSize = _moonSize.MoonSize(moonSize);
            moonScale = new Vector3(tempSize, tempSize, tempSize);
            return moonScale;
        }

        public string GetMoonTexture(int moonLevel)
        {
            _moonLevel = new MoonLevel();
            return _moonLevel.GetMoonTexture(moonLevel);
        }
    }
}

*/
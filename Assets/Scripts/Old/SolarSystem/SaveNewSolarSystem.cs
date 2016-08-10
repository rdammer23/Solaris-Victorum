/*using Mono.Data.Sqlite;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

namespace Assets.Scripts.SolarSystem
{
    class SaveNewSolarSystem
    {
        static string conn;
        private SqliteConnection dbconn = null;
        private SqliteConnection dbconnWrite = null;
        private IDbCommand dbcmd;

        static int nextSSID;
        static int nextPID;
        static int nextMID;


        public void InsertNewSolarSystem(int ssid, int sceneID, string ssName, int starType, int x, int y, int z)
        {
            conn = "Data Source=" + Application.dataPath + "/TAO.db";
            dbconn = new SqliteConnection(conn);
            dbconn.Open();

            string sqlQuery = "INSERT INTO SolarSystem (SolarSystemID, SceneID, Name, StarType, LocationX, LocationY, LocationZ) VALUES ('" + ssid + "','" + sceneID + "','" + ssName + "','" + starType + "','" + x + "','" + y + "','" + z + "');";
            Debug.Log(sqlQuery);
            Debug.Log("I am here");
            IDbCommand dbcmd = dbconn.CreateCommand();
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteNonQuery();
            dbconn.Close();

        }

        public void InsertNewPlanets(List<Planet.Planet> plist, int planetID, int ssid, List<Moon.Moon>mlist, int moonID)
        {
            conn = "Data Source=" + Application.dataPath + "/TAO.db";
            dbconn = new SqliteConnection(conn);
            dbconn.Open();

            int planetLevel = 1;
            int moonLevel = 1;

            foreach (Planet.Planet p in plist)
            {
                string sqlQuery = "INSERT INTO Planet (PlanetID, SolarSystemID, PlanetSize, PlanetLevel, LocationX, LocationY, LocationZ) VALUES ('" + planetID + "','" + ssid + "','" + p.PlanetSize + "','" + planetLevel + "','" + p.LocationX + "','" + p.LocationY + "','" + p.LocationZ + "');";
                Debug.Log("I am here in Planet");
                IDbCommand dbcmd = dbconn.CreateCommand();
                dbcmd.CommandText = sqlQuery;
                dbcmd.ExecuteNonQuery();
                foreach (Moon.Moon m in mlist)
                {
                    if(m.MoonID == p.PlanetID)
                    {
                        InsertNewMoons(moonID, planetID, m.MoonSize, moonLevel, m.LocationX, m.LocationX, m.LocationZ);
                        moonID += 1;
                    }
                }
                planetID += 1;
            }
            dbconn.Close();
        }

        public void InsertNewMoons(int moonID, int planetID, int moonSize, int moonLevel, float x, float y, float z)
        {
                string sqlQueryMoon = "INSERT INTO Moon (MoonID, PlanetID, MoonSize, MoonLevel, LocationX, LocationY, LocationZ) VALUES ('" + moonID + "','" + planetID + "','" + moonSize + "','" + moonLevel + "','" + x + "','" + y + "','" + z + "');";
                Debug.Log("I am here in Moon");
                IDbCommand dbcmdMoon = dbconn.CreateCommand();
                dbcmdMoon.CommandText = sqlQueryMoon;
                dbcmdMoon.ExecuteNonQuery();
        }

        public int NextSSID()
        {
            conn = "Data Source=" + Application.dataPath + "/TAO.db";
            dbconn = new SqliteConnection(conn);
            dbconn.Open();

            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery = "SELECT max(SolarSystemID) FROM SolarSystem";
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                nextSSID = reader.GetInt32(0);
            }
            dbconn.Close();
            return nextSSID;
        }

        public int NextPID()
        {
            conn = "Data Source=" + Application.dataPath + "/TAO.db";
            dbconn = new SqliteConnection(conn);
            dbconn.Open();

            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery = "SELECT max(PlanetID) FROM Planet";
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                nextPID = reader.GetInt32(0);
            }
            dbconn.Close();
            return nextPID;
        }

        public int NextMID()
        {
            conn = "Data Source=" + Application.dataPath + "/TAO.db";
            dbconn = new SqliteConnection(conn);
            dbconn.Open();

            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery = "SELECT max(MoonID) FROM Moon";
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                nextMID = reader.GetInt32(0);
            }
            dbconn.Close();
            return nextMID;
        }

    }
}
*/
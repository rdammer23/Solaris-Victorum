/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

using BeardedManStudios.Network;

namespace Assets.Scripts.Planet
{
    class PlanetLoader:SimpleNetworkedMonoBehavior
    {

        //This is on each star.  When a star is instantiated, it needs to get its ID
        //and load appropriate planets

        public int ssID;

        public List<Planet> localPlanets;

        //PlanetSizes _planetSize;
        //PlanetLevel _planetLevel;

        static string conn;
        private SqliteConnection dbconn = null;
        private IDbCommand dbcmd;

        public void Start()
        {
            ssID = int.Parse(this.gameObject.name);
            if (Networking.PrimarySocket.IsServer)
            {
                ReadPlanets(ssID);
                InstantiatePlanets(localPlanets);
            }
        }

        public void ReadPlanets(int ssID)
        {
            localPlanets = new List<Planet>();
            conn = "Data Source=" + Application.dataPath + "/TAO.db";
            dbconn = new SqliteConnection(conn);
            dbconn.Open();

            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery = "Select * from Planet where SolarSystemID = '" + ssID + "'";
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();

            while (reader.Read())
            {
                localPlanets.Add(new Planet(reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetFloat(4),
                    reader.GetFloat(5),
                    reader.GetFloat(6)));
            }
            dbconn.Close();
        }

        public void InstantiatePlanets(List<Planet> planetList)
        {
            GameObject planetTemplate = Resources.Load("PlanetTemplate", typeof(GameObject)) as GameObject;

            Quaternion planetRotation = new Quaternion(0, 0, 0, 0);

            foreach (Planet p in planetList)
            {
                if (NetworkingManager.Socket == null || NetworkingManager.Socket.Connected)
                {
                    Networking.Instantiate(planetTemplate, p.PlanetID.ToString(), new Vector3(p.LocationX, p.LocationY, p.LocationZ),
                        planetRotation, NetworkReceivers.AllBuffered, PlanetSpawned);
                }
                else
                {
                    NetworkingManager.Instance.OwningNetWorker.connected += delegate () {
                        Networking.Instantiate(planetTemplate, p.PlanetID.ToString(), new Vector3(p.LocationX, p.LocationY, p.LocationZ),
                        planetRotation, NetworkReceivers.AllBuffered, PlanetSpawned);
                    };
                }
            }
        }

        private void PlanetSpawned(SimpleNetworkedMonoBehavior planetObject)
        {
            /*
            Debug.Log("The Planet object " + planetObject.name + " has spawned at " +
                    "X: " + planetObject.transform.position.x +
                    "Y: " + planetObject.transform.position.y +
                    "Z: " + planetObject.transform.position.z);
            
        }
    }
}
*/
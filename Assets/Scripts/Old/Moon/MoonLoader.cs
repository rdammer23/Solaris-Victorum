/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

using BeardedManStudios.Network;

namespace Assets.Scripts.Moon
{
    class MoonLoader:SimpleNetworkedMonoBehavior
    {
        //This is on each moon, once a moon is loaded
        //it will find all it's moons and load them
        public int pID;

        public List<Moon> localMoons;

        static string conn;
        private SqliteConnection dbconn = null;
        private IDbCommand dbcmd;

        public void Start()
        {
            pID = int.Parse(this.gameObject.name);
            if (Networking.PrimarySocket.IsServer)
            {
                ReadMoons(pID);
                InstantiateMoons(localMoons);
            }
        }

        public void ReadMoons(int pID)
        {
            localMoons = new List<Moon>();
            conn = "Data Source=" + Application.dataPath + "/TAO.db";
            dbconn = new SqliteConnection(conn);
            dbconn.Open();

            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery = "Select * from Moon where PlanetID = '" + pID + "'";
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();

            while (reader.Read())
            {
                localMoons.Add(new Moon(reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetFloat(4),
                    reader.GetFloat(5),
                    reader.GetFloat(6)));
            }
            dbconn.Close();
        }

        public void InstantiateMoons(List<Moon> moonList)
        {
            GameObject moonTemplate = Resources.Load("MoonTemplate", typeof(GameObject)) as GameObject;

            Quaternion moonRotation = new Quaternion(0, 0, 0, 0);

            foreach (Moon m in moonList)
            {
                if (NetworkingManager.Socket == null || NetworkingManager.Socket.Connected)
                {
                    Networking.Instantiate(moonTemplate, m.MoonID.ToString(), new Vector3(m.LocationX, m.LocationY, m.LocationZ),
                        moonRotation, NetworkReceivers.AllBuffered, MoonSpawned);
                }
                else
                {
                    NetworkingManager.Instance.OwningNetWorker.connected += delegate () {
                        Networking.Instantiate(moonTemplate, m.MoonID.ToString(), new Vector3(m.LocationX, m.LocationY, m.LocationZ),
                        moonRotation, NetworkReceivers.AllBuffered, MoonSpawned);
                    };
                }
            }
        }

        private void MoonSpawned(SimpleNetworkedMonoBehavior moonObject)
        {
            
            Debug.Log("The Moon object " + moonObject.name + " has spawned at " +
                     "X: " + moonObject.transform.position.x +
                     "Y: " + moonObject.transform.position.y +
                     "Z: " + moonObject.transform.position.z);
            
        }
    }
}
*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

using BeardedManStudios.Network;

namespace Assets.Scripts.Star
{
    class StarLoader:SimpleNetworkedMonoBehavior
    {
        StarTypes _starTypes;

        GameObject localStar;

        public List<SolarSystem.SolarSystem> localStars;

        static string conn;
        private SqliteConnection dbconn = null;
        private IDbCommand dbcmd;

        public void ReadStars(int sceneID)
        {
            if (Networking.PrimarySocket.IsServer)
            {
                localStars = new List<SolarSystem.SolarSystem>();
                conn = "Data Source=" + Application.dataPath + "/TAO.db";
                dbconn = new SqliteConnection(conn);
                dbconn.Open();

                IDbCommand dbcmd = dbconn.CreateCommand();
                string sqlQuery = "Select * from SolarSystem where SceneID = '" + sceneID + "'";
                dbcmd.CommandText = sqlQuery;
                IDataReader reader = dbcmd.ExecuteReader();
                while (reader.Read())
                {
                    localStars.Add(new SolarSystem.SolarSystem(reader.GetInt32(0), //SolarSystemID
                        reader.GetInt32(1),     //SceneID
                        reader.GetString(2),    //Star Name
                        reader.GetInt32(3),     //Star Type
                        reader.GetFloat(4),     //X Position
                        reader.GetFloat(5),     //Y Position
                        reader.GetFloat(6)));   //Z Position
                }
                dbconn.Close();

                InstantiateStars(localStars);
            }
        }

        public void InstantiateStars(List<SolarSystem.SolarSystem> starList)
        {
            _starTypes = new StarTypes();
            
            foreach (SolarSystem.SolarSystem s in starList)
            {
                string instanceName = s.SolarSystemID.ToString();
                int starType = s.StarType;
                Vector3 starPosition = new Vector3(s.LocationX, s.LocationY, s.LocationZ);
                Quaternion starRotation = new Quaternion(0, 0, 0, 0);

                string starTypeString = _starTypes.StarTypeLookup(starType);

                GameObject instance = Resources.Load(starTypeString, typeof(GameObject)) as GameObject;
                localStar = instance;


                if (NetworkingManager.Socket == null || NetworkingManager.Socket.Connected)
                {
                    Networking.Instantiate(localStar, instanceName, starPosition, starRotation, 
                        NetworkReceivers.AllBuffered, StarSpawned);
                }
                else
                {
                    NetworkingManager.Instance.OwningNetWorker.connected += delegate ()
                    {
                        Networking.Instantiate(localStar, instanceName, starPosition, starRotation, 
                            NetworkReceivers.AllBuffered, StarSpawned);
                    };
                }
            }

        }

        private void StarSpawned(SimpleNetworkedMonoBehavior starObject)
        {
            /*
            Debug.Log("The Star with ID " + starObject.name + " has spawned at " +
                "X: " + starObject.transform.position.x +
                "Y: " + starObject.transform.position.y +
                "Z: " + starObject.transform.position.z);
            
        }
    }
}
*/
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

using BeardedManStudios.Network;


namespace Assets.Scripts.Moon
{
    class MoonMovement:SimpleNetworkedMonoBehavior
    {
        private bool moveMoon = true;
        public float defaultOrbitSpeed = .5f;
        private float rotateSpeed = 0f;  //Moon takes funny path when rotation is on.
        private float x = 0;
        private float y = 0;
        private float z = 0;
        private float orbitSpeed;
        RandomNumber _rand;

        Transform planetPosition;

        void Start()
        {
            if (IsServerOwner)
            {
                //orbitSpeed = defaultOrbitSpeed / this.transform.localScale.x;
                planetPosition = transform.parent;
                orbitSpeed = defaultOrbitSpeed / Vector3.Distance(this.transform.position, planetPosition.position);
                _rand = new RandomNumber();
                /*  This would be used for 3D Orbit
                if (this.transform.position.x == 0)
                {
                    x = 1;
                }
                else
                {
                    x = 0;
                }

                if (this.transform.position.y == 0)
                {
                    y = 1;
                }
                else
                {
                    y = 0;
                }
                
                if (this.transform.position.z == 0)
                {
                    z = 1;
                }
                else
                {
                    z = 0;
                }

                if (x == 1 && y == 1)
                {
                    int axis = _rand.RandomNumberInt(1, 2);
                    if (axis == 1)
                    {
                        y = 0;
                    }
                    else
                    {
                        x = 0;
                    }
                }

                if (x == 1 && z == 1)
                {
                    int axis = _rand.RandomNumberInt(1, 2);
                    if (axis == 1)
                    {
                        z = 0;
                    }
                    else
                    {
                        x = 0;
                    }
                }

                if (z == 1 && y == 1)
                {
                    int axis = _rand.RandomNumberInt(1, 2);
                    if (axis == 1)
                    {
                        y = 0;
                    }
                    else
                    {
                        z = 0;
                    }
                }
                
            }
        }

        void Update()
        {
            if (IsServerOwner)
            {
                if (moveMoon)
                {
                    //movePlanet = false;
                    //this.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
                    this.transform.RotateAround(planetPosition.position, new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);
                }
            }
        }
    }
}
*/
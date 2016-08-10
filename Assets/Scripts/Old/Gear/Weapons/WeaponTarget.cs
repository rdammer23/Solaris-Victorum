using UnityEngine;
using System.Collections;
using Assets.Scripts.NPC;

namespace Assets.Scripts.Gear.Weapons
{
    class WeaponTarget:MonoBehaviour
    {
        Ray ray;

        FireRayCastLaser _fireRayCastLaser;

        public float Width = 1.0f; //LineRenderer Width Value
        public float Offset = .1f; //LineRenderer MainTexture Offset Value 
        public float MaxLength = 1000f;
        public Color StartColor;
        public Color EndColor;
        public float AlphaSpeed = 2f;
        public Transform LaserHitEffect; //For Laser Hit Effect.
        public Material _Material; //For LineRenderer Material

        private LineRenderer _LineRenderer; //LineRenderer Value
        private float NowLength; // if Raycast Hit Something, Save Length Information Between this transform , RacastHit's hit point.
        private GameObject _Effect;
        float AlphaValue = 1.0f;

        RaycastHit hit; //Raycast Value Set

        BasicNPCManager _npcManager;
        Transform Obj;

        Vector3 tempV3;

        void Awake()
        {
            Obj = Instantiate(LaserHitEffect, transform.position, Quaternion.identity) as Transform; // Make Effect.
            Obj.gameObject.SetActive(false);

            _fireRayCastLaser = new FireRayCastLaser();

            AlphaValue = 1.0f;
            _LineRenderer = GetComponent<LineRenderer>(); //LineRenderer Set

            _LineRenderer.material = _Material;
            _LineRenderer.SetWidth(Width, Width);
            _LineRenderer.SetColors(StartColor, EndColor);
            _LineRenderer.SetPosition(0, transform.parent.position);
            

            _npcManager = new BasicNPCManager();

            
        }


        void Start()
        {
            

        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CastRay();
                Obj.gameObject.SetActive(false);
            }
            else
            {
            //ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            }


            /*
                        if (Physics.Raycast(ray, Mathf.Infinity))
                        {
                            //player.gameObject.transform.position = new Vector3(100,100,100);

                            _fireRayCastLaser.YellowOnce();

                        }
            */
            _LineRenderer.material.SetTextureOffset("_MainTex",
    new Vector2(-Time.time * 30f * Offset, 0.0f)); //Because of Movement of Laser, Change x Offset throught Offset Value.

            AlphaValue -= Time.deltaTime * AlphaSpeed; // For disapperaing LineRenderer Texture, Alpha Value decreace.
            _LineRenderer.GetComponent<Renderer>().material.SetColor("_TintColor", new Color(StartColor.r, StartColor.g, StartColor.b, AlphaValue)); // color or alpha value set.

        }

        void CastRay()
        {
            Debug.Log("Mouse Down");
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Debug.Log(ray);
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.cyan);

            //if (Physics.Raycast(transform.position, transform.forward, out hit, MaxLength)) //Check the Raycast Hit Object
            if (Physics.Raycast(ray, out hit, MaxLength))
            {
                //NowLength = hit.distance;
                Debug.Log("I am Laser and I hit " + hit.transform.name);
                tempV3 = hit.transform.position;
            }
            else
            {
                Debug.Log("Made first else");
                //NowLength = 1000;
                hit.distance = 0;
                tempV3 = ray.GetPoint(100);

            }

            Vector3 NewPos = this.transform.position + tempV3;
            
            //            Vector3 NewPos = this.transform.position + new Vector3(hit.transform.position.x * (NowLength)
            //               , hit.transform.position.y * (NowLength), hit.transform.position.z * (NowLength)); //Set Next Position Use the NowLength

            Debug.Log("hit.Disance = " + hit.distance);
            Debug.Log("NewPos = " + NewPos);
            Debug.Log(_LineRenderer + " Line Rend");
            //_LineRenderer.SetPosition(1, NewPos); //LineRenderer 2 Position Set.
            _LineRenderer.SetPosition(1, new Vector3(0, 0, 500)); //LineRenderer 2 Position Set.

            if (hit.distance != 0)
            {

                //Transform Obj = Instantiate(LaserHitEffect, transform.position, Quaternion.identity) as Transform; // Make Effect.
                Obj.gameObject.SetActive(true);

                Obj.transform.position = NewPos;
                //Obj.transform.rotation = hit.collider.transform.rotation;

                Obj.transform.parent = this.transform;
            }
            else
            {
                Debug.Log("made the else");
                Obj.gameObject.SetActive(false);
            }
        }
    }
}

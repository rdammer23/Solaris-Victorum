using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

using Assets.Scripts.NPC;

namespace Assets.Scripts.Gear.Weapons
{
    class LaserFire:MonoBehaviour
    {
        private LineRenderer lineRenderer;
        private Ray ray;
        public Color StartColor;
        public Color EndColor;
        RaycastHit hit; 
        public Transform LaserHitEffect; //For Laser Hit Effect.
        Transform Obj;

        private float maxLength = 500;
        private float beamLength;
        float AlphaValue = 1.0f;
        private float Offset = 1.0f; 
        private float AlphaSpeed = 5f;

        private Vector3 endPoint;

        BasicNPCManager _basicNPCManager;
        InstantiateLaserBeamsLocal _fireLaser;

        public GameObject player;

        void Awake()
        {
            _basicNPCManager = new BasicNPCManager();
            _fireLaser = new InstantiateLaserBeamsLocal();
        }

        void Start()
        {
            lineRenderer = GetComponent<LineRenderer>();
            lineRenderer.SetColors(StartColor, EndColor);

            Obj = Instantiate(LaserHitEffect, transform.position, Quaternion.identity) as Transform; // Make Effect.
            Obj.gameObject.SetActive(false);
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0)) //Need to add on Touch and fix error with it.
            {
                //Also should add a range that this ray works with, full screen too much.
                AlphaValue = 1.0f;
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                //CastRay();
                //_fireLaser.FireLaser();
            }

            //if(Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
            if(Input.touchCount > 0) //TODO This is registering multiple hits.  Need to fix!
            {
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                //CastRay();
                //_fireLaser.FireLaser();

            }
            AlphaValue -= Time.deltaTime * AlphaSpeed;
            lineRenderer.GetComponent<Renderer>().material.SetColor("_TintColor", new Color(StartColor.r, StartColor.g, StartColor.b, AlphaValue));
        }

        private void CastRay()
        {

            //TODO need to make this if statement work so I can box where touch fire happens at
            //if(ray.direction.x >= -.2 && ray.direction.x <= .2 && ray.direction.y >= -.1 && ray.direction.y <= .1)
            //{
            if (Physics.Raycast(ray, out hit, maxLength))
            {
                Obj.gameObject.SetActive(false);
                beamLength = hit.distance;
                endPoint = hit.transform.position;
                FireLaser();
                LaserExplosion();

                _basicNPCManager.HitByLaser(2, hit.transform.name);
            }
            else
            {
                beamLength = maxLength;
                endPoint = ray.direction * maxLength;
                
                FireLaser();
            }
            lineRenderer.material.SetTextureOffset("_MainTex", new Vector2(-Time.time * 30f * Offset, 0.0f)); //Because of Movement of Laser, Change x Offset throught Offset Value.
                                                                                                              //}
        }

        private void FireLaser()
        {
            //Debug.Log("Ray direction = " + ray.direction);
            //transform.LookAt(transform.position + ray.direction);
            //Debug.Log("start beam position = " + this.transform.position);


            var laserHeading = endPoint - transform.position;
            var laserDistance = laserHeading.magnitude;
            var laserDirection = laserHeading / laserDistance;

            Debug.DrawRay(this.transform.position, laserHeading * maxLength, Color.red);

            lineRenderer.SetPosition(0, this.transform.position);
            //Debug.Log("Endpoint before cast = " + laserHeading * maxLength);
            lineRenderer.SetPosition(1, laserHeading * maxLength);

        }

        private void LaserExplosion()
        {
            Obj.transform.position = hit.transform.position;
            Obj.gameObject.SetActive(true);
        }
    }
}

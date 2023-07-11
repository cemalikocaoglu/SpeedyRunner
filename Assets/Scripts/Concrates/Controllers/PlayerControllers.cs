using SpeedyRunner.Movments;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpeedyRunner.Controllers
{


    public class PlayerControllers : MonoBehaviour
    {

        public float horizontal = 0f;

        public float speed = 10f;

        HorizontalMovers _horizontalMovers;

        private void Awake()
        {
            _horizontalMovers = new HorizontalMovers(this);
        }


        private void FixedUpdate()
        {
            _horizontalMovers.tickFixed(horizontal , speed);
        }


    }

}
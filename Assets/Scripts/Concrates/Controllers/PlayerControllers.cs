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

        public float jumpVelocityNew;

        JumpRigidbody _jumpRigidbody;


        public bool _jump;

        private void Awake()
        {
            _horizontalMovers = new HorizontalMovers(this);

            _jumpRigidbody = new JumpRigidbody(this);
        }


        private void FixedUpdate()
        {
            _horizontalMovers.tickFixed(horizontal , speed);

            if( _jump )
            {
                _jumpRigidbody.ficksClick(jumpVelocityNew);
                _jump= false;
            }
        }


    }

}
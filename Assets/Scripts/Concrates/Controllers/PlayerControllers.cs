using SpeedyRunner.Abstract.Inputs;
using SpeedyRunner.Inputs;
using SpeedyRunner.Movments;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SpeedyRunner.Controllers
{


    public class PlayerControllers : MonoBehaviour
    {

        public float horizontal = 0f;

        public float speed = 10f;

        HorizontalMovers _horizontalMovers;

        public float jumpVelocityNew;

        JumpRigidbody _jumpRigidbody;


        public bool _Isjump;
        float _horizontal;



        IInputReader _input;

        private void Awake()
        {
            _horizontalMovers = new HorizontalMovers(this);

            _jumpRigidbody = new JumpRigidbody(this);

            _input = new InputReader(GetComponent<PlayerInput>());

          
        }


        private void Update()
        {
            _horizontal = _input.Horizontal;
            //Debug.Log("ÝsJump =>" + _input.IsJump);


            if(_input.IsJump )

            {
                _Isjump = true;
            }

        }



        private void FixedUpdate()
        {
            _horizontalMovers.tickFixed(_horizontal, speed);

            if( _Isjump )
            {
                _jumpRigidbody.ficksClick(jumpVelocityNew);
               
            }

            _Isjump = false;
        }


    }

}
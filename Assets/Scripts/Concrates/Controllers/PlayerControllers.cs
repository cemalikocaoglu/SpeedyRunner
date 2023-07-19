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

        [SerializeField] float _moveBoundry=7f;
        public float MoveBoundry => _moveBoundry;
        public float horizontal = 0f;

        public float speed = 10f;

        HorizontalMovers _horizontalMovers;

        public float jumpVelocityNew;

        JumpRigidbody _jumpRigidbody;


        public bool _Isjump2;
        float _horizontal;



        IInputReader _input;


        float MoveSpeed => speed;

        private void Awake()
        {
            _horizontalMovers = new HorizontalMovers(this);

            
            _jumpRigidbody = new JumpRigidbody(this);


            _input = new InputReader(GetComponent<PlayerInput>());
           


        }


        private void Update()
        {
            _horizontal = _input.Horizontal;
           // Debug.Log("ÝsJump =>" + _input.IsJump);

            //Debug.Log("Horizontal => " + _input.Horizontal);

            //if (_input.IsJump)

            //{
            //    _Isjump2 = true;
            //}


            if(Input.GetKeyDown(KeyCode.Space)) {

                _Isjump2 = true;

            }

        }



        private void FixedUpdate()
        {
            _horizontalMovers.tickFixed(_horizontal);

            if( _Isjump2 )
            {
                _jumpRigidbody.ficksClick(jumpVelocityNew);
                _Isjump2 = false;

            }
            

        }


    }

}
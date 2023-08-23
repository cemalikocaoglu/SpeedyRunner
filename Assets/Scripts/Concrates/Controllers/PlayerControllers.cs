using SpeedyRunner.Abstract.Inputs;
using SpeedyRunner.Inputs;
using SpeedyRunner.Managers;
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
        public GameObject panel;
        

        HorizontalMovers _horizontalMovers;

        public float jumpVelocityNew;

        JumpRigidbody _jumpRigidbody;


        public bool _Isjump2;
        float _horizontal;

        bool _isDead = true;

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

            if (_isDead) return;

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

        public void StartRun()
        {

            Time.timeScale = 1;
        }
        



        void OnTriggerEnter(Collider other)
        { 

            EnemeyController enemeyController = other.GetComponent<Collider>().GetComponent<EnemeyController>();

            if(enemeyController != null )
            {

                GameManager.instance.StopGame();
                panel.SetActive(true);
                _isDead=false;
            }
        }


    }

}
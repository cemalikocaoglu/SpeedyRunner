using SpeedyRunner.Movments;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpeedyRunner.Controllers
{


    public class EnemeyController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 5f;
        VerticalMover _verticalMover;

        public float MoveSpeed => _moveSpeed;

        private void Awake()
        {
            _verticalMover = new VerticalMover(this);
        }


        private void Update()
        {

            _verticalMover.fixedTick();
        }


    }

}
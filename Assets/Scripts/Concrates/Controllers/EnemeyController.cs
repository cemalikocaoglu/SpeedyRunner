using SpeedyRunner.Managers;
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

        [SerializeField] float _maxLifeTime = 7f;

        float _durationTime = 0f;

        public float MoveSpeed => _moveSpeed;

        private void Awake()
        {
            _verticalMover = new VerticalMover(this);
        }


        private void Update()
        {

            _verticalMover.fixedTick();

            _durationTime += Time.deltaTime;

            if(_durationTime > _maxLifeTime)
            {
                _durationTime = 0f;
                killedEnemy();      
            }


        }


        void killedEnemy()
        {
            EnemyManager.instance.SetPool(this);
           // Destroy(gameObject);
        }


    }

}
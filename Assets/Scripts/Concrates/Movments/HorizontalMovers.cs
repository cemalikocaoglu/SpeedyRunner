using Assets.MobileOptimizedWater.Scripts;
using SpeedyRunner.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpeedyRunner.Movments
{
    public class HorizontalMovers 
    {

        PlayerControllers _playerControllers;

        float _moveSpeed;
        float _moveBoundry;

        public HorizontalMovers(PlayerControllers playerControllers)
        {
            _playerControllers = playerControllers;

            _moveSpeed = _playerControllers.speed;
            _moveBoundry = _playerControllers.MoveBoundry;
            
        }



        public void tickFixed(float horizontal)
        {

            _playerControllers.transform.Translate(Vector3.forward  * Time.deltaTime *horizontal * _moveSpeed);


            float boundry = Mathf.Clamp(_playerControllers.transform.position.z, -_moveBoundry, _moveBoundry);

            _playerControllers.transform.position = new Vector3(34, _playerControllers.transform.position.y, boundry);

        }






    }

}
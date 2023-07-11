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

        public HorizontalMovers(PlayerControllers playerControllers)
        {
            _playerControllers = playerControllers;
            
        }



        public void tickFixed(float horizontal , float speed)
        {

            _playerControllers.transform.Translate(Vector3.forward * speed * Time.deltaTime *horizontal);

        }






    }

}
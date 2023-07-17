using SpeedyRunner.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpeedyRunner.Movments
{

    public class VerticalMover 
    {
        EnemeyController _enemeyController;
        float speedMovment=5f;

        public VerticalMover(EnemeyController enemyController)
        {
         
            _enemeyController = enemyController;
            speedMovment = _enemeyController.MoveSpeed;


        }



        public void fixedTick(float vertical =1f)
        {

            _enemeyController.transform.position += Vector3.right* Time.deltaTime * speedMovment * vertical ;


        }



    }
}
using SpeedyRunner.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpeedyRunner.Movments
{


    public class JumpRigidbody 
    {

        Rigidbody _rb;


        public JumpRigidbody(PlayerControllers playerControllers)
        {
            _rb = playerControllers.GetComponent<Rigidbody>();
                
        }


        public void ficksClick(float jumpVelocity)
        {

            _rb.AddForce(0, jumpVelocity, 0);


        }







    }

}

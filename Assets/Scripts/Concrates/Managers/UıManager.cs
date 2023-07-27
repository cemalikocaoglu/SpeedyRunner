using SpeedyRunner.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpeedyRunner.Uıs
{

    public class UıManager : MonoBehaviour
    {

        public void ExitScene1()
        {
            //Debug.Log("ldkfjsld");
            GameManager.ExitScene();


        }



        public void LoadScene1()
        {

            GameManager.LoadScene();


        }



    }
}
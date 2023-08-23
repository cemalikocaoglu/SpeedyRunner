using SpeedyRunner.Abstract.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeedyRunner.Uis;

namespace SpeedyRunner.Managers
{
    public class GameManager : SingletonMonobehaviorObjects<GameManager>
    {

      

        private void Awake()
        {
            SingletonThisObject(this);
        }


        public void StopGame()
        {

            Time.timeScale = 0;
           


        }


        public  void ExitScene()
        {

            Debug.Log("Exit");

        }

        public  void LoadScene()
        {

            Debug.Log("Load");

            Application.Quit();

        }


    }
}

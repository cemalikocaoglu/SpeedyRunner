using SpeedyRunner.Abstract.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeedyRunner.Uýs;

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


        public static void ExitScene()
        {

            Debug.Log("Exit");

        }

        public static void LoadScene()
        {

            Debug.Log("Load");

            Application.Quit();

        }


    }
}

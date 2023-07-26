using SpeedyRunner.Abstract.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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



    }
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;


public class MenuPanel : MonoBehaviour
    {

        

        

        public void StartButton()
        {

        SceneManager.LoadScene(1);
        UnityEngine.Debug.Log("Diger Sahneye Gecti");
        Time.timeScale = 1;


    }


        public void ExitButton()
        {
        UnityEngine.Debug.Log("Çýktý");
            

        }

        public void menuScene()
    {

        SceneManager.LoadScene(0);

    }


       



    }

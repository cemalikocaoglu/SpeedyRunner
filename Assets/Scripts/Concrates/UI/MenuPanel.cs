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



        }


        public void ExitButton()
        {
        UnityEngine.Debug.Log("Çýktý");
            

        }


       



    }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpeedyRunner.Abstract.Utilities
{

    public abstract class SingletonMonobehaviorObjects<T> : MonoBehaviour where T : Component
    {
        public static T instance { get; private set; }



        protected void SingletonThisObject(T entity) 
        {
            if (instance == null)
            {
                instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }

            else
            {
                Destroy(this.gameObject);
            }
        }
       



    }


}
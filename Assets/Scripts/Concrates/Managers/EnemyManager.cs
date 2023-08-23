using SpeedyRunner.Abstract.Utilities;
using SpeedyRunner.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpeedyRunner.Managers
{

    public class EnemyManager : SingletonMonobehaviorObjects<EnemyManager>
    {
        [SerializeField] EnemeyController _enemyPrefab;

       Queue<EnemeyController> _enemies = new Queue<EnemeyController>();



        private void Awake()
        {
            SingletonThisObject(this);
           
        }

        private void Start()
        {
            InitializePool();
        }


        void InitializePool()
        {

            for(int i =0; i< 10; i++)
            {
                EnemeyController newEnemy = Instantiate(_enemyPrefab);
                newEnemy.gameObject.SetActive(false);
                newEnemy.transform.parent = transform;
                _enemies.Enqueue(newEnemy);

            }


        }

       public  void SetPool(EnemeyController enemyController)
        {
            enemyController.gameObject.SetActive(false);
            enemyController.transform.parent = transform;
            _enemies.Enqueue(enemyController);

        }

       public  EnemeyController GetPool()
        {
            if(_enemies.Count == 0)
            {
                InitializePool();

            }


            return _enemies.Dequeue();
        }

        private void Update()
        {
            
           
        }

         




    }
}
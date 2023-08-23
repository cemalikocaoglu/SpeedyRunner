using SpeedyRunner.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpeedyRunner.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] GameObject enemy;
        float _sayi = 7;
        float _bekleme = 0;

        private void Start()
        {



        }


        private void Update()
        {

            _bekleme += Time.deltaTime;
            int ran_sayi = Random.Range(4, 15);
            if (_bekleme > ran_sayi)
            {
                // Instantiate(enemy, transform.position, Quaternion.identity);
                EnemeyController newEnemy = EnemyManager.instance.GetPool();
                newEnemy.transform.parent = transform;

                newEnemy.transform.position = transform.position;
                newEnemy.gameObject.SetActive(true);

                _bekleme = 0;

            }






        }


    }
}
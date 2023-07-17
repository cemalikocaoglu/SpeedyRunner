using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpeedyRunner.Controllers
{

    public class FloorController : MonoBehaviour
    {

        Material _material;

        [Range (0.5f, 2f)]
        [SerializeField] float moveSpeed = 5f;

        private void Awake()
        {
            _material = GetComponent<MeshRenderer>().material;


        }



        private void Update()
        {
            _material.mainTextureOffset += Vector2.right * Time.deltaTime * moveSpeed; 
        }



    }

}
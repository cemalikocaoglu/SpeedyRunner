using SpeedyRunner.Abstract.Inputs;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SpeedyRunner.Inputs
{
    public class InputReader : MonoBehaviour, IInputReader
    {
        PlayerInput _playerInput;


       

        public float Horizontal { get; private set; }
       // public float Jump { get; private set; }

        public bool IsJump {  get; set; }
        public InputReader(PlayerInput playerInput)
        {

            _playerInput = playerInput;

            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
            //MoveJump();
            _playerInput.currentActionMap.actions[1].started += OnJumpMove;
            _playerInput.currentActionMap.actions[1].canceled += OnJumpMove;

        }

       

         void OnJumpMove(InputAction.CallbackContext context)
        {
           IsJump = context.ReadValueAsButton();

            
        }            



        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();

        }


        private void Update()
        {
            //Debug.Log("�s-> Jump = " + IsJump);

            //Debug.Log("�s-> Jump = " + Horizontal);
        }

    }


}
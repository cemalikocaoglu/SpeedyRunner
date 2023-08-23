using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SpeedyRunner.Ui
{
    public class TimeController : MonoBehaviour
    {

        Text _text;
       float _currentTime;
        public Text _timeImage;
        private void Awake()
        {
            _text = GetComponent<Text>();


        }

        private void Update()
        {
            _currentTime += Time.deltaTime;
            
            _text.text = _currentTime.ToString("0");
            _timeImage.text = _currentTime.ToString("0");
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEditor.SceneManagement;
using UnityEngine;

public class LightSystem : MonoBehaviour
{
    //[SerializeField] private GameObject _lightSource;
   [SerializeField] private Light _light;
   private float _ballSpeed = 0;
   [SerializeField] private Animator _strobingLight;
   void Start()
    {
        _light.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
//Testing tools
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _strobingLight.SetTrigger("Blue");
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _strobingLight.SetTrigger("Yellow");
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _strobingLight.SetTrigger("Red");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _strobingLight.SetTrigger("LightOn");
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _strobingLight.SetTrigger("LightOff");
        }
        
//functions
        if (_ballSpeed == 10)
        {
            _strobingLight.SetTrigger("Blue");
        }
        
        else if (_ballSpeed >= 10 && _ballSpeed <= 50)
        {
            _strobingLight.SetTrigger("Yellow");
        }
        
        else if ( _ballSpeed >= 50 && _ballSpeed <= 100)
        {
            _strobingLight.SetTrigger("Red");
        }
        
        else if (_ballSpeed >= 100)
        {
            _strobingLight.SetTrigger("LightOn");
        }


    }
}

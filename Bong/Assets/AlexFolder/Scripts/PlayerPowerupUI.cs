using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPowerupUI : MonoBehaviour
{
    [SerializeField]private Texture2D[] powerupImages;
    [SerializeField]private Image[] powerupHolder;
    private int _totalPowerups;

    void Update()
    {
        if(_totalPowerups >= 3)
        {
            _totalPowerups = 3;
        }
    }

}

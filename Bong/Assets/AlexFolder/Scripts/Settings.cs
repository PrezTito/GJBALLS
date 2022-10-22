using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{

    

    [Header("Gameobjects")]
    [SerializeField]private Text resText;
    [SerializeField]private Toggle fullscreenTog;

    [Header("Audio")]
    [SerializeField]private AudioMixer masterMixer;

    public List<resItem> resolutions = new List<resItem>();
    private int _selectedResolution;


    public void Start()
    {

        //fullscreenTog.isOn = Screen.fullScreen;

        bool _foundRes = false;
        for(int i = 0; i < resolutions.Count; i++)
        {
            if(Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical)
            {
                _foundRes = true;

                _selectedResolution = i;

                UpdateResLable();
            }
        }

        if (!_foundRes)
        {
            resItem newRes = new resItem();
            newRes.horizontal = Screen.width;
            newRes.vertical = Screen.height;


            resolutions.Add(newRes);
            _selectedResolution = resolutions.Count - 1;

            UpdateResLable();
        }
    }

    public void ResLeft()
    {
        _selectedResolution--;

        if (_selectedResolution < 0)
        {
            _selectedResolution = 0;
        }

        UpdateResLable();
    }

    public void ResRight()
    {
        _selectedResolution++;

        if (_selectedResolution > resolutions.Count - 1)
        {
            _selectedResolution = resolutions.Count - 1;
        }

        UpdateResLable();
    }
    
    public void UpdateResLable()
    {
        resText.text = resolutions[_selectedResolution].horizontal.ToString() + " x " + resolutions[_selectedResolution].vertical.ToString();
    }

    public void ApplyGraphics()
    {
        Screen.SetResolution(resolutions[_selectedResolution].horizontal, resolutions[_selectedResolution].vertical, fullscreenTog.isOn);
    }

}

[System.Serializable]
public class resItem
{
    public int  horizontal, vertical;
}

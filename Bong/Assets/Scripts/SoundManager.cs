using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip _jump;
    [SerializeField] private float _jumpVolume = 1;
    
    [SerializeField] private AudioClip _background;
    [SerializeField] private float _backgroundVolume = 1;
    
    [SerializeField] private AudioClip _pickUp;
    [SerializeField] private float _pickUpVolume = 1;
   
    void Start()
    {
        // _audioSource.PlayOneShot(_background, _backgroundVolume);
    }


    private void PlayJump()
    {
        _audioSource.PlayOneShot(_jump,_jumpVolume);
    }

    private void PlayPickUp()
    {
        _audioSource.PlayOneShot(_pickUp, _pickUpVolume);
    }
    
}

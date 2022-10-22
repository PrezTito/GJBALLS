using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject _target;
    [SerializeField] Vector3 _offset;
    void FixedUpdate()
    {
        transform.position = _target.transform.position + _offset;       
    }
}
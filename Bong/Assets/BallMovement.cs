using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] public Vector3 MoveDirection;
    [SerializeField] float _speedIncrease;
    [SerializeField] float _speedCurrent;
    [SerializeField] float _size;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(_rb.velocity.magnitude);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(_rb.velocity.magnitude < 9);
    }
    private void LateUpdate()
    {
        transform.localScale = Vector3.one * _size;
        _rb.velocity = _rb.velocity.normalized * _speedCurrent;
    }
    public void SpawnBall(Vector3 direction, float speed, float size)
    {
        MoveDirection = direction;
        _speedCurrent = speed;
        _size = size;
        _rb.AddForce(transform.TransformDirection(MoveDirection) * _speedCurrent, ForceMode.Impulse);
    }
    void Bounce()
    {

    }
}
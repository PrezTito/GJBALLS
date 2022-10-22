using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public PlayerControls _playerControls;
    [Header("Script set up")]
    [SerializeField] private Rigidbody _rb;
    [Header("Stuff for designers")]
    [SerializeField] private float _xMoveSpeed;
    [SerializeField] private float _yMoveSpeed;
    [SerializeField] private float _xRotateSpeed;
    [SerializeField] private float _yRotateSpeed;
    private void Awake()
    {
        _playerControls = new PlayerControls();
    }
    private void Start()
    {

    }
    private void OnEnable()
    {
        _playerControls.Player.Move.Enable();
        _playerControls.Player.Move.performed += Move;
        _playerControls.Player.Rotate.Enable();
        _playerControls.Player.Rotate.performed += Rotate;
        _playerControls.Player.Power2.Enable();
        _playerControls.Player.Power2.performed += Power2;
        _playerControls.Player.Power3.Enable();
        _playerControls.Player.Power3.performed += Power3;
    }
    private void FixedUpdate()
    {
        Vector2 moveDirection = _playerControls.Player.Move.ReadValue<Vector2>();
       
        transform.position += new Vector3(moveDirection.x * _xMoveSpeed, moveDirection.y * _yMoveSpeed, 0);
        Vector3 rotateDirection = _playerControls.Player.Rotate.ReadValue<Vector2>();
        transform.RotateAround(transform.position, transform.up, rotateDirection.x);
        transform.RotateAround(transform.position, Vector3.right, -rotateDirection.y);
        //transform.Rotate(-rotateDirection.y * _xRotateSpeed, 0, 0);
        //transform.Rotate(0, rotateDirection.x * _yRotateSpeed, 0);
        //transform.Rotate(-rotateDirection.y * _xRotateSpeed, rotateDirection.x * _yRotateSpeed, 0);
    }
    public void Move(InputAction.CallbackContext context)
    {

    }
    public void Rotate(InputAction.CallbackContext context)
    {

    }
    public void Power1(InputAction.CallbackContext context)
    {

    }
    public void Power2(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        Debug.Log("XBOX");
    }
    public void Power3(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        Debug.Log("PS4");
    }
}
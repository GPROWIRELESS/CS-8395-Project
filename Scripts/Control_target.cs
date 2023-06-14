using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_target : MonoBehaviour
{
    //control tank movement:

    //public GameObject perfab_object;
    [SerializeField] private Rigidbody _rigidbody;
    //private GameObject plane_prefab;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _moveSpeed;

    //my code start
    private GameObject tank_new_joystick;
    //my code end
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y * -0.5f, _joystick.Vertical * _moveSpeed);
        if (_joystick.Horizontal !=0 || _joystick.Vertical !=0)
        {
            //transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
    }
}

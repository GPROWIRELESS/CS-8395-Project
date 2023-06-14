using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class player_controller_newjoystick : MonoBehaviour
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
        //plane_prefab = Resources.Load("Plane_test_joystick") as GameObject;
        //GameObject tank = GameObject.Find("Tank_test_joystick");
        Rigidbody _rigidbody2 = _rigidbody;
        if (GameObject.Find("Tank_test_joystick")!=null)
        {
            //print("Find tank test joystick");
            tank_new_joystick = GameObject.Find("Tank_test_joystick");
            if (tank_new_joystick.GetComponent<Rigidbody>() != null)
            {
                _rigidbody2 = tank_new_joystick.GetComponent<Rigidbody>();
                //print("find tank rigid body2");
                if(_rigidbody2.velocity != null)
                {
                    //print("get velocity");
                }
            }
            else
            {
                //print("fail to find rigid body");
            }
        }
        
        if (_rigidbody == null)
        {
            //print("_rigidbody == null");
        }
        
        //Transform tank = plane_prefab.transform.GetChild(0);
        //string tankname;
        //tankname = tank.name;
        //print("print(tankname):");
        //print(tankname);

        //_rigidbody = tank.GetComponent<Rigidbody>();
        //tank.transform.position = new Vector3(x, 0.05f, z); 
        /*
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y * -0.5f, _joystick.Vertical * _moveSpeed);
        if (_joystick.Horizontal !=0 || _joystick.Vertical !=0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
        */
        
        _rigidbody2.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody2.velocity.y * -0.5f, _joystick.Vertical * _moveSpeed);
        //_rigidbody2.velocity = new Vector3(0.5f, _rigidbody2.velocity.y * -0.5f, 0.5f);
        //Debug.Log(_rigidbody2.velocity.x.ToString() + "/" + _rigidbody2.velocity.z.ToString());
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody2.velocity);
        }

    }
}

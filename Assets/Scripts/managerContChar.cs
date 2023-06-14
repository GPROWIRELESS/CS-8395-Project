using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerContChar : MonoBehaviour
{
    //component
    private CharacterController mycharacterController;
    private Manager_Joystick _mngrJoyStick;

    //rotation
    private Transform meshPlayer;
    //move
    private float inputX;
    private float inputZ;
    private Vector3 v_movement;
    private float moveSpeed;
    private float gravity;
    public GameObject mytank;
    private bool symbol = false;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.005f;
        gravity = 0.5f;
        GameObject tempPlayer;
        if (mytank != null)
        {
            tempPlayer = mytank;
        }
        else
        {
            tempPlayer = GameObject.FindGameObjectWithTag("Tank");
            //tempPlayer = GameObject.Find("Tankrotation");
        }
        meshPlayer = tempPlayer.transform.GetChild(0);
        mycharacterController = tempPlayer.GetComponent<CharacterController>();
        _mngrJoyStick = GameObject.Find("ImgJoystickBg").GetComponent<Manager_Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        if(symbol == false)
        {
            //print("update_symbol_false");
            GameObject tempPlayer;
            tempPlayer = GameObject.FindGameObjectWithTag("Tank");
            meshPlayer = tempPlayer.transform.GetChild(0);
            mycharacterController = tempPlayer.GetComponent<CharacterController>();
            _mngrJoyStick = GameObject.Find("ImgJoystickBg").GetComponent<Manager_Joystick>();
            symbol = true;
        }
        //inputX = Input.GetAxis("Horizontal");
        //inputZ = Input.GetAxis("Vertical");
        inputX = _mngrJoyStick.inputHorizontal();
        inputZ = _mngrJoyStick.inputVertical();
    }

    private void FixedUpdate()
    {
        // gravity
        if (mycharacterController.isGrounded)
        {
            v_movement.y = 0f;
        }
        else
        {
            v_movement.y -= gravity * Time.deltaTime;
        }
        v_movement = new Vector3(inputX * moveSpeed, v_movement.y, inputZ * moveSpeed);
        mycharacterController.Move(v_movement);

        if (inputX != 0 || inputZ != 0)
        {
            Vector3 lookDir = new Vector3(v_movement.x, 0, v_movement.z);
            meshPlayer.rotation = Quaternion.LookRotation(lookDir);
        }

    }
}
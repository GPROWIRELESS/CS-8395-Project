using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class My_health_point : MonoBehaviour
{
    public float current_hp = 100;
    public Text HP;
    private int HP_num;
    // Start is called before the first frame update
    void Start()
    {
        current_hp = 100;
        HP.text = "HP:" + current_hp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void minus_hp()
    {
        current_hp -= 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tank")
        {
            //Debug.Log("collision with tank");
        }
        else if (collision.gameObject.tag == "myplane")
        {
            //Debug.Log("collision with myplane");
        }
        else if (collision.gameObject.tag == "coke")
        {
            //Debug.Log("collision with coke");
        }
        else if (collision.gameObject.tag == "tank_withnew_jsk")
        {
            //Debug.Log("collision with tank_withnew_jsk");
        }
        else if (collision.gameObject.tag == "tree")
        {
            //Debug.Log("collision with tree");
        }
        else if (collision.gameObject.tag == "stone")
        {
            //Debug.Log("collision with stone");
        }
        else if (collision.gameObject.tag == "target")
        {
            //Debug.Log("collision with target");
        }
        else if (collision.gameObject.tag == "box")
        {
            //Debug.Log("collision with box");
        }
        else if (collision.gameObject.tag == "Tank_withnew_jsk")
        {
            //Debug.Log("collision with Tank_withnew_jsk");
        }
        else
        {
            minus_hp();
            Debug.Log("hp: "+ current_hp);
            HP.text = "HP:" + current_hp;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory_coke : MonoBehaviour
{
    [SerializeField] AudioSource destory_source;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "tank")
        {
            //GameObject.FindGameObjectWithTag
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
            Debug.Log(collision.gameObject.name);
            Destroy(this.gameObject);
            destory_source.Play();
        }


    }
}

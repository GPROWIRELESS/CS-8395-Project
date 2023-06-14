using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting_script : MonoBehaviour
{
    public GameObject explosion;
    public GameObject gameCamera;
    public GameObject coke;
    public GameObject minicoke;
    public GameObject findchild_parent;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //print("parent:" + findchild_parent.transform.parent.name.ToString());
    }

    public void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(gameCamera.transform.position, gameCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "Colabottle")
            {
                Destroy(hit.transform.gameObject);
                GameObject go1 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.name == "Colacan")
            {
                Destroy(hit.transform.gameObject);
                GameObject go1 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.name == "Car Prefab")
            {
                Destroy(hit.transform.gameObject);
                GameObject go2 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.name == "M4A3E2_2")
            {
                Destroy(hit.transform.gameObject);
                GameObject go3 = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.name == "TestPlane")
            {
                Instantiate(coke, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.name == "Imagetracking_Colacan")
            {
                Destroy(hit.transform.gameObject);
            }
            if (hit.transform.name == "Imagetracking_plane")
            {
                Instantiate(minicoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.name == "Plane_with_character")
            {
                Instantiate(minicoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.name == "Tank_test_joystick")
            {
                //Instantiate(minicoke, hit.point, Quaternion.LookRotation(hit.normal));
                print("hit tank 'Tank_test_joystick'");
            }
            if (hit.transform.name == "Tankrotation")
            {
                //Instantiate(minicoke, hit.point, Quaternion.LookRotation(hit.normal));
                print("hit tank 'Tankrotation'");
            }
            if (hit.transform.name == "Plane_with_character")
            {
                Instantiate(coke, hit.point, Quaternion.LookRotation(hit.normal));
            }
            if (hit.transform.tag == "coke")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }

    public void add()
    {
        RaycastHit hit;
        if (Physics.Raycast(gameCamera.transform.position, gameCamera.transform.forward, out hit))
        {
            GameObject added_coke = Instantiate(minicoke, hit.point, Quaternion.LookRotation(hit.normal));
            //Debug.Log("---hit point---"+"x:"+hit.point.x.ToString()+ "y:" + hit.point.y.ToString() + "z:" + hit.point.z.ToString());
            
            if(GameObject.FindGameObjectWithTag("myplane") != null)
            {
                GameObject father_plane = GameObject.FindGameObjectWithTag("myplane");
                print("find myplane");
            }
            else
            {
                print("failed to find myplane");
            }
            /*
            added_coke.transform.parent = father_plane.transform;
            Debug.Log("added_coke.transform.parent: " + added_coke.transform.parent.name.ToString());
            */
        }
    }
}

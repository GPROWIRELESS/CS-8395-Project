using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTank : MonoBehaviour
{
    public GameObject myTank;
    private Vector3 tankposition, tankscale;
    // Start is called before the first frame update
    void Start()
    {
        
        myTank = GameObject.Find("Tankrotation");
        if (GameObject.Find("Plane_with_character") != null)
        {
            //myTank.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
            tankposition = GameObject.Find("Plane_with_character").transform.position;
            tankposition.y += 0.3f;
            //Instantiate(myTank, tankposition, Quaternion.identity);
            myTank.transform.position = tankposition;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Plane_with_character") != null)
        {
            
            if(myTank.transform.position.y < -0.03f)
            {
                print("find");
                //myTank.transform.position = tankposition;
            }
        }
    }
}

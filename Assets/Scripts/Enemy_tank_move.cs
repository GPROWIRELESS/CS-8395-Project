using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class Enemy_tank_move : MonoBehaviour
{
    public float timer;
    public int _newtarget;
    public Vector3 Target;
    //public NavMeshAgent _mynav;
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = Target;
        transform.position = Vector3.Lerp(a, b, _moveSpeed);

        //Target.y = transform.position.y;
        //transform.LookAt(Target);

        Vector3 direction = Target - transform.position;
        Quaternion toRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, _rotateSpeed * Time.time);

        timer += Time.deltaTime;

        if(timer >= _newtarget)
        {
            newTarget();
            timer = 0;
        }
    }

    void newTarget()
    {
        float xpos = gameObject.transform.position.x;
        float zpos = gameObject.transform.position.z;

        float new_xpos = xpos + Random.Range(-2f, 2f);
        float new_zpos = zpos + Random.Range(-2f, 2f);
        if(new_xpos > 4f)
        {
            new_xpos = 4f;
        }
        if (new_zpos > 4f)
        {
            new_zpos = 4f;
        }
        if (new_xpos < -4f)
        {
            new_xpos = -4f;
        }
        if (new_zpos < -4f)
        {
            new_zpos = -4f;
        }
        Target = new Vector3(new_xpos, gameObject.transform.position.y, new_zpos);

        
    }
}

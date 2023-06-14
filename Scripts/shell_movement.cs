using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell_movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _shellLifetime =7f;
    private void Start()
    {
        StartCoroutine(destory_shell());
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject == null)
        {
            Debug.Log("shell hit nothing");
        }
        else
        {
            Debug.Log("shell hit something");
        }
    }

    void Update()
    {
        if( _speed == 0 )
        {
            _speed = 0.01f;
        }
        transform.position += transform.forward * Time.deltaTime * _speed;
    }

    IEnumerator destory_shell()
    {
        yield return new WaitForSeconds(_shellLifetime);
        Destroy(this.gameObject);
    }
}

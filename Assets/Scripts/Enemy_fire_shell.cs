using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_fire_shell : MonoBehaviour
{
    [SerializeField] private GameObject _shell;
    [SerializeField] private Transform _shellposition;
    [SerializeField] private AudioSource _shellsound;
    [SerializeField] private GameObject _shellsffect;
    [SerializeField] private My_health_point enemy_mhp;
    private float _firerate = 1f;

    // Update is called once per frame
    public void shoot_shell()
    {
        _shellsound.Play();
        _shell.transform.localScale = new Vector3(0.01f, 0.01f, 0.02f);
        Instantiate(_shell, _shellposition.position, _shellposition.rotation);
        _shellsffect.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        Instantiate(_shellsffect, _shellposition.position, _shellposition.rotation);
        enemy_mhp.current_hp += 1;
    }

    private void FixedUpdate()
    {   
        if (_firerate%40 == 0)
        {
            shoot_shell();
            _firerate += 1f;
        }
        else
        {
            _firerate += 1f;
        }
            
    }

}
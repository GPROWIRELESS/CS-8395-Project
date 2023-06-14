using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire_Shell : MonoBehaviour
{
    [SerializeField] private GameObject _shell;
    [SerializeField] private Transform _shellposition;
    [SerializeField] private AudioSource _shellsound;
    [SerializeField] private GameObject _shellsffect;
    [SerializeField] private My_health_point mhp;
    public void shoot_shell()
    {
        
        _shellsound.Play();
        _shell.transform.localScale = new Vector3(0.01f, 0.01f, 0.02f);
        Instantiate(_shell, _shellposition.position, _shellposition.rotation);
        _shellsffect.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        Instantiate(_shellsffect, _shellposition.position, _shellposition.rotation);
        mhp.current_hp += 1;
    }
}

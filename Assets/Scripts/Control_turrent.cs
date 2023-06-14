using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_turrent : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _turrent;
    // Update is called once per frame
    void Update()
    {
        LookAtTarget(_target);
    }

    private void LookAtTarget(Transform target)
    {
        Vector3 clampedTarget = target.position;
        clampedTarget.y = _turrent.transform.position.y;
        _turrent.LookAt(clampedTarget);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCMoving : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _target;


    private void Update()
    {
        if (_target != null)
        {
            transform.LookAt(_target);
            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        }      
    }

    public void SetTarget(Transform target)
    {
        _target= target;
    }
}

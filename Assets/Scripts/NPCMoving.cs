using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCMoving : MonoBehaviour
{
    private Transform _target;
    [SerializeField] private float _speed;

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("targetPoint").GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        transform.LookAt(_target);
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}

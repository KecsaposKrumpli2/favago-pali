using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class darazsMove : MonoBehaviour
{
    [SerializeField] float _speed = 2f;
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}

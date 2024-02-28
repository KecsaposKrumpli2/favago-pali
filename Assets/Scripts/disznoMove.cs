using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disznoMove : MonoBehaviour
{
    [SerializeField] float _speed = 2.5f;
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}

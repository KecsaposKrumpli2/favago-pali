using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BogarSpawner : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject bogar;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newbogar = Instantiate(bogar);
        newbogar.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newbogar = Instantiate (bogar);
            newbogar.transform.position = transform.position + new Vector3(0, Random.Range(height - height, height), 0);
            Destroy(newbogar, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}

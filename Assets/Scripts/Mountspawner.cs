using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountspawner : MonoBehaviour
{
    private float maxTime = 1;
    private float timer = 0;
    private float height;
    public GameObject pipe;

    void Start()
    {
        height = Random.Range(1, 2);
        maxTime = Random.Range(2,3.5f);
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }
    
    void Update()
    {
        if(timer > maxTime)
        {
            height = Random.Range(1.5f, 2);
            maxTime = Random.Range(3, 4.5f);
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
        
    }
}

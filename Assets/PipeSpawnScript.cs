using System;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    public void spawnPipe()
    {
        float pipeLowHeight= transform.position.y - heightOffset;
        float pipeHighHeight = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(pipeLowHeight, pipeHighHeight), 0), transform.rotation);
    }
}

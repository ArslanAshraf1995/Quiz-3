using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject brickPrefab;
    private float startInvoke = 2;
    private float intervalRate = 2;
    private Vector3 spawnPos;
    private float randomPosZ;
    private float randomPosX;
    private float yPos = 0.14f;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn", startInvoke, intervalRate);
    }

    // Update is called once per frame
    void Update()
    {
        randomPosZ = Random.Range(-10, 11);
        randomPosX = Random.Range(-2, 4);
        spawnPos = new Vector3(randomPosX, yPos, randomPosZ);
    }
    private void Spawn()
    {
        
        
            Instantiate(brickPrefab, spawnPos, brickPrefab.transform.rotation);
        
    }
}

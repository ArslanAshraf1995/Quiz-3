using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    private float randomPosZ;
    private float randomPosX;
    private float yPos = 0.14f;
    private Vector3 vectorPos;
    // Start is called before the first frame update
    void Start()
	{
		
    }

    // Update is called once per frame
    void Update()
    {
        randomPosZ = Random.Range(-10, 11);
        randomPosX = Random.Range(-2, 4);
        vectorPos = new Vector3(randomPosX, yPos, randomPosZ);
        transform.position = vectorPos;
    }
}

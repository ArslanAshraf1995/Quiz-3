using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 0.1f;
    float currentRotation;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
     
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation = transform.eulerAngles.y;
        Debug.Log(currentRotation);
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRb.AddForce(Vector3.right * speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector3.left * speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(Vector3.back * speed, ForceMode.Impulse);
        }
    }
    
}

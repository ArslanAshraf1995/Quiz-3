using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagList : MonoBehaviour
{
    public Renderer render;
    public Color brickColor;
    private PlayerController playerPos;
    public Vector3 offSet;
    public Vector3 upward;
    private bool isTrigger;
    private static int counter = 0;
    public Vector3 pathFill;
    // Start is called before the first frame update
    void Start()
    {
        brickColor = render.material.color;
        playerPos = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        offSet = new Vector3(.3f, counter, 0);
        
        if (isTrigger == true)
		{
            transform.position = playerPos.transform.position + offSet;
        }
        Debug.Log(counter);
       
    }
	private void OnTriggerEnter(Collider other)
	{
		
        if(other.tag == "Green" && brickColor == Color.green)
		{
            isTrigger = true;
            counter++;
		}
        if (other.tag == "Blue" && brickColor == Color.blue)
        {
            Destroy(gameObject);
        }
        if (other.tag == "Yellow" && brickColor == Color.yellow)
        {
            Destroy(gameObject);
        }
        if (other.tag == "Red" && brickColor == Color.red)
        {
            Destroy(gameObject);
        }
    }
}

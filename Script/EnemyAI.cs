using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform brick;
    private Rigidbody enemyRb;
    public Vector3 position;
    public float speed = 0.08f;
    // Start is called before the first frame update
    void Start()
    {

        enemyRb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        position = (brick.position - transform.position).normalized;
        enemyRb.AddForce(position * speed);
    }
	private void FixedUpdate()
	{
        
    }


}
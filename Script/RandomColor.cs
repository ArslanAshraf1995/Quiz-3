using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    //public Material yourMaterial;
   //public Color material;
    public Renderer render;
    private float randomColor;
    // Start is called before the first frame update
    void Start()
    {

        // yourMaterial = Resources.Load("_Color", typeof(Material)) as Material;
        randomColor= Random.Range(0, 8);
        
        if (randomColor >= 0 && randomColor <= 2)
        {
            render.material.color = Color.blue;
        }
        if (randomColor > 2 && randomColor <= 4)
        {
            render.material.color = Color.green;
        }
        if (randomColor > 4 && randomColor <= 6)
        {
            render.material.color = Color.yellow;
        }
        if (randomColor > 6 && randomColor <= 8)
        {
            render.material.color = Color.red;
        }

    }

    // Update is called once per frame
    void Update()
    {
		
    }
}

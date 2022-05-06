using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpfix : MonoBehaviour
{
    
    public float speed=5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown ("space"))&&(GetComponent<Rigidbody2D>().velocity.y==0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
    }
}

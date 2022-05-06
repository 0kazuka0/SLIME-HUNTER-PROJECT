using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 2f;
    float velx;
    float vely;
    bool facingright = true;
    Animator animator;
    Rigidbody2D rb2d;
    bool isrunning = false;


    public GameObject bulletr,bulletl;
    Vector2 bulletpos;
    public float firerate = 0.5f;
    float nextfire = 0.0f;
  

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        
    }
    private void Update()
    {
        velx = Input.GetAxisRaw("Horizontal");
        vely = rb2d.velocity.y;
        rb2d.velocity = new Vector2(velx * speed, vely);
        if(velx!=0)
        {
            isrunning = true;
        }
        else 
        {
            isrunning = false;
        }
    
        animator.SetBool("isrunning", isrunning);
        if (Input.GetButtonDown("Fire1") && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            shoot();
        }
    }
    private void LateUpdate()
    {
        Vector3 localScale = transform.localScale;
        if(velx>0)
        {
            facingright = true;
        }
        else if(velx<0)
        {
            facingright = false;
        }
        if (((facingright) && (localScale.x < 0)) || ((!facingright) && (localScale.x > 0))) 
        {
            localScale.x *= -1;
        }
        transform.localScale = localScale;
    }
    void shoot()
    {
        bulletpos = transform.position;
        if (facingright)
        {
            bulletpos += new Vector2(1f, 0.26f);
            Instantiate(bulletr, bulletpos, Quaternion.identity);
        }
        else
        {
            bulletpos += new Vector2(-1f, 0.26f);
            Instantiate(bulletl, bulletpos, Quaternion.identity);
        }
    }
   

}


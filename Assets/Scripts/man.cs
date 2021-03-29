using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man : MonoBehaviour
{
    public float Speed;
    float Ver, Hor;

    //public float speed;
    //private Rigidbody2D rb;
    //private Vector2 moveVelocity;

    private void Aweke()
    {
       
    }
    private void Run()
    {
     
    }

    
    void Start()
    {
    //    rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        Ver = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        Hor = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;

        transform.Translate(new Vector3(Hor, 0, Ver));
    //    Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    //    moveVelocity = moveInput.normalized * speed;
        
    }
    void FixedUpdate()
    {
    //    rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}

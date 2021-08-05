using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This code is based off the traditional roll-a-ball tutorial, but also learning the jumping physics based on this helpful YouTube video.
//https://www.youtube.com/watch?v=vdOFUFMiPDU


public class TestControls : MonoBehaviour
{
    public float moveSpeed = 4.0f;
    public float jumpforce = 4.0f;
    private Rigidbody rb;
    public SphereCollider col;
    public LayerMask ground;
    
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<SphereCollider>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }

    public void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");


        Vector3 Movement = new Vector3(horizontalMove, 0, verticalMove);

        rb.AddForce(Movement * moveSpeed);

    }
    private bool isGrounded()
    {
        
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * 0.9f, ground);
    }
}

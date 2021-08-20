using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This code is based off the traditional roll-a-ball tutorial, but also learning the jumping physics based on this helpful YouTube video.
//https://www.youtube.com/watch?v=vdOFUFMiPDU


public class TestControls : MonoBehaviour
{
    public float moveSpeed = 4.0f;
    public float jumpforce = 4.0f;
    private Rigidbody rb;
    public SphereCollider col;
    public LayerMask ground;
    public AudioClip JumpEffect;
    protected AudioSource source;
    public int BoxesHit = 0;
    public Text BoxesHitText;
    
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<SphereCollider>();
        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            PlaySound();
        }
        Debug.Log(BoxesHit);
        TextUpdateTest();
    }

    public void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(horizontalMove, 0, verticalMove);
        rb.AddForce(Movement * moveSpeed);

        if (gameObject.CompareTag("Box"))
        {
            BoxesHit++;
            BoxesHitText.text = BoxesHit.ToString();
        }
    }

    private bool isGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * 0.9f, ground);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            BoxesHit++;
        }
    }

    public void PlaySound()
    {
        source.PlayOneShot(JumpEffect);
    }

    void TextUpdateTest()
    {
        BoxesHitText.text = "Boxes Count" + BoxesHit;
    }
}

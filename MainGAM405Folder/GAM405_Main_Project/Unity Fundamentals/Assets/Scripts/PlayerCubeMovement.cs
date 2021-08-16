using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeMovement : MonoBehaviour
{
    public enum MovementType
    {
        ByTransformPosition,
        ByAddForce,
        ByMovePosition,
        ByVelocity
    }

    public enum RotationType
    {
        ByTransformRotation,
        ByAddTorque,
        ByMoveRotation
    }

    public MovementType moveType = MovementType.ByTransformPosition;
    public RotationType rotateType = RotationType.ByTransformRotation;

    protected float horizontalInput, verticalInput;
    public float moveSpeed = 5.0f;
    public float moveForce = 3.0f;
    public float moveVelocity = 6.0f;

    public float RotationSpeed = 10.0f;
    public float RotationForce = 5.0f;

    protected Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // Use Update() for Inputs
    void Update()
    {
        //Retrieve Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moving by transform position?
        if (moveType == MovementType.ByTransformPosition)
        {
            transform.position += new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime;
        }

        //Moving by transform rotation?
        if (rotateType == RotationType.ByTransformRotation)
        {
            transform.Rotate(new Vector3(0, 0, horizontalInput) * RotationSpeed * Time.deltaTime);
        }
    }

    //Interactions with physics must be handled in the void FixedUpdate() function.
    //When doing physics, use FixedUpdate() as it handles.
    void FixedUpdate()
    {
        if (moveType == MovementType.ByAddForce)
        {
            //rb.AddForce(transform.up * verticalInput * moveForce);
            rb.AddForce(new Vector3(horizontalInput, verticalInput, 0) * moveForce);
        }
        else if (moveType == MovementType.ByMovePosition)
        {
            //Calculates the new position, behaves exactly the same as above.
            Vector3 newPosition = transform.position;
            //newPosition += transform.up * verticalInput * moveSpeed * Time.deltaTime;
            newPosition += new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime;
            rb.MovePosition(newPosition);
        }
        else if (moveType == MovementType.ByVelocity)
        {
            //rb.velocity = transform.up * verticalInput * moveSpeed;
            rb.velocity = new Vector3(horizontalInput, verticalInput, 0) * moveSpeed;
        }

        //Handle the different physics methods for rotation
        if (rotateType == RotationType.ByAddTorque)
        {
            rb.AddTorque(new Vector3(0, 0, horizontalInput) * RotationForce);
        }
        else if (rotateType == RotationType.ByMoveRotation)
        {
            rb.MoveRotation(transform.rotation * Quaternion.Euler(0, 0, horizontalInput * RotationSpeed * Time.deltaTime));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3 (0, verticalInput, 0) * moveSpeed * Time.deltaTime;
        }
    }
}

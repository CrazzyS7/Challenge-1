using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float mSpeed = 10.0f;
    public float mRotationSpeed = 30.0f;
    public float mVerticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        mVerticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * mSpeed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, mRotationSpeed * Time.deltaTime * mVerticalInput);
    }
}

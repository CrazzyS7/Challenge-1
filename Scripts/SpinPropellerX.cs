using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public Vector3 mSpinPropeller = new Vector3(0, 0, 1);
    public float mRotationSpeed = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(mSpinPropeller, mRotationSpeed * Time.deltaTime);
    }
}

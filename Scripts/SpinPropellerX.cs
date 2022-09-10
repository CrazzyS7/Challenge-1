using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private Vector3 mSpinPropeller = new Vector3(0, 0, 1);
    private float mRotationSpeed = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the plane propeller 
        transform.Rotate(mSpinPropeller, mRotationSpeed * Time.deltaTime);
    }
}

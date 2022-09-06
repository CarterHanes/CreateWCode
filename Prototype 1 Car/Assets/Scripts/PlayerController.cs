using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
  
{
    public float speed = 20.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame updateg
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        //Move the Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input
    }
}

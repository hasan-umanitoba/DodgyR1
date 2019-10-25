using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//player controller inherits from monobehaviour
public class PlayerController : MonoBehaviour
{
    public Rigidbody rigidBody;

    private float increase = 0.0004f;

    public float speed = 0.0f;
    private float max = .7f;

    public float turnSpeed = 0.4f;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // * Time.deltaTime* speed
        horizontalInput = Input.GetAxis("Horizontal"); // getting input from left or right keys

        // moving vehicld forward
        speed += increase;

        transform.Translate(Vector3.forward * speed);
        transform.Translate(Vector3.right * horizontalInput * turnSpeed);

        if (speed > max)
        {
            speed = max;

        }




        if (rigidBody.position.y < -1f)  // if the tank goes outside track game restarts
        {
            FindObjectOfType<GameManager>().EndGame();

        }


        //we have addes rigid body to add weight and physics
    }
}

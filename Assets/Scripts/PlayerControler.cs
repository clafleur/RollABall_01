using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {
    public float speed = 10;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertial = Input.GetAxis("Vertical");

        //get the movement of the player
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertial);

        //add a force to the rigidbody
        rb.AddForce(movement * speed);
    }
}

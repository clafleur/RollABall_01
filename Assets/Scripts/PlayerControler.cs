using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerControler : MonoBehaviour {
    public float speed = 10;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 16)
        {
            winText.text = "You Win!";
        }
    }
}

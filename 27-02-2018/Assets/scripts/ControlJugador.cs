using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    private int count;
    public Text countText;
    public Text winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "Score: " + count.ToString();
        winText.text = "";
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pick Up")) { 
            other.gameObject.SetActive(false);
            count = count + 1;
            countText.text = "Score: " + count.ToString();

            if (count > 7)
            {
                winText.text = "You win!";
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed; // shows up in inspector
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count = 0;

	// Use this for initialization
	void Start()
    {
		rb = GetComponent<Rigidbody>();

        SetCountText();
        winText.text = "";
	}
	
	// Update is called once per frame (before rendering)
    // This is where most of our game code will go
	void Update()
    {
		
	}

    // FixedUpdate is called just before performing any physics calculations
    // This is where our physics code will go
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {    
        if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
            count++;

            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12) {
            winText.text = "You Win!";
        }
    }
}

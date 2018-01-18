using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PudgyMove : MonoBehaviour
{
    Camera mainCamera;
    Vector3 jump;
    float jumpForce = 2.0f;

    bool isGrounded;
    Rigidbody2D rigidB;

	// Use this for initialization
	void Start ()
    {
        // Can set the starting location
        // and other related starting stuff
        Debug.Log("Budgie has started");
        mainCamera = Camera.main;
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        rigidB = GetComponent<Rigidbody2D>();
	}
	
    //void OnCollisionStay()
    //{
    //    isGrounded = true;
    //}
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space is pressed");
            rigidB.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Force has been applied");
            Debug.Log("Budgie's Position is: " + this.transform.position.x + ", " + this.transform.position.y);
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W is pressed");
            rigidB.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Force has been applied");
            Debug.Log("Budgie's Position is: " + this.transform.position.x + ", " + this.transform.position.y);
            isGrounded = false;
        }

        if (Input.anyKeyDown)
        {
            Debug.Log("Any Key was pressed");
            rigidB.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Force has been applied");
            Debug.Log("Budgie's Position is: " + this.transform.position.x + ", " + this.transform.position.y);
            isGrounded = false;
        }

    }
}

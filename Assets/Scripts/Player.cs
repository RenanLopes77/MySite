using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D rb2D;
    private bool isGrounded;
    public float jumpForce;
    public float moveSpeed;

    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update() {
        Move();
        Jump();
    }

    void Move() {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump() {
        if (isGrounded && Input.GetButtonDown("Jump")) {
            rb2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    public void SetIsGrounded(bool isGrounded) {
        this.isGrounded = isGrounded;
    }
}
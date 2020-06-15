using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
    public Player player;

    private void OnTriggerEnter2D(Collider2D other) {
        SetIsGrounded(other.tag, true);
    }

    private void OnTriggerExit2D(Collider2D other) {
        SetIsGrounded(other.tag, false);
    }

    private void SetIsGrounded(string tag, bool isGrounded) {
        string groundTag = "Ground";
        if (tag == groundTag) {
            player.SetIsGrounded(true);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSttMach : MonoBehaviour {
    private Animator animator;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        animator.SetBool("Running", (rb.velocity.x != 0 || rb.velocity.y != 0) ? true : false);
        animator.SetFloat("Horizontal", rb.velocity.x);
        animator.SetFloat("Vertical", rb.velocity.y);
    }
}

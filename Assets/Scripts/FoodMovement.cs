using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject player;

    private Vector3 vectorToPlayerInv;
    private bool isRandom = false;

    public float speed = 9;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        vectorToPlayerInv = this.transform.position - player.transform.position;
        if (vectorToPlayerInv.magnitude < 3) {
            rb.velocity = vectorToPlayerInv.normalized * speed;
            isRandom = false;
        }
        else if (!isRandom) StartCoroutine(MoveRandom());
    }

    IEnumerator MoveRandom() {
        isRandom = true;
        if (Random.value < 0.5f) rb.velocity = Vector2.zero;
        else rb.velocity = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized * speed;
        yield return new WaitForSeconds(Random.Range(1.0f, 6.0f));
        isRandom = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // The RayCasting Part uses codes from this website: https://discussions.unity.com/t/how-do-i-check-if-my-rigidbody-player-is-grounded/33250
    private Rigidbody2D _rb;
    private float _disToGround;
    public float moveForce;
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
        _disToGround = this.GetComponent<CircleCollider2D>().bounds.extents.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(moveForce * Vector2.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(moveForce * Vector2.right);
        }
        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && Physics2D.Raycast(transform.position, Vector2.down, _disToGround + 0.1f))
        {
            _rb.AddForce(moveForce * Vector2.up * 50.0f);
        }
    }
}

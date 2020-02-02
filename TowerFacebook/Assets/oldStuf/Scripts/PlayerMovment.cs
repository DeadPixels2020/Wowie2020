using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D myRb;
    private float horizonalAxis;
    private float verticalAxis;

    private void Awake() {
        myRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizonalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
    }

    private void FixedUpdate() {
        Vector2 direction = new Vector2(horizonalAxis,verticalAxis).normalized;

        myRb.velocity = direction * speed;

    }
}

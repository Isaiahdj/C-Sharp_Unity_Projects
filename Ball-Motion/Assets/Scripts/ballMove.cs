
using UnityEngine;
using System.Collections;

public class ballMove : MonoBehaviour
{

    public float speed;
    private Rigidbody rigb;
    void Start()
    {
        rigb = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVert);
        rigb.AddForce(movement * speed);
    }
}

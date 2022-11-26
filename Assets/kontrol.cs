using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    float x, z;
    Vector3 move = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        move = new Vector3(x, 0, z) * Time.deltaTime * speed;
        rb.MovePosition(transform.position + transform.TransformDirection(move));
    }
}

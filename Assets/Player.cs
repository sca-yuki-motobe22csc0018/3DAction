using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count=0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (count < 2)
            {
                rb.velocity = Vector3.up * 20;
                count += 1;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
           transform.position+=transform.forward*0.0075f;;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * 0.0075f; ;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0,-0.1f,0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, 0.1f, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Plane")
        {
            count=0;
        }
    }
}

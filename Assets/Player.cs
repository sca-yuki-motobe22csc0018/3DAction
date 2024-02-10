using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private int count;
    public AudioSource a;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count=0;
        a=GetComponent<AudioSource>();
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
                a.Play();
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
           transform.position+=transform.forward*0.2f;;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * 0.2f; ;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0,-2.5f,0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, 2.5f, 0);
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

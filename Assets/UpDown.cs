using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public float MaxUp;
    public float MaxDown;
    bool up;
    // Start is called before the first frame update
    void Start()
    {
        up=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > MaxUp)
        {
            up = false;
        }
        if (transform.position.y < MaxDown)
        {
            up = true;
        }
        if (up==true)
        {
            if (transform.position.y < MaxUp)
            {
                transform.position += new Vector3(0, 0.01f, 0);
            }
        }else if (transform.position.y > MaxDown)
        {
            transform.position += new Vector3(0, -1f, 0);
        }
    }
}

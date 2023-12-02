using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position= Player.transform.position + new Vector3(0,1,-10);

        Vector3 playerPos = Player.transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(-0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(0.05f, 0, 0);
        }
        //transform.RotateAround(playerPos,Vector3.up,1);
    }
}

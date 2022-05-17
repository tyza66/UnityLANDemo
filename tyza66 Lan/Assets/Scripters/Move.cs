using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    public float speed = 10.0f;
    private Transform tm;
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tm.Translate(new Vector2(0, Time.deltaTime * speed));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            tm.Translate(new Vector2(0, -Time.deltaTime * speed));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            tm.Translate(new Vector2(-Time.deltaTime * speed, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            tm.Translate(new Vector2(Time.deltaTime * speed, 0));
        }
        else
        {
        }
    }
}

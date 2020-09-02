using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoubelleController : MonoBehaviour
{
    public Vector2 movement;
    public float moveSpeed = 10;
    //public Bin poubelle;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.left*Time.deltaTime);
        transform.Translate(movement * Time.deltaTime);
    }

    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
        print("moving");
    }

    void OnGrab()
    {
        print("Grab!");
    }
}

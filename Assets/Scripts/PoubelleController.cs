using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoubelleController : MonoBehaviour
{
    public Vector2 movement;
    public float moveSpeed = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoubelleController : MonoBehaviour
{
    public Vector2 movement;
    public float moveSpeed = 10;
<<<<<<< HEAD
    //public Bin poubelle;
=======
    public int score;
>>>>>>> 76cdffb95e8ba0aea5ef16ceef77efe1d7828e39

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        //transform.Translate(Vector2.left*Time.deltaTime);
        transform.Translate(movement * Time.deltaTime);
=======
        
        
>>>>>>> 76cdffb95e8ba0aea5ef16ceef77efe1d7828e39
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

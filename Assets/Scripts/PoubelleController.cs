using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoubelleController : MonoBehaviour
{
    public Vector2 movement;
    public Vector2 position;
    public int moveSpeed = 1;
    //public Bin poubelle;
    public int score;
    public int level;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        score = 0;
        level = 0;
       // poubelle = new Bin();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.left*Time.deltaTime);
        position.x += movement.x * Time.deltaTime * moveSpeed;
        position.y += movement.y * Time.deltaTime * moveSpeed;
        transform.position = new Vector2(position.x, position.y);
        ModifScore();
        ChangeLevel();
        print(level);
        //transform.Translate(movement * Time.deltaTime);
        //transform.Tr
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

    void ModifScore()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton4) 
            && score != 0)
        {
            score--;
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton3)){
            score++;
        }
    }

    void ChangeLevel()
    {
        if (score <10)
        {
            level = 0;
        }
        else if (score >= 10 && score < 20)
        {
            level = 1;
        }
        else
        {
            level = 2;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bin : MonoBehaviour
{
    public Vector2 position;
    public Vector2 movement;
    // public LevelBin level = null;
    public int level;
    public int score;
    public GameObject sprite;
    

    // Start is called before the first frame update
    void Start()
    {
        level = 2;
        score = 0;
        //position = transform.position;
        //level = new LevelBin(this);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeLevel();
        //print(level);
        /*if (level == 0) Move(5);
        if (level == 1) Move(3);
        if (level == 2) Move(1);*/
       // level.LevelUpdate();
    }

    public void ChangeLevel()
    {
       /* if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            if(level > 0)
            {
                level--;
            }
        }else if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            if(level < 2)
            {
                level++;
            }
        }*/
    }

    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
        print("moving");
    }

    public void Move(int vit)
    {
        transform.Translate(movement * Time.deltaTime * vit);
        
    }

}

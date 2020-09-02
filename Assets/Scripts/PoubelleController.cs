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
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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
        //print(level);
        //transform.Translate(movement * Time.deltaTime);
        //transform.Tr
        
    }

    private void FixedUpdate() {
        ResetAnimBools();

        if(movement.x > 0.1f ){// SI A DROITE

            if(movement.y > 0.1f){//SI EN HAUT
                if(movement.y < 0.3f){//SI DIAGO
                      anim.SetBool("TopRight", true);
                }
            }else if(movement.y < 0.1f){//SI EN BAS
                if(movement.y > 0.3f){//SI DIAGO
                      anim.SetBool("FrontRight", true);
                }
            }else{// SI FULL DROITE
                anim.SetBool("Right", true);
            }

            

        }else if(movement.x < 0.1f){//SI A GAUCHE

            if(movement.y > 0.1f){//SI EN HAUT
                if(movement.y < 0.3f){//SI DIAGO
                      anim.SetBool("TopLeft", true);
                }
            }else if(movement.y < 0.1f){//SI EN BAS
                if(movement.y > 0.3f){//SI DIAGO
                      anim.SetBool("FrontLeft", true);
                }
            }else{// SI FULL GAUCHE
                anim.SetBool("Left", true);
            }



        }else{//SI TOP OU BAS
                if(movement.y >0){//SI EN HAUT
            anim.SetBool("Top", true);
                }else{//SI EN BAS
            anim.SetBool("Front", true);
                }
        }
    }

    void ResetAnimBools(){
                anim.SetBool("Top", false);
                anim.SetBool("Front", false);
                anim.SetBool("FrontLeft", false);
                anim.SetBool("TopLeft", false);
                anim.SetBool("Right", false);
                anim.SetBool("FrontRight", false);
                anim.SetBool("TopRight", false);
                anim.SetBool("Left", false);
    }


    void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
        //print("moving");
    }

    void OnGrab()
    {
        print("Grab!");
    }

    void ModifScore()
    {
        // if (Input.GetKeyDown(KeyCode.JoystickButton4) 
        //     && score != 0)
        // {
        //     score--;
        // }
        // if (Input.GetKeyDown(KeyCode.JoystickButton3)){
        //     score++;
        // }
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

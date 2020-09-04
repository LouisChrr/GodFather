using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoubelleController : MonoBehaviour
{
    public Vector2 movement;
    public Vector2 position;
    public int moveSpeed = 1;
    public int moveSpeedLevelUp = 10;
    public bool isLeveledUp = false;
    //public Bin poubelle;
    public int score;
    public int level;
    public Animator anim;

    private Rigidbody2D _rigidbody2D;

    public AudioSource moveSound;
    public AudioSource bonHuman;
    public AudioSource badHuman;
    public AudioSource banc;
    public AudioSource bush;
    public AudioSource evolve;
    public AudioSource sac;

    private void Awake() {
    anim = GetComponent<Animator>();
    _rigidbody2D = GetComponent<Rigidbody2D>();
}
    
    // Start is called before the first frame update
    void Start()
    {
        
        //position = PreGameManager.Instance.playerSpawnPos[ID - 1].position;
        score = 0;
        level = 0;
        
       // poubelle = new Bin();
    }

    // Update is called once per frame
    void Update()
    {
        if(PreGameManager.Instance.hasGameStarted == false) return;

        //transform.Translate(Vector2.left*Time.deltaTime);
        if (isLeveledUp)
        {
            _rigidbody2D.velocity = movement * moveSpeedLevelUp;

            //this.transform.localScale = new Vector3(0.5f,0.5f,1);

            //position.x += movement.x * Time.deltaTime * moveSpeedLevelUp;
           // position.y += movement.y * Time.deltaTime * moveSpeedLevelUp;
        }
        else
        {
            _rigidbody2D.velocity = movement * moveSpeed;
            //position.x += movement.x * Time.deltaTime * moveSpeed;
            //position.y += movement.y * Time.deltaTime * moveSpeed;
        }

        //transform.position = new Vector2(position.x, position.y);
        if(movement.x < 0.05f && movement.y < 0.05f && movement.x > -0.05f && movement.y > -0.05f){

             anim.SetBool("IsWalking", false);
        }else{
                anim.SetBool("IsWalking", true);
        }


        ModifScore();
        //ChangeLevel();
        //print(level);
    }

    private void FixedUpdate() {
        //ResetAnimBools();

         if(movement.x > 0.2f ){// SI A DROITE
            if(movement.y > 0.2f){//SI DIAGO EN HAUT
               

                anim.SetBool("Top", false);
                anim.SetBool("Front", false);
                anim.SetBool("FrontLeft", false);
                anim.SetBool("TopLeft", false);
                anim.SetBool("Right", false);
                anim.SetBool("FrontRight", false);
                anim.SetBool("Left", false);
 
                anim.SetBool("TopRight", true);
                
            }else if(movement.y < -0.2f){//SI DIAGO EN BAS
 
                anim.SetBool("Top", false);
                anim.SetBool("Front", false);
                anim.SetBool("FrontLeft", false);
                anim.SetBool("TopLeft", false);
                anim.SetBool("Right", false);
                anim.SetBool("TopRight", false);
                anim.SetBool("Left", false);
 
                anim.SetBool("FrontRight", true);   
                
            }else{// SI FULL DROITE
 
                anim.SetBool("Top", false);
                anim.SetBool("Front", false);
                anim.SetBool("FrontLeft", false);
                anim.SetBool("TopLeft", false);
                anim.SetBool("FrontRight", false);
                anim.SetBool("TopRight", false);
                anim.SetBool("Left", false);
 
                anim.SetBool("Right", true);
            }
 
        }else if(movement.x < -0.2f){//SI A GAUCHE
            if(movement.y > 0.2f){//SI DIAGO EN HAUT
 
                anim.SetBool("Top", false);
                anim.SetBool("Front", false);
                anim.SetBool("FrontLeft", false);
                anim.SetBool("Right", false);
                anim.SetBool("FrontRight", false);
                anim.SetBool("TopRight", false);
                anim.SetBool("Left", false);
 
                anim.SetBool("TopLeft", true);
                
            }else if(movement.y < -0.2f){//SI DIAGO EN BAS
                        
                anim.SetBool("Top", false);
                anim.SetBool("Front", false);
                anim.SetBool("TopLeft", false);
                anim.SetBool("Right", false);
                anim.SetBool("FrontRight", false);
                anim.SetBool("TopRight", false);
                anim.SetBool("Left", false);
 
                anim.SetBool("FrontLeft", true);
                
            }else{// SI FULL GAUCHE
                anim.SetBool("Top", false);
                anim.SetBool("Front", false);
                anim.SetBool("FrontLeft", false);
                anim.SetBool("TopLeft", false);
                anim.SetBool("Right", false);
                anim.SetBool("FrontRight", false);
                anim.SetBool("TopRight", false);
 
                anim.SetBool("Left", true);
            }
 
 
         }else{//SI TOP OU BAS
            if(movement.y > 0.2f) {//SI EN HAUT
           
 
                anim.SetBool("Front", false);
                anim.SetBool("FrontLeft", false);
                anim.SetBool("TopLeft", false);
                anim.SetBool("Right", false);
                anim.SetBool("FrontRight", false);
                anim.SetBool("TopRight", false);
                anim.SetBool("Left", false);
 
                anim.SetBool("Top", true);
 
            }else if (movement.y < -0.2f ) {//SI EN BAS
                anim.SetBool("Top", false);
                anim.SetBool("FrontLeft", false);
                anim.SetBool("TopLeft", false);
                anim.SetBool("Right", false);
                anim.SetBool("FrontRight", false);
                anim.SetBool("TopRight", false);
                anim.SetBool("Left", false);
 
 
                anim.SetBool("Front", true);
 
            }
            else //IDLE
            {
                anim.SetBool("Top", false);
                anim.SetBool("FrontLeft", false);
                anim.SetBool("TopLeft", false);
                anim.SetBool("Right", false);
                anim.SetBool("FrontRight", false);
                anim.SetBool("TopRight", false);
                anim.SetBool("Left", false);
 
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
        //print("Grab!");
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
        else if (score >15)
        {
            if(level == 0){
                print("level up!");
                evolve.Play();
                anim.SetBool("ISLVL2", true);
            }
            level = 1;
        }
        
    }
}

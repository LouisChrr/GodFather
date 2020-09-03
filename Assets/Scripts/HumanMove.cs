using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMove : MonoBehaviour
{
    public Vector2 position;
    public HumanSpawn spawn;
    public float humanSpeed = 1f;
    public int ori;
    public int maxRand = 10;

    public float timerRot = 5f;
    public float timerR = 0f;

    public float timeImmo = 5f;
    public float timeI = 0f;
    public Vector2 lastPos;

    public float timeStop = 2f;
    public float timeS = 0f;

    public float minMapX = -10f;
    public float maxMapX = 10f;
    public float minMapY = -10f;
    public float maxMapY = 10f;
    public Vector2 posArriv;
    private Animator anim;

    public Vector2 direction;
    public float directionFloat;
    // Start is called before the first frame update
private void Awake() {
    anim = this.GetComponent<Animator>();
}

    void Start()
    {
        position = transform.position;
        lastPos = position;
        posArriv.x = Random.Range(minMapX,maxMapX);
        posArriv.y = Random.Range(minMapY, maxMapY);
        CheckOrientation();
        //print(posArriv.x + " ; " + posArriv.y);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (isBlocked())
        {
            //stopMove();
            print("pop");
            newArriv();
            
        }

       /* if(position == posArriv)
        {
            newArriv();
        }*/
/*
        if (timerR > timerRot)
        {
            Rotation();
            timerR = 0f;
        }
        timerR += Time.deltaTime;*/
    }

private void FixedUpdate() {
        //ResetAnimBools();

         if(direction.x > 0.2f ){// SI A DROITE
            if(direction.y > 0.2f){//SI DIAGO EN HAUT
 
                anim.SetTrigger("TopRight");
                
            }else if(direction.y < -0.2f){//SI DIAGO EN BAS
 
                anim.SetTrigger("FrontRight");   
                
            }else{// SI FULL DROITE
                anim.SetTrigger("Right");
            }
 
        }else if(direction.x < -0.2f){//SI A GAUCHE
            if(direction.y > 0.2f){//SI DIAGO EN HAUT
 
                anim.SetTrigger("TopLeft");
                
            }else if(direction.y < -0.2f){//SI DIAGO EN BAS
 
                anim.SetTrigger("FrontLeft");
                
            }else{// SI FULL GAUCHE
 
                anim.SetTrigger("Left");
            }
 
 
         }else{//SI TOP OU BAS
            if(direction.y > 0.2f) {//SI EN HAUT
 
                anim.SetTrigger("Top");
 
            }else if (direction.y < -0.2f ) {//SI EN BAS
                anim.SetTrigger("Front");
            }
            else //IDLE
            {
                anim.SetTrigger("Front");
            }
        }
    }

    private void CheckOrientation(){
          //direction = transform.InverseTransformDirection(posArriv - new Vector2(transform.position.x, transform.position.y));

          direction = posArriv - new Vector2(transform.position.x, transform.position.y);
          direction = direction.normalized;

           // direction = new Vector2(Mathf.Atan2(posArriv.x,transform.position.x), Mathf.Atan2(posArriv.y,transform.position.y));

        //direction = (transform.InverseTransformPoint(posArriv) - transform.InverseTransformPoint(new Vector2(transform.position.x, transform.position.y)));
            //directionFloat = (posArriv.y - transform.position.y)/(posArriv.x - transform.position.x);

          //float angle = Vector2.Angle(transform.position, posArriv);
            //print(diff);
          

    }
    private void Move()
    {
        /*
        if (ori == 0)
            transform.position += Vector3.up * humanSpeed * Time.deltaTime;
        if(ori == 1)
            transform.position += Vector3.right * humanSpeed * Time.deltaTime;
        if(ori == 2)
            transform.position += Vector3.down * humanSpeed * Time.deltaTime;
        if(ori == 3)
            transform.position += Vector3.left * humanSpeed * Time.deltaTime;*/
            
        transform.position = Vector2.Lerp(transform.position, posArriv, Time.deltaTime/10 * humanSpeed);
    }

    private void Rotation()
    {
        int rd = Random.Range(0, maxRand);
        switch (rd)
        {
            case 0:
                ori = (ori + 2) % 4;
                break;
            case 1:
                ori = (ori + 1) % 4;
                break;
            case 2:
                ori = (ori - 1) % 4;
                break;
            default:
                break;

        }
    }

    private bool isBlocked()
    {
        timeI += Time.deltaTime;
        if(lastPos != position)
        {
            lastPos = position;
            return false;
        }

        if(timeI > timeImmo)
        {
            timeI = 0;
            return true;
        }
        return false;
    }

    private void newArriv()
    {
        posArriv.x = Random.Range(minMapX, maxMapX);
        posArriv.y = Random.Range(minMapY, maxMapY);
        CheckOrientation();
        //print(posArriv.x + " ; " + posArriv.y);
    }

    private void stopMove()
    {
        timeS += Time.deltaTime;
        while (timeS < timeStop)
        {
            position = transform.position;
        }

    }
}

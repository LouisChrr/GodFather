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

    public float timeImmo = 2f;
    public float timeI = 0f;
    public Vector2 lastPos;

    public float minMapX = -10f;
    public float maxMapX = 10f;
    public float minMapY = -10f;
    public float maxMapY = 10f;
    public Vector2 posArriv;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        lastPos = position;
        posArriv.x = Random.Range(minMapX,maxMapX);
        posArriv.y = Random.Range(minMapY, maxMapY);
        print(posArriv.x + " ; " + posArriv.y);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (isBlocked())
        {
            timeI = 0;
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

        transform.position = Vector2.MoveTowards(transform.position, posArriv, humanSpeed * Time.deltaTime);
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
            return true;
        }
        return false;
    }

    private void newArriv()
    {
        posArriv.x = Random.Range(minMapX, maxMapX);
        posArriv.y = Random.Range(minMapY, maxMapY);
        print(posArriv.x + " ; " + posArriv.y);
    }
}

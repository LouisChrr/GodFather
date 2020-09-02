using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMove : MonoBehaviour
{
    public Vector2 position;
    public HumanSpawn spawn;
    public float humanSpeed = 0.25f;
    public int ori;
    public int maxRand = 5;

    public float timerRot = 2f;
    public float timer = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        ori = spawn.orient;
        //orient = spawn.orient;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (timer > timerRot)
        {
            Rotation();
            timer = 0f;
        }
        timer += Time.deltaTime;
    }


    private void Move()
    {
        if (ori == 0)
            transform.position += Vector3.up * humanSpeed * Time.deltaTime;
        if(ori == 1)
            transform.position += Vector3.right * humanSpeed * Time.deltaTime;
        if(ori == 2)
            transform.position += Vector3.down * humanSpeed * Time.deltaTime;
        if(ori == 3)
            transform.position += Vector3.left * humanSpeed * Time.deltaTime;
        
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
}

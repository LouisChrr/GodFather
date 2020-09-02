using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMove : MonoBehaviour
{
    public Vector2 position;
    public HumanSpawn spawn;
    public float humanSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        
        //orient = spawn.orient;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotation();
    }


    private void Move()
    {
        if(spawn.orient == 1)
            transform.position += Vector3.right * humanSpeed * Time.deltaTime;
        if(spawn.orient == 2)
            transform.position += Vector3.up * humanSpeed * Time.deltaTime;
        if(spawn.orient == 3)
            transform.position += Vector3.left * humanSpeed * Time.deltaTime;
        if(spawn.orient == 4)
            transform.position += Vector3.up * humanSpeed * Time.deltaTime;
    }

    private void Rotation()
    {

    }
}

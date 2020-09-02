using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{
    public Vector2 position;
    // public LevelBin level = null;
    public int level;
    public int score;
    public GameObject sprite;
    

    // Start is called before the first frame update
    void Start()
    {
        level = 0;
        position = transform.position;
        //level = new LevelBin(this);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeLevel();
        print(level);
        Move();
       // level.LevelUpdate();
    }

    public void ChangeLevel()
    {
        /*if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(level > 0)
            {
                level--;
            }
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(level < 2)
            {
                level++;
            }
        }*/
    }

    public void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
    }

}

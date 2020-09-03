using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawn : MonoBehaviour
{
    public float timeSpawn = 1000f;
    public float timer = 0f;
    public GameObject human;
    public int orient;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > timeSpawn)
        {
            GameObject newHuman = Instantiate(human);

            newHuman.transform.position = transform.position;
            timer = 0f;
            Destroy(newHuman, 180);
        }
        timer += Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawn : MonoBehaviour
{
    public float timeSpawn = 2f;
    public float timer = 0f;
    public GameObject human;
    public int orient;
    public int nbHuman;
    public int nbMaxHuman = 20;

    // Start is called before the first frame update
    void Start()
    {
         GameObject newHuman = Instantiate(human);
         nbHuman = 1;
            newHuman.transform.position = transform.position;
            timer = 0f;
            Destroy(newHuman, 180);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > timeSpawn)
        {
            if (nbHuman < nbMaxHuman)
            {
                GameObject newHuman = Instantiate(human);
                newHuman.transform.position = transform.position;
                nbHuman++;
                timer = 0f;
            }
            //Destroy(newHuman, 180);
        }
        timer += Time.deltaTime;
    }
}

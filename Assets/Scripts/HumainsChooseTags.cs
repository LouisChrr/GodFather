using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumainsChooseTags : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randTag = Random.Range(0,4);
        randTag = 0;
        switch (randTag)
        {
            case 0 :
                gameObject.tag = "Blue";
                break;
            case 1:
                gameObject.tag = "Brown";
                break;
            case 2:
                gameObject.tag = "Yellow";
                break;
            case 3:
                gameObject.tag = "Green";
                break;
            case 4:
                gameObject.tag = "Human";
                break;
        }

    }

}

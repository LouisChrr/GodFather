using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumainsChooseTags : MonoBehaviour
{

    public Color blueColor = Color.blue;
    public Color brownColor = Color.red;
    public Color yellowColor = Color.yellow;
    public Color greenColor = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        int randTag = Random.Range(0,4);
        Color color;
        ParticleSystem particle = GetComponent<ParticleSystem>();
        

        switch (randTag)
        {
            case 0 :
                gameObject.tag = "Blue";
                particle.startColor = blueColor;
                break;
            case 1:
                gameObject.tag = "Brown";
                particle.startColor = brownColor;
                break;
            case 2:
                gameObject.tag = "Yellow";
                particle.startColor = yellowColor;
                break;
            case 3:
                gameObject.tag = "Green";
                particle.startColor = greenColor;
                break;
            case 4:
                gameObject.tag = "Human";
                particle.Stop();
                break;
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Horloge : MonoBehaviour
{

    [SerializeField]Text textHorloge;
    int minute = 1;
    int seconde = 30;

    float timer = 1f;

    void Start()
    {
        textHorloge.text = minute.ToString() + seconde.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer = 1f;
            if (seconde == 0)
            {
                if (minute > 0)
                {
                    seconde = 59;
                    minute--;
                }
                else
                {
                    print("END");
                }
            }
            else
            {
                seconde--;
            }

            textHorloge.text = minute.ToString() + " : " + seconde.ToString();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PreGameManager : MonoBehaviour
{
    public int playersNumber = 0;
    public List<Color> colors;
    public List<PoubelleIdentifier> poubelles;
    public static PreGameManager Instance;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        text.text = "0 player detected";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayerJoined()
    {
        playersNumber+=1;
        text.text = playersNumber + " players detected";
    }

    public void OnPlayerLeft()
    {
        playersNumber-=1;

        int number = 1;
        foreach(PoubelleIdentifier pi in poubelles){
            pi.ID = number;
            number++;
        }
        text.text = playersNumber + " players detected";
    }

}

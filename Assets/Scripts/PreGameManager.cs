using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PreGameManager : MonoBehaviour
{
    public bool hasGameStarted = false;
    public int playersNumber = 0;
    public List<Color> colors;
    public List<PoubelleIdentifier> poubelles;
    public List<PoubelleIdentifierUI> poubellesUI;

    public static PreGameManager Instance;
    public Text text;
    public Text readyText;
    public int readyPlayers = 0;
    public PlayerJoined playerJoinedUI;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        text.text = "0 player detected";
        poubelles = new List<PoubelleIdentifier>();
        poubellesUI = new List<PoubelleIdentifierUI>();
        readyText.text = readyPlayers +"/0 players ready";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayerJoined()
    {
        playersNumber+=1;
        text.text = playersNumber + " players detected";
        playerJoinedUI.AddPlayer();
        Invoke("ResetReadyCheck", 0.2f);
        
    }

    void ResetReadyCheck(){

        readyText.text = readyPlayers +"/"+ poubelles.Count+" players ready";
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

    public void OnPlayerReady(){
    readyPlayers++;
    readyText.text = readyPlayers +"/"+ poubelles.Count+" players ready";
    if(readyPlayers == poubelles.Count && readyPlayers != 0){
            // ALORS ON START LA GAME
            // COUNTDOWN ECT
        readyText.text = "Starting game in 3.. ";
    }

    }

}

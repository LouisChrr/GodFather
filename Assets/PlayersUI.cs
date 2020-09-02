using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayersUI : MonoBehaviour
{
    public Text text;
    private int players;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "0 player detected";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPlayerJoined()
    {
        players++;
        text.text = players + " players detected";
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class PlayersMovement : MonoBehaviour
{

    //public int playerId;
    public List<Player> player;

    void Awake() {
        // Get the Player for a particular playerId
        //player = ReInput.players.GetPlayer(playerId);

      
       // Get the System Player
       //Player systemPlayer = ReInput.players.GetSystemPlayer();

       // Iterating through Players (excluding the System Player)
       for(int i = 0; i < ReInput.players.playerCount; i++) {
           Player p = ReInput.players.Players[i];
           player.Add(p);
       }

       // Iterating through Players (including the System Player)
    //    for(int i = 0; i < ReInput.players.allPlayerCount; i++) {
    //        Player p = ReInput.players.AllPlayers[i];
    //    }
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }
}

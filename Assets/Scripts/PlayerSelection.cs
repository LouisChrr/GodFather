using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{

    [SerializeField] private GameObject[] players;

    int playerSelected = 0;

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SelectPreviousPlayer();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SelectNextPlayer();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(GetPlayerSelected());
        }*/
    }

    public void SelectNextPlayer()
    {
        players[playerSelected].transform.GetChild(0).gameObject.SetActive(false);
        if (playerSelected + 1 == players.Length)
        {
            playerSelected = 0;
        }
        else
        {
            playerSelected++;
        }
        players[playerSelected].transform.GetChild(0).gameObject.SetActive(true);
    }

    public void SelectPreviousPlayer()
    {
        players[playerSelected].transform.GetChild(0).gameObject.SetActive(false);
        if (playerSelected == 0)
        {
            playerSelected = players.Length - 1;
        }
        else
        {
            playerSelected--;
        }
        players[playerSelected].transform.GetChild(0).gameObject.SetActive(true);
    }

    public int GetPlayerSelected()
    {
        return playerSelected + 1;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlayerUI : MonoBehaviour
{

    [SerializeField] GameObject[] playerScoreUI;
    [SerializeField] RectTransform[] playerScoreLevelProgressionUI;
    [SerializeField] Text[] playerTextScoreUI;

    // Start is called before the first frame update
    void Start()
    {
        //DisplayUiForXPlayers(4);
        //UpdateScoreOfPlayer(1,50,5);
    }

    public void DisplayUiForXPlayers(int nbPlayers)
    {
        while (nbPlayers > 0)
        {
            nbPlayers--;
            playerScoreUI[nbPlayers].SetActive(true);
        }
    }

    public void UpdateScoreOfPlayer(int idPlayer, float pourcentageOfLevelBar, int score)
    {
        playerTextScoreUI[idPlayer - 1].text = (int.Parse(playerTextScoreUI[idPlayer - 1].text) + score).ToString();
        playerScoreLevelProgressionUI[idPlayer - 1].sizeDelta = new Vector2 ( ((float)pourcentageOfLevelBar / 100) * 615, playerScoreLevelProgressionUI[idPlayer - 1].sizeDelta.y);
    }

}

﻿using UnityEngine;
using UnityEngine.UI;

public class Horloge : MonoBehaviour
{
    [SerializeField] Text textHorloge;
    [SerializeField] PoduimEndGame endGamePodium;
    [SerializeField] GameObject uiGame;
    [SerializeField] GameObject uiEndGame;
    [SerializeField] ScorePlayerUI scorePlayer;
    [SerializeField] GameObject[] allGameObjectToDisable;

    int minute = 1;
    int seconde = 30;

    float timer = 1f;

    void Start()
    {
        textHorloge.text = minute.ToString() + " : " + seconde.ToString("00");
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
                    uiEndGame.SetActive(true);
                    uiGame.SetActive(false);
                    foreach ( GameObject objetToDisable in allGameObjectToDisable)
                    {
                        objetToDisable.SetActive(false);
                    }
                    endGamePodium.ClassementPlayer( (int.Parse(scorePlayer.playerTextScoreUI[0].text)), (int.Parse(scorePlayer.playerTextScoreUI[1].text)), (int.Parse(scorePlayer.playerTextScoreUI[2].text)), (int.Parse(scorePlayer.playerTextScoreUI[3].text)), PreGameManager.Instance.poubelles.Count);
                }
            }
            else
            {
                seconde--;
            }

            textHorloge.text = minute.ToString() + " : " + seconde.ToString("00");
        }

    }
}

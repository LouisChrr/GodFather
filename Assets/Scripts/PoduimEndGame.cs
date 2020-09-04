using Rewired;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PoduimEndGame : MonoBehaviour
{

    [SerializeField] Animator[] listeAnimator;

    [SerializeField] RuntimeAnimatorController blue;
    [SerializeField] RuntimeAnimatorController yellow;
    [SerializeField] RuntimeAnimatorController brown;
    [SerializeField] RuntimeAnimatorController green;

    [SerializeField] GameObject podium3;
    [SerializeField] GameObject podium4;

    [SerializeField] Text textWinner;

    // Start is called before the first frame update
    void Start()
    {
        //ClassementPlayer(10, 50, 42, 51, 4);
    }

    public void ClassementPlayer(int scoreBlue, int scoreGreen, int scoreYellow, int scoreBrown, int nbPlayer)
    {

        List<int> tab = new List<int> { scoreBlue, scoreGreen, scoreYellow, scoreBrown };
        tab.Sort((a, b) => b.CompareTo(a));

        if (tab[0] == scoreBlue)
        {
            textWinner.text = "BLUE WIN WITH "+scoreBlue.ToString() + " POINTS";
        }
        else if (tab[0] == scoreGreen)
        {
            textWinner.text = "GREEN WIN WITH " + scoreGreen.ToString() + " POINTS";
        }
        else if (tab[0] == scoreYellow)
        {
            textWinner.text = "YELLOW WIN WITH " + scoreYellow.ToString() + " POINTS";
        }
        else
        {
            textWinner.text = "BROWN WIN WITH " + scoreBrown.ToString() + " POINTS";
        }

        if (nbPlayer == 3)
        {
            Destroy(listeAnimator[3].gameObject);
            Destroy(podium4);
        }
        else if (nbPlayer == 2)
        {
            Destroy(listeAnimator[3].gameObject);
            Destroy(listeAnimator[2].gameObject);
            Destroy(podium4);
            Destroy(podium3);
        }

        while (nbPlayer > 0)
        {
            nbPlayer--;
            if (tab[nbPlayer] == scoreBlue)
            {
                listeAnimator[nbPlayer].runtimeAnimatorController = blue;
            }
            else if (tab[nbPlayer] == scoreGreen)
            {
                listeAnimator[nbPlayer].runtimeAnimatorController = green;
            }
            else if (tab[nbPlayer] == scoreYellow)
            {
                listeAnimator[nbPlayer].runtimeAnimatorController = yellow;
            }
            else
            {
                listeAnimator[nbPlayer].runtimeAnimatorController = brown;
            }
        }
    }
}

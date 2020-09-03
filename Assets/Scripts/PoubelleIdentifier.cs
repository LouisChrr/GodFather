using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoubelleIdentifier : MonoBehaviour
{
    public int ID;
    private Sprite PoubelleSprite;
    bool ready = false;
    bool canBeReady = false;
    private PoubelleController pc;
    int levelEvolution = 0;
    float scoreForEvolution = 10;
    float score = 0;

    // Start is called before the first frame update

    private void Awake()
    {
        pc = this.GetComponent<PoubelleController>();
    }

    void Start()
    {
        PreGameManager.Instance.poubelles.Add(this);
        ID = PreGameManager.Instance.playersNumber;
        PoubelleSprite = PreGameManager.Instance.sprites[ID - 1];
        pc.anim.runtimeAnimatorController = PreGameManager.Instance.anims[ID - 1];
        Invoke("CanBeReady", 0.5f);
    }

    void CanBeReady()
    {
        canBeReady = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDeviceLost()
    {

    }

    void OnDeviceRegained()
    {


    }

    void OnGrab()
    {
        if (PreGameManager.Instance.hasGameStarted == true || ready == true || canBeReady == false) return;
        PreGameManager.Instance.OnPlayerReady();
        ready = true;

        PreGameManager.Instance.poubellesUI[ID - 1].readyText.SetActive(true);
        //print("Grab!");
    }


    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Green")
        {
            if (ID == 3)
            {
                Destroy(other.gameObject);
                score++;
                float pourcentage = (score / scoreForEvolution) * 100 ;
                if (pourcentage == 100)
                {
                    levelEvolution++;
                    pourcentage = 0;
                    score = 0;
                }
                PreGameManager.Instance.spUI.UpdateScoreOfPlayer(ID, pourcentage , 1);
            }
            else
            {
                score--;
                float pourcentage = (score / scoreForEvolution) * 100;
                PreGameManager.Instance.spUI.UpdateScoreOfPlayer(ID, pourcentage, -1);
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.tag == "Yellow")
        {
            if (ID == 2)
            {
                score++;
                float pourcentage = (score / scoreForEvolution) * 100;
                if (pourcentage == 100)
                {
                    levelEvolution++;
                    pourcentage = 0;
                    score = 0;
                }
                PreGameManager.Instance.spUI.UpdateScoreOfPlayer(ID, pourcentage, 1);
                Destroy(other.gameObject);
            }
            else
            {
                score--;
                float pourcentage = (score / scoreForEvolution) * 100;
                PreGameManager.Instance.spUI.UpdateScoreOfPlayer(ID, pourcentage, -1);
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.tag == "Brown")
        {
            if (ID == 4)
            {
                score++;
                float pourcentage = (score / scoreForEvolution) * 100;
                if (pourcentage == 100)
                {
                    levelEvolution++;
                    pourcentage = 0;
                    score = 0;
                }
                PreGameManager.Instance.spUI.UpdateScoreOfPlayer(ID, pourcentage, 1);
                Destroy(other.gameObject);
            }
            else
            {
                score--;
                float pourcentage = (score / scoreForEvolution) * 100;
                PreGameManager.Instance.spUI.UpdateScoreOfPlayer(ID, pourcentage, -1);
                Destroy(other.gameObject);
            }
        }
        else if (other.gameObject.tag == "Blue")
        {
            if (ID == 1)
            {
                score++;
                float pourcentage = (score/scoreForEvolution) * 100f;

                if (pourcentage == 100)
                {
                    levelEvolution++;
                    pourcentage = 0;
                    score = 0;
                }
                PreGameManager.Instance.spUI.UpdateScoreOfPlayer(ID, pourcentage, 1);
                Destroy(other.gameObject);
                
            }
            else
            {
                score--;
                float pourcentage = (score / scoreForEvolution) * 100;
                PreGameManager.Instance.spUI.UpdateScoreOfPlayer(ID, pourcentage, -1);
                Destroy(other.gameObject);
                
            }

          

        }
        else if (other.gameObject.tag == "Human")
        {
            score--;
            float pourcentage = (score / scoreForEvolution) * 100;
            PreGameManager.Instance.spUI.UpdateScoreOfPlayer(ID, pourcentage, -1);
            Destroy(other.gameObject);
        }

    }

}

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
    // Start is called before the first frame update
    void Start()
      {
        PreGameManager.Instance.poubelles.Add(this);
        ID = PreGameManager.Instance.playersNumber;
        PoubelleSprite = PreGameManager.Instance.sprites[ID-1];

        Invoke("CanBeReady", 0.5f);


      }

    void CanBeReady(){
        canBeReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDeviceLost(){

    }

    void OnDeviceRegained(){


    }

    void OnGrab()
    {
    if(PreGameManager.Instance.hasGameStarted == true || ready == true || canBeReady == false) return;
        PreGameManager.Instance.OnPlayerReady();
        ready = true;

        PreGameManager.Instance.poubellesUI[ID-1].readyText.SetActive(true);
        print("Grab!");
    }

}

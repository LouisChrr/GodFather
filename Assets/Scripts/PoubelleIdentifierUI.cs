using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PoubelleIdentifierUI : MonoBehaviour
{
    public int ID;
    private Color PoubelleColor;
    public GameObject readyText;

    // Start is called before the first frame update
    void Start()
    {
        PreGameManager.Instance.poubellesUI.Add(this);
        ID = PreGameManager.Instance.playersNumber;
        PoubelleColor = PreGameManager.Instance.colors[ID-1];

        this.GetComponent<Image>().color = PoubelleColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDeviceLost(){

    }

    void OnDeviceRegained(){


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoubelleIdentifier : MonoBehaviour
{
    public int ID;
    private Color PoubelleColor;

    // Start is called before the first frame update
    void Start()
    {
        PreGameManager.Instance.poubelles.Add(this);
        ID = PreGameManager.Instance.playersNumber;
        PoubelleColor = PreGameManager.Instance.colors[ID-1];
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

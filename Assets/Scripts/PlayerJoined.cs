using System.Collections.Generic;
using UnityEngine;

public class PlayerJoined : MonoBehaviour
{

    [SerializeField] private GameObject playersPrefab;

    private List<GameObject> listePlayer;

    public bool testAddPlayer = false;

    public void Start(){


    listePlayer = new List<GameObject>();

    }

    private void Update()
    {
        if (testAddPlayer)
        {
            testAddPlayer = false;
            AddPlayer();
        }
    }

    public void AddPlayer()
    {
        listePlayer.Add(Instantiate(playersPrefab, transform.position, transform.rotation, transform));
    }

    public void RemovePlayer()
    {
        
    }



}

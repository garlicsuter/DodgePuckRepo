using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject player;

    void Awake()
    {
        this.InstantiateController();
    }

    private void InstantiateController()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != Instance)
        {
            Debug.Log("Destroying extra GM");
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        Debug.Log("Started");
        Debug.Log("Player has not spawned. I'll make one for you.");
        Instantiate(player, new Vector2(-4, 4), Quaternion.identity);
    }
}

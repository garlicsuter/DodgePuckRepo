using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
 
    void Start()
    {
        StartCoroutine(ABC());
    }

    IEnumerator ABC()
    {

        //returning 0 will make it wait 1 frame
        yield return 0;

        bool playerExists = (GameObject.Find("player") != null);
        if (playerExists == false)
        {
            Instantiate(player, new Vector2(-4, -4), Quaternion.identity);
        }
        


    }

}

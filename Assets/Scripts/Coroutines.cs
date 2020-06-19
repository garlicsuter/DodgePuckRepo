using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{

    public float score = 1.0f;
    public float biffMoney = 50.00f;

    IEnumerator alternate1985()
    {
        yield return new WaitForSeconds(2);
        print("Biff has the Almanac and " + biffMoney + " dollars!");
        biffMoney++;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            StartCoroutine(alternate1985());
        }
    }
}

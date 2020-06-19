using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerControllerNESW : MonoBehaviour
{
    public float speed;
    public float xRange;
    public float yRange;
    private Vector2 spawnLoc = new Vector2(2, 2);

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = spawnLoc;
        DontDestroyOnLoad(this.gameObject);
    }

    void LateUpdate()
    {
        //Keep Player within xRange (Left and Right sides)
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }

    }

    // Update is called once per frame
    void Update()
    {

        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        
        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxisRaw("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //FROM A1
        if (other.gameObject.CompareTag("East") && SceneManager.GetActiveScene().name == "A1")
        {
            spawnLoc = new Vector2(-7, 0);
            SceneManager.LoadScene("B1");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("South") && SceneManager.GetActiveScene().name == "A1")
        {
            spawnLoc = new Vector2(0, 7);
            SceneManager.LoadScene("A2");
            transform.position = spawnLoc;

        }

        //FROM A2
        if (other.gameObject.CompareTag("East") && SceneManager.GetActiveScene().name == "A2")
        {
            spawnLoc = new Vector2(-7, 0);
            SceneManager.LoadScene("B2");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("North") && SceneManager.GetActiveScene().name == "A2")
        {
            spawnLoc = new Vector2(0, -7);
            SceneManager.LoadScene("A1");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("South") && SceneManager.GetActiveScene().name == "A2")
        {
            spawnLoc = new Vector2(0, 7);
            SceneManager.LoadScene("A3");
            transform.position = spawnLoc;
        }

        //FROM A3
        if (other.gameObject.CompareTag("East") && SceneManager.GetActiveScene().name == "A3")
        {
            spawnLoc = new Vector2(-7, 0);
            SceneManager.LoadScene("B3");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("North") && SceneManager.GetActiveScene().name == "A3")
        {
            spawnLoc = new Vector2(0, -7);
            SceneManager.LoadScene("A2");
            transform.position = spawnLoc;
        }

        //FROM B1
        if (other.gameObject.CompareTag("East") && SceneManager.GetActiveScene().name == "B1")
        {
            spawnLoc = new Vector2(-7, 0);
            SceneManager.LoadScene("C1");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("West") && SceneManager.GetActiveScene().name == "B1")
        {
            spawnLoc = new Vector2(7, 0);
            SceneManager.LoadScene("A1");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("South") && SceneManager.GetActiveScene().name == "B1")
        {
            spawnLoc = new Vector2(0, 7);
            SceneManager.LoadScene("B2");
            transform.position = spawnLoc;

        }
        //FROM B2
        if (other.gameObject.CompareTag("East") && SceneManager.GetActiveScene().name == "A2")
        {
            spawnLoc = new Vector2(-7, 0);
            SceneManager.LoadScene("C2");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("North") && SceneManager.GetActiveScene().name == "B2")
        {
            spawnLoc = new Vector2(0, -7);
            SceneManager.LoadScene("B1");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("West") && SceneManager.GetActiveScene().name == "B2")
        {
            spawnLoc = new Vector2(7, 0);
            SceneManager.LoadScene("A2");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("South") && SceneManager.GetActiveScene().name == "B2")
        {
            spawnLoc = new Vector2(0, 7);
            SceneManager.LoadScene("B3");
            transform.position = spawnLoc;
        }

        //FROM B3
        if (other.gameObject.CompareTag("East") && SceneManager.GetActiveScene().name == "B3")
        {
            spawnLoc = new Vector2(-7, 0);
            SceneManager.LoadScene("C3");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("North") && SceneManager.GetActiveScene().name == "B3")
        {
            spawnLoc = new Vector2(0, -7);
            SceneManager.LoadScene("B2");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("West") && SceneManager.GetActiveScene().name == "B3")
        {
            spawnLoc = new Vector2(7, 0);
            SceneManager.LoadScene("A3");
            transform.position = spawnLoc;
        }

        //FROM C1
        if (other.gameObject.CompareTag("West") && SceneManager.GetActiveScene().name == "C1")
        {
            spawnLoc = new Vector2(7, 0);
            SceneManager.LoadScene("B1");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("South") && SceneManager.GetActiveScene().name == "C1")
        {
            spawnLoc = new Vector2(0, 7);
            SceneManager.LoadScene("C2");
            transform.position = spawnLoc;
        }

        //FROM C2
        if (other.gameObject.CompareTag("North") && SceneManager.GetActiveScene().name == "C2")
        {
            spawnLoc = new Vector2(0, -7);
            SceneManager.LoadScene("C1");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("West") && SceneManager.GetActiveScene().name == "C2")
        {
            spawnLoc = new Vector2(7, 0);
            SceneManager.LoadScene("B2");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("South") && SceneManager.GetActiveScene().name == "C2")
        {
            spawnLoc = new Vector2(0, 7);
            SceneManager.LoadScene("C3");
            transform.position = spawnLoc;
        }

        //FROM C3
        if (other.gameObject.CompareTag("North") && SceneManager.GetActiveScene().name == "C3")
        {
            spawnLoc = new Vector2(0, -7);
            SceneManager.LoadScene("C2");
            transform.position = spawnLoc;
        }

        if (other.gameObject.CompareTag("West") && SceneManager.GetActiveScene().name == "C3")
        {
            spawnLoc = new Vector2(7, 0);
            SceneManager.LoadScene("B3");
            transform.position = spawnLoc;
        }


    }
}

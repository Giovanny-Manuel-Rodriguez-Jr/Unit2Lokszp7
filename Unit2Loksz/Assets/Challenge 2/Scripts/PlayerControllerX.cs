using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeLimit = 1.0f;

    // Update is called once per frame
    void Update()
    {
        timeLimit = timeLimit - Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timeLimit <= 0.0f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeLimit = 1.0f;
            }
            else if (timeLimit <= 1.0f)
            {
                return;
            }
            
        }
    }
}

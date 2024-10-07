using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float delayTime = 20.0f;

    // Update is called once per frame
    void Update()
    {
        delayTime -= 0.01f;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && delayTime <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
             delayTime = 2.0f;
        }
    }
}

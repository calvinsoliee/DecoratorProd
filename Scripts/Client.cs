using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Client : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            IRifle rifle = new BasicRifle();
            Instantiate(rifle.LoadPart());
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithMag(rifle);
            Instantiate(rifle.LoadPart());
            Debug.Log("WithMag accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithSilencer(new WithMag(rifle));
            Instantiate(rifle.LoadPart());
            Debug.Log("WithSilencer accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithStock(new WithSilencer(new WithMag(rifle)));
            Instantiate(rifle.LoadPart());
            Debug.Log("WithStock accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

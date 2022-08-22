using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("player"))
        { 
            SceneManager.LoadScene("Level2", LoadSceneMode.Additive);
        }
    }           


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

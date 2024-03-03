using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnPress : MonoBehaviour
{
    public AudioSource[] audiosource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audiosource[0].Play();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            audiosource[1].Play();
        } 
    }
}

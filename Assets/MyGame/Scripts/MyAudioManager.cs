using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAudioManager : MonoBehaviour
{
    // Instanzvariablen
    [SerializeField]

    private Sound[] sounds;

    void Awake()
    {
        foreach(Sound s in sounds)
        {
            gameObject.AddComponent<AudioSource>();
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

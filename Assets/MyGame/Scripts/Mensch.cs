using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensch : MonoBehaviour
{
    //Instanzvariablen  
    public string personName;
    public string rolleInKlasse;
    public Color augenfarbe;

    [SerializeField]

    private GameObject myGameObject;


    [SerializeField]

    private AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mein Name: " + personName);
        Debug.Log("Meine Rolle in der Klasse: " + rolleInKlasse);
        Debug.Log("Meine Augenfarbe: " + augenfarbe);
        
        myGameObject = GetComponent<GameObject>();

        // Hole die Komponenete AudioSource beim
        // Starten des GameObjects
        myAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        // sobald die Leertaste gedrückt wird
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Leertaste wurde gedrückt!");
            // Starte die Audio-Wiedergabe
            myAudioSource.Play();

        } else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Leertaste wurde losgelassen!");
            // Stoppe die Audio-Wiedergabe
            myAudioSource.Pause();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// Klasse Sound muss Serialisierbar sein
[System.Serializable]


public class Sound
{
    // Innstanzvariablen fuer eine Audio-Datei
    // Name der Audio-Datei

    public string name;
    // Der Audio-Clip

    public AudioClip clip;

    // die Lautstaerke
    [Range(0f,1f)] // Bereich gueltiger Zahlenwerte

    public float volume;

    // der Pitch
    [Range(0.1f,3f)] // Bereich gueltiger Zahlenwerte

    public float pitch; 


}

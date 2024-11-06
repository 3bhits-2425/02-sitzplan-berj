using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class AudioMenü : MonoBehaviour
{

    private AudioSource myAudioSource;

    // 2 variablen, um den Button und den Text zu finden
    private GameObject playPauseButton;
    private TMP_Text playPauseButtonText;

    void Awake()
    {
        // get the Audio Source Component 
        myAudioSource = GetComponent<AudioSource>();

        // finde das Textfeld des PlayPauseButtons
        playPauseButton = GameObject.Find("PlayPauseButton");

        // finde das Textfeld als Kindkomponente des PlayPauseButtons
        playPauseButtonText = playPauseButton.GetComponentInChildren<TMP_Text>();
    }


    public void Update()
    {
        //aendere den Button-Text
        // abhängig vom Status der Ausio-source
        if (myAudioSource.isPlaying)
        {
            playPauseButtonText.text = "Pause";
        }
        else
        {
            playPauseButtonText.text = "Play";
        }
    }



    public void PlayAudio()
    {
        Debug.Log("Play Audio");
        // play the audio
        myAudioSource.Play();

    }

    public void PauseAudio()
    {
        Debug.Log("Pause Audio");
        // pause the audio
        myAudioSource.Pause();
    }

    public void StopAudio()
    {
        Debug.Log("Stop Audio");
        // stop the audio
        myAudioSource.Stop();
    }

    public void PlayPause()
    {
        // check if the audio is playing
        if (myAudioSource.isPlaying)
        {
            // if it is playing, pause the audio
            PauseAudio();
            
        }
        else
        {
            // if it is not playing, play the audio
            PlayAudio();
            
        }

    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StudentData", menuName = "Seatplan/Student", order = 1)]

public class StudentData : ScriptableObject
{
    public string studentName;
    public Color eyeColor;
    public Sprite studentImage;
    public AudioClip studentClip;
}

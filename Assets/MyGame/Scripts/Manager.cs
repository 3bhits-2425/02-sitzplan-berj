using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout; //Ref zu TableLayout ScriptableObject
    [SerializeField] private StudentData[] students; //
    [SerializeField] private GameObject tablePrefab; //Prefab für Tisch
    [SerializeField] private GameObject chairPrefab; //Prefab für Sessel
    [SerializeField] private GameObject studentPrefab; //Prefab für Student

    private int studentIndex = 0; //Index für Studenten

    // Start is called before the first frame update
    private void Start()
    {
        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);

                //Tische platzieren
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);
                table.name = "Table " + row + " " + col;
                table.transform.position = tablePosition;
                //Sessel platzieren (2 pro Tisch)

                Transform pos1 = table.transform.Find("pos1");
                Transform pos2 = table.transform.Find("pos2");

                if (pos1)
                {
                    AssignStudentToChair(pos1); //Transform[]
                }

                if (pos2)
                {
                    AssignStudentToChair(pos2); //Transform[]
                    //Transform[]
                }

                //Studenten platzieren
                void AssignStudentToChair(Transform chairPosition)
                {
                    if (studentIndex >= students.Length) return; // Keine weiteren Studenten verfügbar

                    // Schüler platzieren
                    GameObject student = Instantiate(studentPrefab, chairPosition.position, chairPosition.rotation, chairPosition);


                    studentIndex++; //A//
                }
            }
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tableLayout; //Ref zu TableLayout ScriptableObject
    [SerializeField] private StudentData[] students; //
    [SerializeField] private GameObject tablePrefab; //Prefab für Tisch
    [SerializeField] private GameObject chairPrefab; //Prefab für Sessel

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
                    Instantiate(chairPrefab, pos1.position, pos1.rotation, table.transform);
                }

                if (pos2)
                {
                    Instantiate(chairPrefab, pos2.position, pos2.rotation, table.transform);
                    //Transform[]
                }

                //Studenten platzieren

            }
        }

    }
}
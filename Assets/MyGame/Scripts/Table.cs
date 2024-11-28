using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTableLayout", menuName = "Seatplan/TableLayout")] 

public class TableLayoutData : ScriptableObject
{
    public int rows;
    public int columns;
    public float tableSpacing; // Abstand zwischen Tischen
    public float chairSpacing; // Abstand zwischen Sesseln
}

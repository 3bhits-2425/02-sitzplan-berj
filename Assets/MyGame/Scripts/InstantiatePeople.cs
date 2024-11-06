using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Das Prefab für das Menschen-Viereck
    public GameObject peoplePrefab;

    // Canvas für die Menschen-Objekte
    public Canvas canvas;

    // Referenz Resolution des Canvas
    public Vector2 referenceResolution = new Vector2(960, 600);

    // Größe der Vierecke
    public Vector2 squareSize = new Vector2(100, 100); // Größe eines Vierecks

    // Padding (Rand) um die Menschen-Vierecke
    public float padding = 50f;

    // Abstand zwischen den Vierecken
    public float horizontalSpacing = 10f;
    public float verticalSpacing = 20f;

    [SerializeField] private GameObject myParent;   

    void Start()
    {
        Generatesitzplan();
    }

    void Generatesitzplan()
    { 

        // Holen Sie sich die RectTransform des Canvas
        RectTransform canvasRect = canvas.GetComponent<RectTransform>();

        // Berechne den Platz, der nach Padding zur Verfügung steht
        float availableWidth = canvasRect.sizeDelta.x - (2 * padding);
        float availableHeight = canvasRect.sizeDelta.y - (2 * padding);

        // Definiere die Anzahl der Menschen in jeder Reihe
        int[] rowCounts = { 8, 8, 3 }; // 8 Menschen in den ersten beiden Reihen, 3 in der letzten

        // Berechne die Gesamtbreite für eine volle Reihe (8 Menschen)
        float totalWidthFor8 = (squareSize.x + horizontalSpacing) * 8 - horizontalSpacing;

        // Starte Y-Position: Obere Position mit Padding
        float startY = availableHeight / 2 - squareSize.y / 2 + -padding;

        // Variable zur Berechnung der aktuellen Y-Position der Reihen
        float currentY = startY;

        // Schleife durch die Reihen
        for (int row = 0; row < rowCounts.Length; row++)
        {
            // Anzahl der Menschen in der aktuellen Reihe
            int peopleInRow = rowCounts[row];

            // Berechne die Start-X-Position für die aktuelle Reihe (damit die Menschen in der Mitte sind)
            // Unabhängig von der Anzahl der Menschen pro Reihe beginnt jede Reihe am gleichen Punkt
            float currentX = -totalWidthFor8 / 2 + padding;

            // Schleife, um Menschen in der aktuellen Reihe zu platzieren
            for (int i = 0; i < peopleInRow; i++)
            {
                // Instanziere ein neues Viereck (Menschen-Objekt)
                GameObject newPerson = Instantiate(peoplePrefab);

                // Setze das Viereck als Kind des Canvas (wichtig für UI-Objekte)
                newPerson.transform.SetParent(myParent.transform);
                newPerson.transform.localScale = myParent.transform.localScale;
                

                // Setze die Position des Vierecks in der aktuellen Reihe
                RectTransform rectTransform = newPerson.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2(currentX, currentY);

                // Bewege die X-Position nach rechts für den nächsten Menschen
                currentX += (squareSize.x + horizontalSpacing);
            }

            // Bewege die Y-Position nach unten für die nächste Reihe
            currentY -= (squareSize.y + verticalSpacing);
        }
    }

}


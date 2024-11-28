using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private TableLayoutData tablelayout;

    [SerializeField] private StudentData[] studens;

    [SerializeField] private GameObject tablePrefab;

    [SerializeField] private GameObject chairPrefab;

    

    // Start is called before the first frame update
    private void Start()
    {
        for(int row = 0; row < tablelayout.rows; row++)
        {
            for (int col = 0; col < tablelayout.columns; col++)
            {
                GameObject table = Instantiate(tablePrefab);
                Debug.Log("Table created");
               
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

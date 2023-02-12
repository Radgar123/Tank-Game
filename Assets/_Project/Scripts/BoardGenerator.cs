using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    [Header("Spawn Object Local Scale")]
    [SerializeField] private Vector2 maxObjectScale;
    [SerializeField] private Vector2 minObjectsScale;
    
    [Header("Board Boundary To Spawn Objects")]
    [SerializeField] private Vector2 maxBoardBoundary;
    [SerializeField] private Vector2 minBoardBoundary;
    
    [Header("Generator Options")]
    [SerializeField] private bool generateMapOnStart;
    //[SerializeField] private bool rotateObjectPosition;
    [Range(1, 100)][SerializeField] private int numbersOfObjectsToSpawn;
    
    [SerializeField] private List<Color> listColorsToSet;
    [SerializeField] private GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        if (generateMapOnStart)
        {
            GenerateMap();
        }
    }

    public void GenerateMap()
    {
        /*Vector3 pos = new Vector3(Random.Range(maxBoardBoundary.x, minBoardBoundary.x), -3.56f,
            Random.Range(maxBoardBoundary.y, minBoardBoundary.y));
            */
        ClearMap();

        for (int i = 0; i < numbersOfObjectsToSpawn; i++)
        {
            Vector3 pos = new Vector3(Random.Range(maxBoardBoundary.x, maxBoardBoundary.y), -3.56f,
                Random.Range(minBoardBoundary.x,minBoardBoundary.y));

            GameObject temp = Instantiate(objectToSpawn, pos,Quaternion.identity);
            temp.GetComponent<Renderer>().material.color = listColorsToSet[Random.Range(0, listColorsToSet.Count)];
            temp.transform.localScale = new Vector3(Random.Range(minObjectsScale.x, maxObjectScale.x), 1,
                Random.Range(minObjectsScale.y, maxObjectScale.y));
            
            temp.transform.SetParent(gameObject.transform);
        }
    }

    public void ClearMap()
    {
        this.gameObject.transform.DestroyAllChildren();
    }
}

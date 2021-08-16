using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject SquarePrefab;
    public GameObject TrianglePrefab;
    public GameObject CirclePrefab;
    public Vector3 SquareSpawn, TriangleSpawn, CircleSpawn;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newInstance1 = GameObject.Instantiate(SquarePrefab, SquareSpawn, Quaternion.identity);
        GameObject newInstance2 = GameObject.Instantiate(TrianglePrefab, TriangleSpawn, Quaternion.identity);
        GameObject newInstance3 = GameObject.Instantiate(CirclePrefab, CircleSpawn, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

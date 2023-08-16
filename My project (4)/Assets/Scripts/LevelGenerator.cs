using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject CubeToGrow;
    // array of game objects 10x5 - 10 columns with 5 rows in each column. 


    // Start is called before the first frame update
    void Start()
    {
        // the for loop creates 10 objects in the x axis offdset by 2
        for (int i = 0; i < 100; i+=5)
        {
            Instantiate(CubeToGrow, new Vector3(i + 2.0F, 5, 0), Quaternion.identity);
        }
         //private GameObject[,] leftTileMap = new GameObject[2, 3] { { ), Instantiate(CubeToGrow, new Vector3(6.0F, 0, 0), Quaternion.identity), Instantiate(CubeToGrow, new Vector3(10.0F, 0, 0), Quaternion.identity) }, { Instantiate(CubeToGrow, new Vector3(2.0F, 10, 0), Quaternion.identity), Instantiate(CubeToGrow, new Vector3(6.0F, 10, 0), Quaternion.identity), Instantiate(CubeToGrow, new Vector3(10.0F, 10, 0), Quaternion.identity) } };
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

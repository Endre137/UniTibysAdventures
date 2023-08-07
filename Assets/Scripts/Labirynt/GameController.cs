using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    EnvironmentController environmentController;
    TileMapGenerator tileMapGenerator;

    
    // Start is called before the first frame update
    void Start()
    {
        environmentController = GameObject.Find("EnvironmentController").GetComponent<EnvironmentController>();
        tileMapGenerator = GameObject.Find("TileMapGenerator").GetComponent<TileMapGenerator>();
        
    }

}

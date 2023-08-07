using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{   

    public GameObject background;

    TileMapGenerator tileMapGenerator;
    public GameObject winterRoad;
    public GameObject winterTree;
    public GameObject winterObject1;
    public GameObject winterObject2;
    public GameObject winterCollider;
    public GameObject winterTrap;

    public GameObject caveRoadTile;
    public GameObject caveTrap;
    public GameObject caveBackground;

    public GameObject caveNpc;

    public GameObject desertRoadTile;
    public GameObject desertTrap;
    public GameObject desertObject1;
    public GameObject desertObject2;
    public GameObject desertObject3;
    public GameObject desertBackground;


    public GameObject palmTreeObject;
    public GameObject islandBackground;

    public GameObject islandNpc;

    BackgroundColorChange backgroundColorChange;


    // Start is called before the first frame update
    void Start()
    {   
        backgroundColorChange = GameObject.Find("Background").GetComponent<BackgroundColorChange>();
        tileMapGenerator = GameObject.Find("MapGenerator").GetComponent<TileMapGenerator>();
        
    }

    public void ChangeToWinter(){
        
        tileMapGenerator.roadPrefab = winterRoad;
        tileMapGenerator.treePrefab = winterTree;
        tileMapGenerator.grass1Prefab = winterObject1;
        tileMapGenerator.grass2Prefab = winterObject2;
        tileMapGenerator.backgroundPrefab = winterCollider;
        tileMapGenerator.trapPrefab = winterTrap;
        backgroundColorChange.changeToWinter();

    
    }

    public void ChangeToCave(){
        tileMapGenerator.npcPrefab = caveNpc;
        tileMapGenerator.roadPrefab = caveRoadTile;
        tileMapGenerator.treePrefab = caveBackground;
        tileMapGenerator.grass1Prefab = caveBackground;
        tileMapGenerator.grass2Prefab = caveBackground;
        tileMapGenerator.backgroundPrefab = caveBackground;
        tileMapGenerator.trapPrefab = caveTrap;
        backgroundColorChange.changeToCave();
    }

    public void ChangeToDesert(){
        tileMapGenerator.roadPrefab = desertRoadTile;
        tileMapGenerator.treePrefab = desertObject3;
        tileMapGenerator.grass1Prefab = desertObject1;
        tileMapGenerator.grass2Prefab = desertObject2;
        tileMapGenerator.backgroundPrefab = desertBackground;
        tileMapGenerator.trapPrefab = desertTrap;
        backgroundColorChange.changeToDesert();


    }

        public void ChangeToIsland(){
        tileMapGenerator.roadPrefab = desertRoadTile;
        tileMapGenerator.treePrefab = palmTreeObject;
        tileMapGenerator.grass1Prefab = islandBackground;
        tileMapGenerator.grass2Prefab = islandBackground;
        tileMapGenerator.backgroundPrefab = desertBackground;
        tileMapGenerator.trapPrefab = desertTrap;
        tileMapGenerator.npcPrefab = islandNpc;
        backgroundColorChange.changeToIsland();
    }
    
}

using UnityEngine;


public class Trap : MonoBehaviour
{   
    [SerializeField] private float damage;
    public WrongPath WrongPath;
    TileMapGenerator tileMapGenerator;


    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            if(collision.GetComponent<Health>().currentH != 1){     ///currentH == 1 -> game over screen
                WrongPath.SetWrongPathScreen();
            }
            collision.GetComponent<Health>().Damage(damage);
            collision.transform.position = collision.GetComponent<PlayerMovement>().respawnPoint;
            tileMapGenerator = GameObject.Find("MapGenerator").GetComponent<TileMapGenerator>();
            tileMapGenerator.ChangeMap();
            tileMapGenerator.ClearMap();
            tileMapGenerator.DrawMap(); 
        }
    }
}

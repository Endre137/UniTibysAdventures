using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{   
    [SerializeField] private float startingH;                   //starting health
    public float currentH {get; private set;}                   //current health
    public GameOver GameOver;                                   //game over screen
    // Start is called before the first frame update
    void Start()
    {
        currentH = startingH;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentH == 0){
            GameOver.SetGameOverScreen();
        }
    }

    public void Damage(float damage){

        currentH = Mathf.Clamp(currentH - damage, 0,startingH);                  //current health >= 0, current health <= staring health

    }
}

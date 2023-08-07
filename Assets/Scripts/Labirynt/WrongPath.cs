using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongPath : MonoBehaviour
{
    public void SetWrongPathScreen(){
        gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            gameObject.SetActive(false);
        }
    }
}

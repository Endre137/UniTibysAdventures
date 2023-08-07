using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void SetGameOverScreen(){
        gameObject.SetActive(true);
    }

    public void RestartButton(){
        SceneManager.LoadScene("Map");
    }

    public void Update(){
        if(Input.GetKeyDown(KeyCode.Return)){
            SceneManager.LoadScene("Map");
        }
    }
}

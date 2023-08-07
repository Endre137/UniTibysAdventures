using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextChapter : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetNextChapterScreen(){
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

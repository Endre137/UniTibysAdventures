using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColorChange : MonoBehaviour
{   
    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;
    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = new Color(0.2431373f, 0.5215687f, 0.2039216f, 1.0f);
        
    }

    
    public void changeToDesert(){
        m_SpriteRenderer.color = new Color(0.9568627f, 0.9803922f, 0.6862745f, 1.0f);
    }

    public void changeToWinter(){
        m_SpriteRenderer.color = new Color(0.7294118f, 0.8509804f, 0.9803922f, 1.0f);
    }

    public void changeToSummer(){
        m_SpriteRenderer.color = new Color(0.2431373f, 0.5215687f, 0.2039216f, 1.0f);
    }

    public void changeToIsland(){
        m_SpriteRenderer.color = new Color(0.227451f, 0.7254902f, 0.9803922f, 1.0f);
    }

    public void changeToCave(){
        m_SpriteRenderer.color = new Color(0.1215686f, 0.1215686f, 0.1215686f, 1f);
    }
}

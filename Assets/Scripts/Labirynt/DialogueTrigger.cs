using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class DialogueTrigger : MonoBehaviour
{
    public List<Message> messages;

    public Actor[] actors;



    public void StartDialogue(){
        SetQuestion();
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
    } 

    //Set the question to the appropriate NPC
    public void SetQuestion(){
        
        
        actors[0].ChangeName(this.name);

        //Trim NPC from object name
        string questionNr = this.name.Substring(3);
       
    }

}



//[System.Serializable]
public class Message{
    public int actorId;
    public string message;

    public Message (int actorId, string message){
        this.actorId = actorId;
        this.message = message;
    }

}


[System.Serializable]
public class Actor{
    public string name;
    public Sprite sprite;

    public Actor (string name, Sprite sprite){
        this.name = name;
        this.sprite = sprite;
    }

    public void ChangeName(string name){
        this.name = name;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{   
    public Image actorImage;
    public TMP_Text actorName;
    public TMP_Text messageText;
    public RectTransform backgroundBox;

    public Animator animator;

    List<Message> currentMessages;
    Actor[] currentActors;
    int activeMessages = 0;
    public static bool isActive = false;
    public bool isFinished = false;


    public void OpenDialogue(List<Message> messages, Actor[] actors){
        currentMessages = messages;
        currentActors = actors;
        activeMessages = 0;

        Debug.Log("Started conversation! Loaded messages: "+ messages.Count);
        animator.SetBool("isOpen", true);
        isActive = true;
        isFinished = false;
        DisplayMessage();
    }


    void DisplayMessage(){
        Message messageToDisplay = currentMessages[activeMessages];
        //messageText.text = messageToDisplay.message;

        StopAllCoroutines();
        StartCoroutine(TypeMessage(messageToDisplay.message));

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite; 
    }

    public void NextMessage(){
        ++activeMessages;
        if(activeMessages < currentMessages.Count){
            DisplayMessage();
        }else{
            Debug.Log("Conversation ended!");
            isActive = false;
            animator.SetBool("isOpen", false);
            isFinished = true;


            
        }
    }

    IEnumerator TypeMessage (string message){
        messageText.text = ""; 
        foreach (char letter in message.ToCharArray())
        {
            messageText.text += letter;
            yield return null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isActive == true){
            NextMessage();
        }
    }
}

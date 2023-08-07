using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Button up;
    [SerializeField]
    private Button down;
    [SerializeField]
    private Button left;
    [SerializeField]
    private Button right;

    [SerializeField]
    private Button doTurn;

    [SerializeField]
    private DPlayerMove character;
    [SerializeField]
    DPlayerMovementClean characterClear;
    [SerializeField]
    UICommandList uiCommandList;

    private void OnEnable()
    {
        
        up?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.forward, 1f));
        down?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.back, 1f));
        left?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.left, 1f));
        right?.onClick.AddListener(() => SendMoveCommand(character.transform, Vector3.right, 1f));

        doTurn.onClick.AddListener(() => character.DoMoves());
        //clear.onClick.AddListener(() => new DPlayerMovementClean());
    }

    private void SendMoveCommand(Transform objectToMove, Vector3 direction, float distance)
    {
       
        ICommand movement = new Move(objectToMove, direction, distance);
                Debug.Log("Movement: "+ objectToMove);
        character?.AddCommand(movement);
        uiCommandList?.AddCommand(movement);
    }
}
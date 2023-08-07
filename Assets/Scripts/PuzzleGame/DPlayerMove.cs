using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPlayerMove : MonoBehaviour
{
    [SerializeField]
    private List<Move> commandList = new List<Move>();


    public int index = 0;
    private float verticalOffset = 0.1f;
    private Vector3 startPoint;
    private pointMaker pointMaker;


    private void Start()
    {
        startPoint = this.transform.position;
        startPoint.y = verticalOffset;
        pointMaker = this.GetComponent<pointMaker>();
    }

    public void AddCommand(ICommand command)
    {
        commandList.Add(command as Move);
    }

    public void DoMoves()
    {
        StartCoroutine(DoMovesOverTime());
    }
    public void ClearMoves()
    {
        commandList = new List<Move>();
    }
    private IEnumerator DoMovesOverTime()
    {
        foreach (Move move in commandList)
        {
            move.Execute();

            UpdateLine();
            index++;

            yield return new WaitForSeconds(0.5f);
        }
        index = 0;
    }

    public void UpdateLine()
    {
        if (pointMaker == null)
            return;

        List<Vector3> positions = new List<Vector3>();
        positions.Add(startPoint);

        for (int i = 0; i < index; i++)
        {
            Vector3 newPosition = commandList[i].GetMove() + positions[i];
            newPosition.y = verticalOffset;
            positions.Add(newPosition);
        }

        pointMaker.UpdateLine(positions);
    }
}


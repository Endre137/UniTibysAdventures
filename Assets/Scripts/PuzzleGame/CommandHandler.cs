using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandHandler
{

    private List<ICommand> commandList = new List<ICommand>();
    private int index;

    public void AddCommand(ICommand command)
    {
        if (index < commandList.Count)
            commandList.RemoveRange(index, commandList.Count - index);

        commandList.Add(command);
        command.Execute();
        index++;
    }

}




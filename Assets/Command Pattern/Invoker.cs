using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour {

    //private Command _command;

    public List<Command> _commandList = new List<Command>();

    public void SetCommand(Command command)
    {
        //this._command = command;
        _commandList.Add(command);
    }

    public void ExecuteCommand(Receiver receiver)
    {
        //_command.Execute(receiver);

        _commandList[0].Execute(receiver);
        _commandList.RemoveAt(0);
    }

    public void ExecuteAllCommands(Receiver receiver)
    {
        //_command.Execute(receiver);
        foreach (Command command in _commandList)
        {
            command.Execute(receiver);
        }
        _commandList.Clear();
    }
}


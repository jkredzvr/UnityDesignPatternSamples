using System;
using UnityEngine;

class CommandPattern_App : MonoBehaviour
{
    void Start()
    {
        //Create instance of a receiver
        Receiver receiver = new Receiver();

        //Create instances of commands
        Command fireCommand = new Fire();
        Command jumpCommand = new Jump();

        //Create instance of invoker
        Invoker invoker = new Invoker();


        //Set commands into invoker
        //Commands are decoupled from the reciever
        //command is packaged as an object to be set by the invoker and consumed by the receiver
        invoker.SetCommand(fireCommand);
        invoker.SetCommand(jumpCommand);

        invoker.ExecuteCommand(receiver);
        Console.Write("break");
        invoker.ExecuteCommand(receiver);
        Console.Write("break");

        invoker.SetCommand(fireCommand);
        invoker.SetCommand(jumpCommand);
        invoker.SetCommand(fireCommand);
        invoker.SetCommand(jumpCommand);

        invoker.ExecuteAllCommands(receiver);


    }
}
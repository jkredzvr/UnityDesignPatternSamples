using System;

//Concrete implementation of Command
public class Jump : Command
{
    public void Execute(Receiver receiver)
    {
        Console.Write("jump");

        //Execute specific code that executes jump...
        //like start animation
    }
}

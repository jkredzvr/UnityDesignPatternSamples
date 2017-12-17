using System;

//Concrete implementation of Command
public class Fire : Command
{
    public void Execute(Receiver receiver)
    {
        Console.Write("fire");

        //Execute specific code that executes fire...
        //like start animation
    }
}

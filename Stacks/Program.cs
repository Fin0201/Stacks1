using System;
using System.Collections.Generic;

namespace Pop_Top_Push_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stringStack = new Stack<string>(); //Creates a stack called mySrting

            stringStack.Push("Hello"); //Adds this to the op of the stack
            stringStack.Push("This value is in the middle.");
            stringStack.Push("This value is on top.");

            Console.WriteLine(stringStack.Pop()); //Outputs and removes the string at the top of the stack

            Console.WriteLine(stringStack.Peek()); //Outputs the top string but does not remove it




            Console.WriteLine(); //Creates a space in the console so it is easier to read what outputs next.
            foreach (var item in stringStack) //Displays the remaining items in the stack.
            {
                Console.WriteLine(item);
            }
        }
    }

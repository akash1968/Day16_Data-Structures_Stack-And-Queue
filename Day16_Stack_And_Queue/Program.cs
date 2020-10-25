// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace Day16_Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC-1-Create a Stack
            //Creating an object of class LinkedListStackAndQueue
            LinkedListStackAndQueue stack = new LinkedListStackAndQueue();
            // Adding elements to Stack
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            Console.WriteLine("Elements Present in the stack: ");
            stack.Display();
            //Peek and Pop from the Stack till the Stack is Empty
            stack.IsEmpty();
            stack.Display();
        }
    }
}

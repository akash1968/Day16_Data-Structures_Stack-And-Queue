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
           // UC_3- Ability to create a Queue
            LinkedListQueue newQueue = new LinkedListQueue();
            newQueue.Enqueue(56);
            newQueue.Enqueue(30);
            newQueue.Enqueue(70);
            //Displaying the Queue
            Console.WriteLine("Displaying Queue Elements: ");
            newQueue.Display();
            //UC_4- Ability to Dequeue from the Queue
            newQueue.Dequeue();
            //Displaying the Queue
            Console.WriteLine("Displaying Queue Elements After Dequeue the first: ");
            newQueue.Display();
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListQueue.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_Stack_And_Queue
{
    class LinkedListQueue
    {
        Node head;
        // UC3- Method implementing the enquque process to the queue
        public void Enqueue(int item)
        {
            // Creating the node of the queue
            Node new_node = new Node(item);
            // If the head is null - Assigning the head to the new node
            // Else finding the end of the queue to insert the new Node
            if (this.head==null)
            {
                this.head = new_node;
            }
            else
            {
                //Creating a temporary variable
                Node temp = this.head;
                //Iterating till we find the head of the node
                while (temp.next!=null)
                {
                    temp = temp.next;
                }
                //Assigning the new node to the end of the queue
                temp.next = new_node;
            }
            Console.WriteLine("Inserted into the Queue "+ new_node.data);
        }
        // UC4- Ability to dequeue from the beginning
        public void Dequeue()
        {
            // if empty then return NULL.  
            if (this.head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
           //Store previous head and move head pointer one step ahead to delete the current element
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("\nElement to be deleted from the queue = {0}", temp.data);
        }
        public void Display()
        {
            // Creating a temporary node
            Node temp = this.head;
            // Checking the end condition if the queue is Empty
            if (temp==null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                // Traversing till the head of the queue
                // Displaying the element in the queue and then incrementing the position
                while (temp!=null)
                {
                    Console.WriteLine(" "+ temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}

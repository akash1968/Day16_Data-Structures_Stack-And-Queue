// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListStackAndQueue.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Day16_Stack_And_Queue
{
    public class LinkedListStackAndQueue
    {
        // Declaring the top node of the stack
        private Node top;
        // Constructor declaring the top of the stack to contain null as reference
        public LinkedListStackAndQueue()
        {
            this.top = null;
        }
        // UC 1- Stack
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top != null)
            {
                // taking previous top node address and assigning into new node of next,
                //making connection between previous node and current new node.
                // If the stack is empty then pushing the incoming node to bottom of the stack
                node.next = this.top;
            }
            //moving top pointer into new node
            this.top = node;
            Console.WriteLine(value + " is pushed into the stack");
        }
        public void Display()
        {
            //Declaring a temp variable to traverse along the stack
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                // if the pointer is not null then displaying the stack data
                while (temp != null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }
            }
           
        }
    }
}

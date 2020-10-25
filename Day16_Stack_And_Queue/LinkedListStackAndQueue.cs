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
                    // moving the pointer to next node
                    temp = temp.next;
                }
            }
        }
        public void Peek()
        {
            //Returning the end condition when Stack is empty
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            //Displaying the value in the top of the stack
            Console.WriteLine("\nValue in the top of the stack is = " + this.top.data);
        }
        // Popping from the Stack till the stack is empty        
        public void Pop()
        {
            // Checking for the end condition till the Stack is Empty
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty. Deletion is possible in the Stack");
                return;
            }
            Console.WriteLine("Value to be popped is =" + this.top.data);
            //Popping the node by reducing the nodes 
            //Shorting the node by restoring the next node reference to current node
            this.top = this.top.next;
        }
        // Popping till the Stack is empty and Peeking from the top element in the Stack
        public void IsEmpty()
        {
            // Iterating till the entire stack is empty
            while (this.top != null)
            {
                //Denoting the top element of the Stack
                Peek();
                //Popping the element from the Stack
                Pop();
            }
        }
    }
}

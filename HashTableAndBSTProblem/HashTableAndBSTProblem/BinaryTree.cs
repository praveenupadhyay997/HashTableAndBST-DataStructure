// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinaryTree.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HashTableAndBSTProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class BinaryTree<T> where T : IComparable
    {
        // Node value in the Binary tree
        public T nodeData { get; set; }
        // Left Order Tree storing the element less than the node data
        public BinaryTree<T> leftTree { get; set; }
        // Right Order Tree storing the element greater than the node data
        public BinaryTree<T> rightTree { get; set; }
        public int leftCount = 0;
        public int rightCount = 0;
        //Primary Parameterised Constructor to mark the formation of a new binary tree
        public BinaryTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        //UC1- Insert the element in the specified node depending upon the value passed by user as item
        public void Insert(T item)
        {
            T currentNodeValue = this.nodeData;
            // Checking the value comparator invoked from the IComparable Class
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    //Creating a binary tree node
                    this.leftTree = new BinaryTree<T>(item);
                    this.leftCount++;
                    Console.WriteLine("Inserting " + item);
                }
                else
                {
                    this.leftCount++;
                    //Recursive call to progress in the insertion of the item
                    this.leftTree.Insert(item);
                }       
            }
            //Inserting into the right tree in case the current node value is less than the passed value
            else if((currentNodeValue.CompareTo(item)) < 0)
            {
                if (this.rightTree == null)
                {
                    //Creating a binary tree node
                    this.rightTree = new BinaryTree<T>(item);
                    this.rightCount++;
                    Console.WriteLine("Inserting " + item);
                }
                else
                {
                    //Recursive call till the insertion is reached
                    this.rightTree.Insert(item);
                    this.rightCount++;
                    Console.WriteLine("Inserting " + item);
                }
            }
            else
                Console.WriteLine("No Insertion Possible. Value same as the node value...");
        }
        /// <summary>
        /// Displaying the Binary tree In the default In- Order from left branch to node to right branch
        /// </summary>
        public void Display()
        {
            //Traversing the left binary tree
            if (this.leftTree != null)
            {
                this.leftTree.Display();
            }
            //Displaying the items at the node
            Console.WriteLine(this.nodeData.ToString());
            //Traversing the right binary tree
            if (this.rightTree != null)
            {
                this.rightTree.Display();
            }
        }
        /// <summary>
        /// UC-5 Function Returning the size of the binary tree
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("Left Count Size = " + this.leftCount);
            Console.WriteLine("Right Count Size = "  + this.rightCount);
            Console.WriteLine("Total elements in the binary tree =" + (this.leftCount+1+this.rightCount));
        }
        /// <summary>
        /// UC6- Function to return whether the element is present in the binary tree or not
        /// </summary>
        /// <param name = "item" ></ param >
        /// < returns ></ returns >
        public void PresentOrNot(int item)
        {
            //Traversing the left binary tree
            if (this.leftTree != null)
            {
                this.leftTree.PresentOrNot(item);
            }
            //Check condition for the element present in the binary tree
            if(this.nodeData.ToString() == item.ToString())
                Console.WriteLine("{0} is Present in the Binary Tree...",item);
            //Traversing the right binary tree
            if (this.rightTree != null)
            {
                this.rightTree.PresentOrNot(item);
            }
        }
    }
}
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
        public int leftCount;
        public int rightCount;
        //Primary Parameterised Constructor to mark the formation of a new binary tree
        public BinaryTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        //UC1- Inset the element in the specified node depending upon the value passed by user as item
        public void Insert(T item)
        {
            T currentNodeValue = this.nodeData;
            // Checking the value comparator invoked from the IComparable Class
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinaryTree<T>(item);
                    Console.WriteLine("Inserting " + item);
                }
                else
                    this.leftTree.Insert(item);
            }
            //Inserting into the right tree in case the current node value is less than the passed value
            else if((currentNodeValue.CompareTo(item)) < 0)
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new BinaryTree<T>(item);
                    Console.WriteLine("Inserting " + item);
                }
                else
                {
                    this.rightTree.Insert(item);
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
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }

            Console.WriteLine(this.nodeData.ToString());

            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
        /// <summary>
        /// Function Returning the size of the binary tree
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
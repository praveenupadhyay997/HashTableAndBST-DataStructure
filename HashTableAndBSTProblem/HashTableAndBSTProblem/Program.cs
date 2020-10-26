// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HashTableAndBSTProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    class Program
    {
        public static HashTableMap<string, string> mapNode = new HashTableMap<string, string>(5);
        //Declaring an instance of the hash table class with size five equivalent to number of words in the sentence
        public static HashTableMap<string, string> mapNodeForLongSentence = new HashTableMap<string, string>(18);
        //The sentence words as array
        public static string[] sentence = {"Paranoids", "are", "not", "paranoid", "because", "they", "are", "paranoid", "but", "because", "they" +
                              "keep", "putting", "themselves", "deliberately", "into", "paranoid", "avoidable", "situations" };
        public static void GetFrequency()
        {
            //String array storing all the key in the hash table
            string[] keyValue = new string[] { "0", "1", "2", "3", "4", "5" };
            //Declaring a hash set to store all the distinct values present inside the hash-table construct
            HashSet<string> distinctValue = new HashSet<string>();
            //Traversing the key values and getting the value present in the hash-table struct
            foreach (var value in keyValue)
            {
                distinctValue.Add(mapNode.Get(value).ToLower());
            }
            Console.WriteLine("=====================================");
            //Iterating the hash set to get the count of each value
            foreach (var values in distinctValue)
            {
                //Counter variable
                int count = 0;
                foreach (var value in keyValue)
                {
                    //Condition to match the hash set distinct element with the hash set value
                    if (values == mapNode.Get(value))
                        ++count;
                }
                Console.WriteLine("Frequency of {0} is {1}", values, count);
            }
        }
        /// <summary>
        /// UC2- To Get the frequency of the words present in the long sentence
        /// </summary>
        public static void GetFrequencyOfLongSentence()
        {   
            List<string> keyValue=new List<string> { "0" };
            int sizeCount = sentence.Count();
            Console.WriteLine(sizeCount);
            //Creating a hash map with the key- value pair
            //Creating a list of keys as well
            for(int i=0; i<sizeCount; i++)
            {
                if(i != 0)
                keyValue.Add(Convert.ToString(i));
                mapNodeForLongSentence.Add(Convert.ToString(i), sentence[i]);
            }

            //Declaring a hash set to store all the distinct values present inside the hash-table construct
            HashSet<string> distinctValue = new HashSet<string>();
            //Traversing the key values and getting the value present in the hash-table struct
            foreach (var value in keyValue)
            {
                distinctValue.Add(mapNodeForLongSentence.Get(value).ToLower());
            }
            Console.WriteLine("=====================================");
            //Iterating the hash set to get the count of each value
            foreach (var values in distinctValue)
            {
                //Counter variable
                int count = 0;
                foreach (var value in keyValue)
                {
                    //Condition to match the hash set distinct element with the hash set value
                    if (values == mapNodeForLongSentence.Get(value))
                        ++count;
                }
                Console.WriteLine("Frequency of {0} is {1}", values, count);
            }
        }
        /// <summary>
        /// UC3- Delete the avoidable words in the long sentence
        /// </summary>
        /// <param name="wordToDelete"></param>
        public static void DeleteAvoidableWord(string wordToDelete)
        {
            List<string> keyValue=new List<string> { "0" };
            //Creating a list of keys as well
            for (int i = 0; i < sentence.Count(); i++)
            {
                if (i != 0)
                    keyValue.Add(Convert.ToString(i));
            }
            foreach (var value in keyValue)
            {
                //Condition to match the hash set dvalue with the removable value
                //Calling the remove method and passing the key to remove the word from the sentence
                if (wordToDelete == mapNodeForLongSentence.Get(value))
                    mapNodeForLongSentence.Remove(value);
            }
            mapNodeForLongSentence.Display();
        }
        public static void HashTableOperation()
        {
            //Adding the value at a designated key value pair
            Console.WriteLine("Adding KeyValue pair");
            mapNode.Add("0", "To");
            mapNode.Add("1", "be");
            mapNode.Add("2", "or");
            mapNode.Add("3", "not");
            mapNode.Add("4", "to");
            mapNode.Add("5", "be");
            //Calling the function to get the frequency of the words present in the hash map
            //Performing not more than a traversal operation on the kay value struct
            GetFrequency();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("Frequency of word for  long  sentence");
            Console.WriteLine("=====================================");
            GetFrequencyOfLongSentence();
            Console.ReadLine();
            Console.Clear();
            //Passing the word paranoid to get it removed
            DeleteAvoidableWord("paranoid");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BinaryTreeOperation()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(11);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(65);
            binaryTree.Insert(63);
            binaryTree.Insert(67);
            //UC3- Search for a particular element in the Binary Tree
            binaryTree.PresentOrNot(3);
            binaryTree.Display();
            binaryTree.GetSize();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Welcome to the Hash-Table Replication");
            Console.WriteLine("=====================================");
            HashTableOperation();

            Console.WriteLine("======================================");
            Console.WriteLine("Welcome to the Binary-Tree Replication");
            Console.WriteLine("======================================");
            BinaryTreeOperation();
        }
    }
}

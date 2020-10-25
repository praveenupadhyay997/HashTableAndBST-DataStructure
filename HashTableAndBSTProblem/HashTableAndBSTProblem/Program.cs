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
    using System.Threading;
    class Program
    {
        //Declaring an instance of the hash table class with size five equivalent to number of words in the sentence
        public static HashTableMap<string, string> mapNode = new HashTableMap<string, string>(5);
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
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Welcome to the Hash-Table Replication");
            Console.WriteLine("=====================================");
           
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
        }
    }
}

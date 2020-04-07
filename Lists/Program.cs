using System;
using System.Collections.Generic;

namespace Lists {
    class Program {
        static void Main(string[] args) {
            
            // Declaring a new list
            List<int> myList = new List<int>();
            myList.Add(5);
            myList.Add(7);
            myList.Add(3);

            // Display the list items
            Console.WriteLine("myList contains " + myList.Count + " items.");
            foreach (int num in myList) {
                Console.WriteLine(num);
            }
            
            // RemoveAt removes at a key, IndexOf finds the key of a selected item, here (7)
            myList.RemoveAt(myList.IndexOf(7));
            
            // Display the list items again, item 7 has been removed
            Console.WriteLine("myList contains " + myList.Count + " items.");
            foreach (int num in myList) {
                Console.WriteLine(num);
            }
            
            Console.ReadLine();
        }
    }
}
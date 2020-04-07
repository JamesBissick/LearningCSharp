using System;

namespace MoreOrLess {
    
    class Program {
        
        static void Main(string[] args) {
            // Welcome message
            Console.WriteLine("Let's play \"Guess a Number!\"\n");
            // CPU choose a random num between 1 & 100
            Random rand = new Random();
            int randInt = rand.Next(1, 101);
            int count = 0;
            int answer;
            
             do {
                 // User tries to find the chosen num
                 Console.WriteLine("Guess the number:");
                 String inputUser = Console.ReadLine();
                 
                 if (int.TryParse(inputUser, out answer)) {
                     if (answer > randInt) {
                         Console.WriteLine("The number is lower.");
                         count++;
                     }
                     else if (answer < randInt) {
                         Console.WriteLine("The number is higher.");
                         count++;
                     }
                     else if (answer == randInt) {
                         Console.WriteLine("\n🎉 Congrats! You've found the secret number!");
                         count++;
                         // If user find the num, CPU display number of tries
                         Console.WriteLine("Found in " + count + " tries.");
                         Console.ReadLine();
                     }
                     else {
                         Console.WriteLine("Something went wrong!");
                     }
                 }
             } while (answer != randInt);
        }
        
    }
}
using System;

namespace DiceRoll {
    
    class Program {
        
        static void Main(string[] args) {

            String answer;
            do {
                Console.WriteLine("🎲 Roll the dice:");
                Random rand = new Random();
                int randInt = rand.Next(1, 7);
                Console.WriteLine("\n" + randInt);
                Console.WriteLine("\n Roll the dice again? (Y/N)");
                answer = Console.ReadLine();
            } while (answer != "n");
            
        }
        
    }
}
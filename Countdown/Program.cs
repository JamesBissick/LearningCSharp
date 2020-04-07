using System;

namespace Countdown {
    class Program {
        
        static void Main(string[] args) {
            // Ask for a number
            Console.WriteLine("Enter a number:");
            String answer = Console.ReadLine();
            int num;
            
            // Test if number is correct
            if (int.TryParse(answer, out num)) {
                // if true : countdown
                Console.Clear();
                while (num >= 0) {
                    Console.WriteLine(num);
                    num--;
                }
            }
            else {
                // else : display error message
                Console.WriteLine("Sorry, your number is incorrect.");
            }
            // End of program
            Console.ReadKey();
        }
        
    }
    
}
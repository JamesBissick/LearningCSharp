using System;

namespace Enums {
    
    class Program {
        
        // Declaring an enum
        public enum Quality {
            Gold,
            Silver,
            Bronze
        }
        
        static void Main(string[] args) {

            Quality product = Quality.Gold;
            Console.WriteLine(product);
            
            Console.ReadLine();
        }
    }
}
using System;

namespace HelloWorld {
    
    class Program {
        
        static void Main(string[] args) {
            // String msg = "Hello World!";
            // Console.WriteLine(msg);

            int i = 3;
            int sum = add(i, 5);
            Console.WriteLine(sum);
            
            Console.ReadKey();
        }
        
        // You can use dynamic comment to indicate what the function does with 3 slashes.
        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="nb1">Number #1</param>
        /// <param name="nb2">Number #2</param>
        /// <returns></returns>
        static int add(int nb1, int nb2) {
            return nb1 + nb2;
        }
    }
}
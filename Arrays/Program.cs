using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {
            
            // Declare an array of ints
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = 2 * i;
            }
            
            // Display each of the items in arr
            Console.WriteLine("2D array:");
            foreach (int num in arr) {
                Console.WriteLine(num);
            }
            
            // 3D array
            int[,] matrix = new int[2, 2];

            for (int line = 0; line < 2; line++) {
                for (int col = 0; col < 2; col++) {
                    matrix[line, col] = line * 10 + col;
                }
            }

            // Display each of the items in matrix
            Console.WriteLine("\n3D array:");
            foreach (int num2 in matrix) {
                Console.WriteLine(num2);
            }
            
            Console.ReadLine();
        }
    }
}
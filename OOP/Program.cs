using System;

namespace OOP {
    class Program {
        static void Main(string[] args) {
            Animal Dog = new Animal("Napoleon", 3);
            Animal Cat = new Animal("Garfield", 8);
            
            Dog.speak("Wouf!");
            Cat.speak("Miaow!");
            
            Console.WriteLine(Cat.Age);
            Dog.Age = -5;
            Console.WriteLine(Cat.Age);
            Dog.Age = 9;
            Console.WriteLine(Cat.Age);

            Animal Pip = new Animal("Pip", 4);
            Console.WriteLine(Pip);
            
            Dog.Bite();
            
            Console.WriteLine(Animal.numAnimals + " animals created.");
            
            // Advanced OOP Notions
            
            // Reference variable
            Animal SecondDog = Dog; // SecondDog is copying the address because it's a reference to an (object)
            Console.WriteLine("\nTesting Advanced OOP notion of reference type");
            SecondDog.Age = 8; // Will affect SecondDog but also Dog, because they share the same address, they are the same dog!
            Console.WriteLine(Dog);
            Console.WriteLine(SecondDog);
            
            // Value variable
            int i = 3;
            int j = i; // j is copying the value 3, because its a value type
            j++;
            Console.WriteLine("\nTesting Advanced OOP notion of value type");
            Console.WriteLine(j);
            Console.WriteLine(i); // Not affected by incrementing j because its a value type (int)
            
            Console.ReadKey();
        }
    }
}
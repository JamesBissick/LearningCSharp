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
            
            Console.ReadKey();
        }
    }
}
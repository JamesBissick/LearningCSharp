using System;

namespace OOP {
    public class Animal : IBite {
        
        private String name;
        public String Name {
            get => name;
            set => name = value;
        }
        
        private int age;
        public int Age {
            get => age;
            set {
                if (value >= 0) {
                    age = value;
                }
            }
        }

        public static int numAnimals = 0;

        /// <summary>
        /// Animal Constructor with name and age
        /// </summary>
        /// <param name="_name">String name</param>
        /// <param name="_age">Int age</param>
        public Animal(String _name, int _age) {
            Name = _name;
            this.Age = _age;
            numAnimals++;
        }
        

        public void speak(String word) {
            Console.WriteLine(Name + " : " + word);
        }

        public override string ToString() {
            return name + " (" + age + "yo)";
        }

        public void Bite() {
            Console.WriteLine(name + " is biting.");
        }
    }
}
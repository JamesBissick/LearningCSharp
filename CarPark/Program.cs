using System;
using System.Collections.Generic;

namespace CarPark {
    class Program {
        private static List<Vehicle> listVehicles;
        
        static void Main(string[] args) {

            listVehicles = new List<Vehicle>();
            int choice = 0;

            while (choice != 5) {
                switch (choice) {
                    case 1:
                        // Display list
                        DisplayList();
                        break;
                    case 2:
                        // Add a car
                        AddCar();
                        break;
                    case 3:
                        // Add an utility car
                        AddUtilityCar();
                        break;
                    case 4:
                        // Remove a vehicle
                        RemoveVehicle();
                        break;
                }
                choice = DisplayMenu();
            }
        }
        
        private static int DisplayMenu() {
            do {
                Console.WriteLine("Car park managing tool");
                Console.WriteLine(listVehicles.Count + " vehicles in the park.\n");
                Console.WriteLine("1: Display list of vehicles");
                Console.WriteLine("2: Add a car");
                Console.WriteLine("3: Add an utility car");
                Console.WriteLine("4: Remove a vehicles");
                Console.WriteLine("5: Quit\n");

                String answer = Console.ReadLine();
                int choice;
                if (int.TryParse(answer, out choice)) {
                    if (choice > 0 && choice <= 5) {
                        return choice;
                    }
                }
            } while (true);
        }
        private static void DisplayList() {
            Console.WriteLine("Vehicle list:");
            foreach (Vehicle v in listVehicles) {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n");
        }

        private static void AddCar() {
            Console.WriteLine("Add a car:");
            Console.Write("Registration? ");
            String reg = Console.ReadLine();
            Console.Write("Brand? ");
            String bran = Console.ReadLine();
            Console.Write("Color? ");
            String col = Console.ReadLine();
            Console.Write("Number of doors? ");
            int numDoors = ReadInt();
            Vehicle car = new Car(reg, bran, col, numDoors);
            listVehicles.Add(car);
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Make sure that user enters a correct int when asked for the number of doors
        /// </summary>
        /// <returns>Int number of doors</returns>
        private static int ReadInt() {
            while (true) {
                int num;
                if (int.TryParse(Console.ReadLine(), out num)) {
                    return num;
                }
            }
        }
        
        private static void AddUtilityCar() {
            Console.WriteLine("Add an utility car:");
            Console.Write("Registration? ");
            String reg = Console.ReadLine();
            Console.Write("Brand? ");
            String bran = Console.ReadLine();
            Console.Write("Color? ");
            String col = Console.ReadLine();
            Console.Write("Volume in Liter? ");
            int vol = ReadInt();
            UtilityCar car = new UtilityCar(reg, bran, col, vol);
            listVehicles.Add(car);
            Console.WriteLine("\n");
        }

        private static void RemoveVehicle() {
            bool RemoveOK = false;
            do {
                Console.WriteLine("Remove a vehicle from his registration");
                Console.Write("Registration? ");
                String registration = Console.ReadLine();
                int index = SearchVehicle(registration);
                if (index >= 0) {
                    listVehicles.RemoveAt(index);
                    RemoveOK = true;
                    Console.WriteLine("Vehicle has been removed.\n");
                }
                else {
                    RemoveOK = false;
                    Console.WriteLine("Sorry, this vehicle doesn't exist.\n");
                }
            } while (!RemoveOK);
        }
        /// <summary>
        /// Search a vehicle by its registration
        /// </summary>
        /// <param name="regis"></param>
        /// <returns></returns>
        private static int SearchVehicle(String regist) {
            foreach (Vehicle v in listVehicles) {
                if (v.Registration.Equals(regist)) {
                    return listVehicles.IndexOf(v);
                }
            }
            return -1;
        }
    }
}
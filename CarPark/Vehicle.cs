using System;

namespace CarPark {
    public abstract class Vehicle {
        
        private String registration;
        public string Registration {
            get => registration;
            set => registration = value;
        }
        
        private String brand;
        public string Brand {
            get => brand;
            set => brand = value;
        }
        
        private String color;
        public string Color {
            get => color;
            set => color = value;
        }
        public static int numVehicles = 0;
        
        /// <summary>
        /// Vehicle constructor
        /// </summary>
        /// <param name="_registration">String registration</param>
        /// <param name="_brand">String brand</param>
        /// <param name="_color">String color</param>
        public Vehicle(String _registration, String _brand, String _color) {
            Registration = _registration;
            Brand = _brand;
            Color = _color;
        }

        public override string ToString() {
            return "Vehicle " + registration + " (" + brand + ", " + color + ")";
        }
    }
}
using System;

namespace CarPark {
    public class Car : Vehicle {
        public int doors;
        public Car(String _registration, String _brand, String _color, int _doors) 
            : base(_registration, _brand, _color) {
            doors = _doors;
        }
        public override string ToString() {
            return base.ToString() + " car with " + doors + " doors";
        }
    }
}
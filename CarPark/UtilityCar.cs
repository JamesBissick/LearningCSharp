using System;

namespace CarPark {
    public class UtilityCar : Vehicle {
        public int volume;

        public UtilityCar(String _registration, String _brand, String _color, int _volume) 
            : base(_registration, _brand, _color) {
            volume = _volume;
        }
        public override string ToString() {
            return base.ToString() + " utility car with " + volume + "L";
        }
    }
}
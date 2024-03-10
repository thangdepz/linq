using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21115053120145_huynhkimthang_LinQ
{
    internal class Car:Vehicle
    {
        private int numberOfSeats;
        public Car() { }
        public Car(string name, string brand, int year, float price, int numberOfSeats) :base(name, brand, year, price)
        { 
            this.numberOfSeats = numberOfSeats;
        }
        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
    }
}

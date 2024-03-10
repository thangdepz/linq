using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21115053120145_huynhkimthang_LinQ
{
    internal class Vehicle
    {
        private string name;
        private string brand;
        private int year;
        private float price;
        public Vehicle() { }
        public Vehicle(string name, string brand, int year, float price)
        {
            this.name = name;
            this.Brand = brand;
            this.year = year;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Year { get => year; set => year = value; }
        public float Price { get => price; set => price = value; }
    }
}

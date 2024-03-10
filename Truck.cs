using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21115053120145_huynhkimthang_LinQ
{
    internal class Truck:Vehicle
    {
        private string ownerCompany;
        public Truck() { }
        public Truck(string name, string brand, int year, float price, string ownerCompany):base(name, brand, year, price)
        {
            this.ownerCompany = ownerCompany;
        }

        public string OwnerCompany { get => ownerCompany; set => ownerCompany = value; }
    }
}

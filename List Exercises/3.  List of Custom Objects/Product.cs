using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.__List_of_Custom_Objects
{
    internal class Product
    {
        private string name;
        private double price;
        private int quantity;

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            private set { quantity = value; }
        }


        public void IncreasePrice(int percentage)
        {
            this.Price += price * (percentage / 100.0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Display();
    }

    public class Drink : Item
    {
        public Drink(string name, double price) : base(name, price) { }

        public override void Display()
        {
            Console.WriteLine($"Напиток: {Name}, Цена: {Price:C}");
        }
    }

    public class Snack : Item
    {
        public Snack(string name, double price) : base(name, price) { }

        public override void Display()
        {
            Console.WriteLine($"Закуска: {Name}, Цена: {Price:C}");
        }
    }
}

using System;
using System.ComponentModel;

namespace MagazynProba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Inventory magazyn = new Inventory();
            Shoe but = new Shoe("but 1", Size.L, GenerateProductId.GenerateNewId(magazyn));

            magazyn.ProductInventory.Add(but);

            magazyn.ProductInventory.Add(new Shoe("but2021", Size.S, GenerateProductId.GenerateNewId(magazyn)));
            magazyn.ProductInventory.Add(new Shoe("but3", Size.S, GenerateProductId.GenerateNewId(magazyn)));

            magazyn.DisplayInventoryList();




        }
    }
}

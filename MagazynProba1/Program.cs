using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MagazynProba1
{
    class Program
    {
        static void Main(string[] args)
        {

            Inventory magazyn = new Inventory();

            magazyn.ProductInventory.Add(new Shoe("but2021", Size.S, GenerateProductId.GenerateNewId(magazyn)));
            magazyn.ProductInventory.Add(new Component(4, "produktTestowy"));
            magazyn.ProductInventory.Add(new Component(444, "produktTestowy 4343"));
            magazyn.ProductInventory.Add(new Shoe("d", Size.L, 64));
            magazyn.ProductInventory.Add(new Shoe("453", Size.S, 7784));

            magazyn.DisplayInventoryList();

            //AddFiveToQuantity(magazyn.ProductInventory);
            //Console.WriteLine("aktualizacja o 5");

            //magazyn.DisplayInventoryList();
            //AddFiveToQuantity(magazyn.ProductInventory);
            //Console.WriteLine("kolejna aktualizacja o 5");

            //magazyn.DisplayInventoryList();


            // pokaż zdjecia
            ShowProductPicture picture = new ShowProductPicture();
            foreach (var itemProduct in magazyn.ProductInventory)
            {
                picture.DisplayProductPicture(itemProduct);
            }

           magazyn.ChooseProductToChange();

            magazyn.DisplayInventoryList();

        }

        public static void AddFiveToQuantity(List<IProduct> lista)
        {
            foreach (var product in lista)
            {
                product.UpdateQuantity(5d);
            }
        }
    }
}

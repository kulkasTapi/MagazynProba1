using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MagazynProba1
{
    class Inventory
    {
        public List<IProduct> ProductInventory { get; set; } = new List<IProduct>();

        public void DisplayInventoryList()
        {
            foreach (var product in ProductInventory )
            {
                Console.WriteLine($"Nazwa produktu : {product.ProductName} , dostawca {product.Supplier}, ilosc {product.StockQuantitiy}, id {product.ProductId}");
            }
        }


        public void ChangeQuantity(Inventory productInventory)
        {
            // jakos przeliterować po liście produktów do wyboru
            // a następnei wpisać co ma być

            Console.WriteLine("Jeśli chcesz dodać wpisz +, a jesli odjąc -");
            string  direction = Console.ReadLine();//tutaj powinna być walidacja
            Console.WriteLine($"Wybrany kierunek to: {direction }");
            Console.WriteLine("Podaj ilosc:");
            string quantityReadLine = Console.ReadLine();
            double quantity = Convert.ToDouble(quantityReadLine );



            if (direction == "+")
            {
                
            }

        }


        private double AddQuantityToInventory(double quantity)
        {
            double newQuantity= 0;
            //tutaj jakas logika dodawania
            return newQuantity;
        }

        private double SubtractQuantityFromInventory(double quantity)
        {
            double newQuantity = 0;
            // tutaj jakaś logika odejmowania
            return newQuantity;
        }

    }
}

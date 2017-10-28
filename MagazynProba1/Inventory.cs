using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace MagazynProba1
{
    class Inventory
    {
        public List<IProduct> ProductInventory { get; set; } = new List<IProduct>();


        public void DisplayInventoryList()
        {
            Console.WriteLine("{0,5} {1,5} {2,20} {3,20} {4,5}","index", "ProductId", "ProductName", "Supplier", "StockQuantitiy");
            foreach (var product in ProductInventory)
            {

                //Console.WriteLine($"Id {product.ProductId} Nazwa produktu : {product.ProductName} , dostawca {product.Supplier}, ilosc {product.StockQuantitiy}");

                Console.WriteLine(" {0,5} {1,5} {2,20} {3,20} {4,5}", ProductInventory.IndexOf( product), product.ProductId, product.ProductName, product.Supplier, product.StockQuantitiy);
            }
        }

        public void ChooseProductToChange()
        {
            //tę czesc można by wywalić do osobnej procedury nazwanej ChooseOperation
            DisplayInventoryList();
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1 zmienić ilość na magazynie");
            Console.WriteLine("2,3,4,5 itd do implementacji");
            Console.WriteLine("wpisz nr operacji");
            int operationNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("wpisz nr indexu towaru w którym chesz dokonać zmiany: ");
            int indexNumber = int.Parse(Console.ReadLine()); //brakuje walidacji

            if (operationNumber == 1)
            {
                ChangeQuantity(ProductInventory[indexNumber]);
            }
            else
            {
                Console.WriteLine("funkcja czekajaca na implementacje");
            }
        }

        public void ChangeQuantity(IProduct product)
        {
            //Console.WriteLine("wybierz produkt do zmiany");
            //int productToChcange = int.Parse(Console.ReadLine()); 
            // jakos przeliterować po liście produktów do wyboru
            // a następnei wpisać co ma być
Console.WriteLine("Jeśli chcesz dodać wpisz +, a jesli odjąc -");
            string direction = Console.ReadLine();//tutaj powinna być walidacja
            Console.WriteLine($"Wybrany kierunek to: {direction.ToString() }");
            Console.WriteLine("Podaj ilosc:");
            string quantityReadLine = Console.ReadLine();//brakuje walidacji
            double quantity = Convert.ToDouble(quantityReadLine);

            if (direction == "+")
            {
                //foreach (var itemProduct in inventory.ProductInventory )
                //{
                    AddQuantityToInventory(quantity, product );
               // }
                
            }
            else
            {
                //foreach (var itemProduct in inventory.ProductInventory)
                //{
                   SubtractQuantityFromInventory(quantity, product);
               // }

            }

        }


        private void AddQuantityToInventory(double quantity, IProduct product)
        {
          double oldQuantity = product.StockQuantitiy;
            double newQuantity = oldQuantity + quantity;
            product.UpdateQuantity(newQuantity);
        }

        private void SubtractQuantityFromInventory(double quantity, IProduct product)
        {
            double oldQuantity = product.StockQuantitiy;
            double newQuantity = oldQuantity - quantity;
            product.UpdateQuantity(newQuantity);
        }

    }
}

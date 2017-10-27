using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagazynProba1
{
    static class GenerateProductId
    {
        //chyba możan by zrobić z tego metodę statyczną, ale sam nie wiem
        public static int GenerateNewId(Inventory inventory)
        {
            bool isEmpty = inventory.ProductInventory.Any();
            if (isEmpty == true)
            {
                return 1;
            }
            else
            {
                // Funkcja sprawdza jakiej jest najwyższe ID w kolekcji obiektów i zwraca wartość wyższą o 5 
                int id = inventory.ProductInventory.Count;
                id = id + 5;
                return id;
            }
        }
    }
}

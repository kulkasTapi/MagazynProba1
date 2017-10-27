using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynProba1
{
    class Shoe : IProduct
    {
        public int ProductId { get; }
        public string ProductName { get; }
        public Status ProductStatus { get; }
        public TypeOfProduct Type { get; }
        public Supplier Supplier { get; }
        public double StockQuantitiy { get; }
        public Size SizeOfShoe { get; }

        //chwilowo tylko konstruktor defaultowy, powienien być jeszcze taki wtóym zaciagamy dane z bazy oraz taki wk tórym można pisać ilośc towaru an stanie od razu
        public Shoe(string productName, Size size, int productId)
        {
            ProductStatus = Status.OczekujeNaAkceptacje;
            Type = TypeOfProduct.But;
            ProductName = productName;
            Supplier = Supplier.Firma1;
            StockQuantitiy = 0D;
            ProductId = productId; //tutaj jakos wygenerować nowe id
            SizeOfShoe = size;

        }


        public void UpdateStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public void RenameProduct(string newName)
        {
            throw new NotImplementedException();
        }

        public void ChangeProductType(TypeOfProduct newType)
        {
            throw new NotImplementedException();
        }

        public void ChangeSupplier(Supplier newSupplier)
        {
            throw new NotImplementedException();
        }

        public void UpdateQuantity(double newQuantity)
        {
            throw new NotImplementedException();
        }

      
    }
}

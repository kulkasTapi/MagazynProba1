﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynProba1
{
    class Component: IProduct
    {
        public int ProductId { get; }
        public string ProductName { get; }
        public Status ProductStatus { get; }
        public TypeOfProduct Type { get; }
        public Supplier Supplier { get; }
        public double StockQuantitiy { get; private set; }

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
            StockQuantitiy = StockQuantitiy + newQuantity;
        }


        public Component(int productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
            ProductStatus = Status.Ok;
            Type = TypeOfProduct.Podeszwa;
            Supplier = Supplier.Firma3;
            StockQuantitiy = 0;
        }

    }
}

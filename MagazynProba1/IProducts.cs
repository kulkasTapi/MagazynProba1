using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynProba1
{

    interface IProduct
    {
        //docelowo zmiast enumow będzie połączenie z bazą danych i tabele słwonikowe
        int ProductId { get; }
        string ProductName { get; }
        Status ProductStatus { get; }
        TypeOfProduct Type { get; }
        Supplier Supplier { get; }

        //zupełnie mi to tutaj nie pasuje i raczej bym wydzielił do innej metody ale nie wiem jak zapisac to na listę chyb że dictionary
        //raczej zrobił bym to w tabeli gdzie wartość aktualną obliczał bym na podstawie grupowania wszystkich transakcji jakie działy sie dla danego produtu
        // no ale nie mam lepszego pomysłu (na razie) jak sie zabrać za to
        double StockQuantitiy { get;}


        void UpdateStatus(Status status);
        void RenameProduct(String newName);
        void ChangeProductType(TypeOfProduct newType);
        void ChangeSupplier(Supplier newSupplier);
        void UpdateQuantity(Double newQuantity);
    }
}

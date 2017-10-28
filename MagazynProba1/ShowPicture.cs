using System;
using System.Collections.Generic;
using System.Text;

namespace MagazynProba1
{
    class ShowProductPicture
    {
        //zasadniczo to chyba do nieczego nie potrzebuje kopii obiektu w tej klasie
        //public IProduct Product { get; set; }

        
        
        public void DisplayProductPicture(IProduct product)
        {
            if (product.Type == TypeOfProduct.But)
            {
                OpenPictureFromFile();
            }
            else if  (product.Type == TypeOfProduct.Podeszwa)
            {
                OpenPictureFromURL();
            }
            else
            {
                Console.WriteLine("Ta kategoria produktów nie ma zdjęć");
            }
        
        }


        // poniższe metody można by przenisć do innej klasy np. PicureOpener która determinuje na podstawie tego jaki jest typ produktu jak otworzyć zdjęcie (czy z pliku, url, jakiś iny folder)
        private void OpenPictureFromFile()
        {
            Console.WriteLine("Otwarto zdjecie produktu z pliku");
        }

        private void OpenPictureFromURL()
        {
            Console.WriteLine("Otwarto zdjecie z linku");
        }

    }
}

using System;
using System.Collections.Generic;


namespace fixation_exercise_session_nine.Entities
{
    class Product
    {
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }

        public Product()
        {
        }

        public Product(string nameProduct, double priceProduct)
        {
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
        }
    }
}
